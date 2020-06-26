﻿using System;
using System.Linq;
using QS.Commands;
using QS.Dialog.GtkUI;
using QS.DomainModel.UoW;
using QS.Project.Domain;
using QS.Project.Journal;
using QS.Project.Services;
using QS.Services;
using QS.Tdi;
using QS.ViewModels;
using Vodovoz.Dialogs.Email;
using Vodovoz.Domain.Client;
using Vodovoz.Domain.Goods;
using Vodovoz.Domain.Orders;
using Vodovoz.Domain.Orders.OrdersWithoutShipment;
using Vodovoz.EntityRepositories;
using Vodovoz.EntityRepositories.Employees;
using Vodovoz.FilterViewModels.Goods;
using Vodovoz.JournalViewModels;

namespace Vodovoz.ViewModels.Orders.OrdersWithoutShipment
{
	public class OrderWithoutShipmentForAdvancePaymentViewModel : EntityTabViewModelBase<OrderWithoutShipmentForAdvancePayment>, ITdiTabAddedNotifier
	{
		private object selectedItem;
		public object SelectedItem {
			get => selectedItem;
			set => SetField(ref selectedItem, value);
		}
		
		public SendDocumentByEmailViewModel SendDocViewModel { get; set; }
		
		public bool IsDocumentSent => Entity.IsBillWithoutShipmentSent;
		
		public Action<string> OpenCounterpatyJournal;
		public IEntityUoWBuilder EntityUoWBuilder { get; }

		//public readonly OrderSingletonRepository orderRepository;

		#region Commands

		public DelegateCommand AddForSaleCommand { get; private set; }

		public DelegateCommand DeleteItemCommand { get; private set; }

		#endregion Commands

		public OrderWithoutShipmentForAdvancePaymentViewModel(
			IEntityUoWBuilder uowBuilder,
			IUnitOfWorkFactory uowFactory,
			ICommonServices commonServices) : base(uowBuilder, uowFactory, commonServices)
		{
			TabName = "Счет без отгрузки на предоплату";
			EntityUoWBuilder = uowBuilder;
			
			SendDocViewModel = new SendDocumentByEmailViewModel(new EmailRepository(), EmployeeSingletonRepository.GetInstance(), UoW);
			
			if (uowBuilder.IsNewEntity)
				Entity.Author = EmployeeSingletonRepository.GetInstance().GetEmployeeForCurrentUser(UoW);
				
			CreateCommands();
		}

		private void CreateCommands()
		{
			CreateAddForSaleCommand();
			CreateDeleteItemCommand();
		}

		private void CreateAddForSaleCommand()
		{
			AddForSaleCommand = new DelegateCommand(
				() => {

					if(!CanAddNomenclaturesToOrder())
						return;

					var defaultCategory = NomenclatureCategory.water;
					if(CurrentUserSettings.Settings.DefaultSaleCategory.HasValue)
						defaultCategory = CurrentUserSettings.Settings.DefaultSaleCategory.Value;

					var nomenclatureFilter = new NomenclatureFilterViewModel();
					nomenclatureFilter.SetAndRefilterAtOnce(
						x => x.AvailableCategories = Nomenclature.GetCategoriesForSaleToOrder(),
						x => x.SelectCategory = defaultCategory,
						x => x.SelectSaleCategory = SaleCategory.forSale,
						x => x.RestrictArchive = false
					);

					NomenclaturesJournalViewModel journalViewModel = new NomenclaturesJournalViewModel(
						nomenclatureFilter,
						UnitOfWorkFactory,
						ServicesConfig.CommonServices
					) {
						SelectionMode = JournalSelectionMode.Single,
					};
					journalViewModel.AdditionalJournalRestriction = new NomenclaturesForOrderJournalRestriction(ServicesConfig.CommonServices);
					journalViewModel.TabName = "Номенклатура на продажу";
					journalViewModel.OnEntitySelectedResult += (s, ea) => {
						var selectedNode = ea.SelectedNodes.FirstOrDefault();
						if(selectedNode == null)
							return;
						TryAddNomenclature(UoWGeneric.Session.Get<Nomenclature>(selectedNode.Id));
					};
					TabParent.AddSlaveTab(this, journalViewModel);
				},
				() => true
			);
		}

		private void CreateDeleteItemCommand()
		{
			DeleteItemCommand = new DelegateCommand(
				() => {
					var item = SelectedItem as OrderWithoutShipmentForAdvancePaymentItem;
					Entity.RemoveItem(item);
				},
				() => SelectedItem != null
			);
		}

		public void OnTabAdded()
		{
			if(EntityUoWBuilder.IsNewEntity)
				OpenCounterpatyJournal?.Invoke(string.Empty);
		}

		bool CanAddNomenclaturesToOrder()
		{
			if(Entity.Client == null) {
				MessageDialogHelper.RunWarningDialog("Для добавления товара на продажу должен быть выбран клиент.");
				return false;
			}

			return true;
		}

		void TryAddNomenclature(Nomenclature nomenclature, int count = 0, decimal discount = 0, DiscountReason discountReason = null)
		{
			if(nomenclature.ProductGroup != null)
				if(nomenclature.ProductGroup.IsOnlineStore && !ServicesConfig.CommonServices.CurrentPermissionService
					.ValidatePresetPermission("can_add_online_store_nomenclatures_to_order")) {
					MessageDialogHelper.RunWarningDialog("У вас недостаточно прав для добавления на продажу номенклатуры интернет магазина");
					return;
				}

			Entity.AddNomenclature(nomenclature, count, discount, false, discountReason);
		}
		
		public void OnEntityViewModelEntryChanged(object sender, EventArgs e)
		{
			var email = Entity.GetEmailAddressForBill();

			if(email != null)
				SendDocViewModel.Update(Entity, email.Address);
			else 
			if(!string.IsNullOrEmpty(SendDocViewModel.EmailString))
				SendDocViewModel.EmailString = string.Empty;
		}
	}
}
