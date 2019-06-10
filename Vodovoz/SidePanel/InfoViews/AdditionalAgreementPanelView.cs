﻿using System;
using System.Collections.Generic;
using System.Linq;
using Gamma.GtkWidgets;
using NHibernate.Proxy;
using NHibernate.Util;
using QS.Dialog.Gtk;
using QS.Helpers;
using QS.Tdi.Gtk;
using QS.Utilities;
using QSOrmProject;
using Vodovoz.Domain.Client;
using Vodovoz.Domain.Goods;
using Vodovoz.Repository;
using Vodovoz.Repository.Client;
using Vodovoz.SidePanel.InfoProviders;
using Vodovoz.ViewModelBased;
using QS.DomainModel.NotifyChange;

namespace Vodovoz.SidePanel.InfoViews
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class AdditionalAgreementPanelView : Gtk.Bin, IPanelView
	{
		private AdditionalAgreement[] WaterAgreements;

		DeliveryPoint DeliveryPoint { get; set; }

		IList<WaterSalesAgreementFixedPrice> fixedPricesList;

		public AdditionalAgreementPanelView()
		{
			this.Build();
			Configure();
		}

		void Configure()
		{
			labelNextService.LineWrapMode = Pango.WrapMode.WordChar;
			labelRent.LineWrapMode = Pango.WrapMode.WordChar;
			labelEquipmentCount.LineWrapMode = Pango.WrapMode.WordChar;

			NotifyConfiguration.Instance.BatchSubscribeOnEntity<WaterSalesAgreement>(UpdateCriteria);
		}

		void UpdateCriteria(EntityChangeEvent[] e)
		{
			if(DeliveryPoint != null) {
				var wsaList = e.Select(l => l.GetEntity<WaterSalesAgreement>());
				if(wsaList.Any(a => a.DeliveryPoint?.Id == DeliveryPoint.Id))
					Refresh();
			}
		}

		#region IPanelView implementation

		public void Refresh()
		{
			DeliveryPoint = (InfoProvider as IDeliveryPointInfoProvider)?.DeliveryPoint;
			if(DeliveryPoint == null)
				return;
			var allEquipmentAtDeliveryPoint = EquipmentRepository.GetEquipmentAtDeliveryPoint(InfoProvider.UoW, DeliveryPoint);
			labelEquipmentCount.Text = allEquipmentAtDeliveryPoint.Count + " шт.";
			var nextServiceText = "";
			var equipmentsWithNextServiceDate = allEquipmentAtDeliveryPoint
				.Where(eq => eq.NextServiceDate.HasValue);
			var eqWithMinDate = equipmentsWithNextServiceDate
				.Aggregate<Equipment, Equipment, Equipment>(null, (minEq, eq) => (minEq == null || (eq.NextServiceDate < minEq.NextServiceDate) ? eq : minEq), r => r);
			if(eqWithMinDate != null) {
				var nextServiceDate = eqWithMinDate.LastServiceDate.AddMonths(6);
				var daysTillNextService = (nextServiceDate - DateTime.Today).Days;
				nextServiceText = string.Format(
					"{0} (осталось {1} {2})",
					nextServiceDate.ToShortDateString(),
					daysTillNextService,
					NumberToTextRus.Case(daysTillNextService, "день", "дня", "дней")
				);
			}
			labelNextService.Text = nextServiceText;
			var agreements = AdditionalAgreementRepository.GetActiveAgreementsForDeliveryPoint(InfoProvider.UoW, DeliveryPoint);
			var dailyAgreements = agreements
				.OfType<DailyRentAgreement>()
				.OrderBy(a => a.EndDate);
			vboxRent.Visible = dailyAgreements.Any();
			var rentText = string.Join(
				"\n",
				dailyAgreements.Select(a => string.Format(
					"{0} - A до {1}",
					a.AgreementNumber,
					a.EndDate.ToShortDateString()
				)).ToArray()
			);
			labelRent.Text = rentText;
			var freeRent = agreements.OfType<FreeRentAgreement>();
			var requiredBottlesThisMonth = freeRent.SelectMany(a => a.Equipment).Sum(eq => eq.WaterAmount);
			var monthStart = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
			var monthEnd = monthStart.AddMonths(1).AddDays(-1);
			var bottlesThisMonth = DeliveryPointRepository.GetBottlesOrderedForPeriod(InfoProvider.UoW, DeliveryPoint, monthStart, monthEnd);
			var bottlesLeftToOrder = requiredBottlesThisMonth - bottlesThisMonth;
			var leftToOrderText = "";
			if(bottlesLeftToOrder > 0)
				leftToOrderText = string.Format(" (осталось: {0})", bottlesLeftToOrder);
			labelBottlesPerMonth.Text = string.Format("{0} из {1}{2}", bottlesThisMonth, requiredBottlesThisMonth, leftToOrderText);

			/*Отключено из-за ошибки. Задачи I-1221 и I-1020
			if(fixedPricesList != null)
				fixedPricesList.ToList().ForEach(x => InfoProvider.UoW.Session.Evict(x));*/
			if(Contract != null) {
				RefreshList();
			} else {
				fixedPricesList = new List<WaterSalesAgreementFixedPrice>();
			}

			ytreeviewFixedPrices.ColumnsConfig = ColumnsConfigFactory.Create<WaterSalesAgreementFixedPrice>()
				.AddColumn("Номенклатура")
					.AddTextRenderer(x => x.Nomenclature.ShortOrFullName)
				.AddColumn("Цена")
					.AddTextRenderer(x => string.Format("{0}р.", x.Price))
				.Finish();

			ytreeviewFixedPrices.SetItemsSource(fixedPricesList);

			ytreeviewFixedPrices.Visible = fixedPricesList.Any();
			hboxNotFixedPriceInfo.Visible = !fixedPricesList.Any();

			WaterAgreements = agreements.Where(a => a.Type == AgreementType.WaterSales).ToArray();
			buttonWaterAgreement.Visible = WaterAgreements.Any();
		}

		/// <summary>
		/// Временный метод для обхода ошибки в I-1221. Хорошо бы придумать отдельный клас с genericами,
		/// который бы содержал метод, обновляющий любые наши коллекции и поля внутри них.
		/// </summary>
		void RefreshList()
		{
			var wsa = Contract.AdditionalAgreements
							  .Select(x => x.Self).OfType<WaterSalesAgreement>()
							  .FirstOrDefault(a => a.DeliveryPoint == DeliveryPoint && !a.IsCancelled);
			if(wsa == null)
				wsa = Contract.AdditionalAgreements
							  .Select(x => x.Self).OfType<WaterSalesAgreement>()
							  .FirstOrDefault(a => a.DeliveryPoint == null && !a.IsCancelled);

			if(wsa == null) {
				fixedPricesList = new List<WaterSalesAgreementFixedPrice>();
				return;
			}

			wsa.ReloadListFromDB(InfoProvider.UoW.Session, x => x.FixedPrices);

			fixedPricesList = wsa.FixedPrices;
		}

		public bool VisibleOnPanel => DeliveryPoint != null;

		public void OnCurrentObjectChanged(object changedObject)
		{
			if(changedObject is DeliveryPoint deliveryPoint)
				Refresh();
		}

		private IInfoProvider infoProvider;
		public IInfoProvider InfoProvider {
			get => infoProvider;
			set {
				infoProvider = value;
				if(infoProvider != null && infoProvider.UoW != null) {
					infoProvider.UoW.SessionScopeEntitySaved += UoW_SessionScopeEntitySaved;
				}
			}
		}

		void UoW_SessionScopeEntitySaved(object sender, QS.DomainModel.Config.EntityUpdatedEventArgs e)
		{
			foreach(var item in e.UpdatedSubjects) {
				if(item is WaterSalesAgreement)
					Refresh();
			}
		}


		public CounterpartyContract Contract => (InfoProvider as IContractInfoProvider)?.Contract;

		protected void OnYtreeviewFixedPricesRowActivated(object o, Gtk.RowActivatedArgs args)
		{
			var selectedPrice = ytreeviewFixedPrices.GetSelectedObject() as WaterSalesAgreementFixedPrice;
			var type = NHibernateProxyHelper.GuessClass(selectedPrice.AdditionalAgreement);
			var dialog = OrmMain.CreateObjectDialog(type, selectedPrice.AdditionalAgreement.Id);
			TDIMain.MainNotebook.OpenTab(
				DialogHelper.GenerateDialogHashName(type, selectedPrice.AdditionalAgreement.Id),
				() => dialog
			);
		}

		protected void OnButtonWaterAgreementClicked(object sender, EventArgs e)
		{
			if(WaterAgreements.Length > 0) {
				foreach(var wa in WaterAgreements) {
					if(wa.Contract.Id != Contract?.Id)
						continue;
					TDIMain.MainNotebook.OpenTab(
						DialogHelper.GenerateDialogHashName<WaterSalesAgreement>(wa.Id),
						() => new WaterAgreementDlg(EntityConstructorParam.ForOpenInChildUoW(wa.Id, InfoProvider.UoW))
					);
				}
			}
		}

		#endregion

		public override void Destroy()
		{
			if(infoProvider?.UoW != null)
				infoProvider.UoW.SessionScopeEntitySaved -= UoW_SessionScopeEntitySaved;

			QS.DomainModel.NotifyChange.NotifyConfiguration.Instance.UnsubscribeAll(this);
			base.Destroy();
		}
	}
}

