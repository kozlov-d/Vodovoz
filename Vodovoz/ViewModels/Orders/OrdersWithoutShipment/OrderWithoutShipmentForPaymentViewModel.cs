﻿using System;
using QS.DomainModel.UoW;
using QS.Project.Domain;
using QS.Services;
using QS.ViewModels;
using Vodovoz.Domain.Orders.OrdersWithoutShipment;
using Vodovoz.Domain.Orders;
using System.Data.Bindings.Collections.Generic;
using Gamma.Utilities;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Dialect.Function;
using NHibernate.Transform;
using QS.Commands;
using QS.Navigation;
using QS.Project.Journal;
using QS.Tdi;
using QSOrmProject;
using QSReport;
using Vodovoz.Dialogs.Email;
using Vodovoz.Domain.Client;
using Vodovoz.Domain.Goods;
using Vodovoz.EntityRepositories;
using Vodovoz.EntityRepositories.Employees;
using VodOrder = Vodovoz.Domain.Orders.Order;

namespace Vodovoz.ViewModels.Orders.OrdersWithoutShipment
{
	public class OrderWithoutShipmentForPaymentViewModel : EntityTabViewModelBase<OrderWithoutShipmentForPayment>, ITdiTabAddedNotifier
	{
		private DateTime? startDate = DateTime.Now.AddMonths(-1);
		public DateTime? StartDate {
			get => startDate;
			set => SetField(ref startDate, value);
		}

		private DateTime? endDate = DateTime.Now;
		public DateTime? EndDate {
			get => endDate;
			set => SetField(ref endDate, value);
		}
		
		public OrderWithoutShipmentForPaymentNode SelectedNode { get; set; }
		public SendDocumentByEmailViewModel SendDocViewModel { get; set; }
		public bool IsDocumentSent => Entity.IsBillWithoutShipmentSent;
		
		public GenericObservableList<OrderWithoutShipmentForPaymentNode> ObservableNodes { get; set; }
		
		public Action<string> OpenCounterpartyJournal;
		public IEntityUoWBuilder EntityUoWBuilder { get; }
		
		public OrderWithoutShipmentForPaymentViewModel(
			IEntityUoWBuilder uowBuilder,
			IUnitOfWorkFactory uowFactory,
			ICommonServices commonServices) : base(uowBuilder, uowFactory, commonServices)
		{
			bool canCreateBillsWithoutShipment = CommonServices.PermissionService.ValidateUserPresetPermission("can_create_bills_without_shipment", CurrentUser.Id);
			
			if (uowBuilder.IsNewEntity)
			{
				if (canCreateBillsWithoutShipment)
				{
					if (!AskQuestion("Вы действительно хотите создать счет без отгрузки на постоплату?"))
					{
						AbortOpening();
					}
					else
					{
						Entity.Author = EmployeeSingletonRepository.GetInstance().GetEmployeeForCurrentUser(UoW);
					}
				}
				else
				{
					AbortOpening("У Вас нет прав на выставление счетов без отгрузки.");
				}
			}
			
			TabName = "Счет без отгрузки на постоплату";
			
			EntityUoWBuilder = uowBuilder;
			SendDocViewModel = new SendDocumentByEmailViewModel(new EmailRepository(), EmployeeSingletonRepository.GetInstance(), commonServices.InteractiveService, UoW);
			
			ObservableNodes = new GenericObservableList<OrderWithoutShipmentForPaymentNode>();
		}

		#region Commands

		private DelegateCommand cancelCommand;
		public DelegateCommand CancelCommand => cancelCommand ?? (cancelCommand = new DelegateCommand(
			() =>Close(false, CloseSource.Cancel),
			() => true
		));
		
		private DelegateCommand openBillCommand;
		public DelegateCommand OpenBillCommand => openBillCommand ?? (openBillCommand = new DelegateCommand(
			() =>
			{
				string whatToPrint = "документа \"" + Entity.Type.GetEnumTitle() + "\"";
				
				if (UoWGeneric.HasChanges &&
				    CommonDialogs.SaveBeforePrint(typeof(OrderWithoutShipmentForPayment), whatToPrint))
				{
					if (Save(false))
						TabParent.AddTab(DocumentPrinter.GetPreviewTab(Entity), this, false);
				}
				
				if(!UoWGeneric.HasChanges && Entity.Id > 0)
					TabParent.AddTab(DocumentPrinter.GetPreviewTab(Entity), this, false);
			},
			() => true
		));
		
		#endregion

		public void UpdateNodes(object sender, EventArgs e)
		{
			ObservableNodes.Clear();
			
			if (Entity.Client == null)
				return;

			OrderWithoutShipmentForPaymentNode resultAlias = null;
			VodOrder orderAlias = null;
			OrderItem orderItemAlias = null;
			Nomenclature nomenclatureAlias = null;
			DeliveryPoint deliveryPointAlias = null;

			var cashlessOrdersQuery = UoW.Session.QueryOver(() => orderAlias)
					.Left.JoinAlias(() => orderAlias.OrderItems, () => orderItemAlias)
					.Left.JoinAlias(() => orderAlias.DeliveryPoint, () => deliveryPointAlias)
					.Where(x => x.OrderStatus == OrderStatus.Closed)
					.Where(x => x.PaymentType == PaymentType.cashless);

			if(Entity.Client != null)
				cashlessOrdersQuery.Where(x => x.Client == Entity.Client);

			if(StartDate.HasValue && EndDate.HasValue)
				cashlessOrdersQuery.Where(x => x.CreateDate >= StartDate && x.CreateDate <= EndDate);
			
			var bottleCountSubquery = QueryOver.Of(() => orderItemAlias)
				.Where(() => orderAlias.Id == orderItemAlias.Order.Id)
				.JoinAlias(() => orderItemAlias.Nomenclature, () => nomenclatureAlias)
				.Where(() => nomenclatureAlias.Category == NomenclatureCategory.water && nomenclatureAlias.TareVolume == TareVolume.Vol19L)
				.Select(Projections.Sum(() => orderItemAlias.Count));
			
			var totalSum = QueryOver.Of(() => orderItemAlias)
					.Where(x => x.Order.Id == orderAlias.Id)
					.Select(
						Projections.Sum(
							Projections.SqlFunction(new SQLFunctionTemplate(NHibernateUtil.Decimal, "(?1 * IFNULL(?2, ?3) - ?4)"),
							NHibernateUtil.Decimal, new IProjection[] {
							Projections.Property(() => orderItemAlias.Price),
							Projections.Property(() => orderItemAlias.ActualCount),
							Projections.Property(() => orderItemAlias.Count),
							Projections.Property(() => orderItemAlias.DiscountMoney)})
						)
					);

			var resultQuery = cashlessOrdersQuery
					.SelectList(list => list
					.Select(() => orderAlias.Id).WithAlias(() => resultAlias.OrderId)
				   	.Select(() => orderAlias.OrderStatus).WithAlias(() => resultAlias.OrderStatus)
				   	.Select(() => orderAlias.CreateDate).WithAlias(() => resultAlias.OrderDate)
				    .Select(() => deliveryPointAlias.CompiledAddress).WithAlias(() => resultAlias.DeliveryAddress)
					.SelectSubQuery(totalSum).WithAlias(() => resultAlias.OrderSum)
				    .SelectSubQuery(bottleCountSubquery).WithAlias(() => resultAlias.Bottles)
					)
				.OrderBy(x => x.CreateDate).Desc
				.TransformUsing(Transformers.AliasToBean<OrderWithoutShipmentForPaymentNode>())
				.List<OrderWithoutShipmentForPaymentNode>();

			foreach (var item in resultQuery)
			{
				ObservableNodes.Add(item);
			}
		}

		public void OnTabAdded()
		{
			if(EntityUoWBuilder.IsNewEntity)
				OpenCounterpartyJournal?.Invoke(string.Empty);
		}
		
		public void OnEntityViewModelEntryChanged(object sender, EventArgs e)
		{
			var email = Entity.GetEmailAddressForBill();

			if(email != null)
				SendDocViewModel.Update(Entity, email.Address);
			else
				SendDocViewModel.Update(Entity, string.Empty);
			
			UpdateNodes(this, EventArgs.Empty);
		}

		public void UpdateItems()
		{
			var order = UoW.GetById<VodOrder>(SelectedNode.OrderId);
			
			if (SelectedNode.IsSelected)
			{
				if(order != null)
					Entity.AddOrder(order);
			}
			else
			{
				if(order != null)
					Entity.RemoveItem(order);
			}
		}
	}

	public class OrderWithoutShipmentForPaymentNode : JournalEntityNodeBase<VodOrder>
	{
		public bool IsSelected { get; set; }
		public int OrderId { get; set; }
		public DateTime OrderDate { get; set; }
		public OrderStatus OrderStatus { get; set; }
		public decimal Bottles { get; set; }
		public decimal OrderSum { get; set; }
		public string DeliveryAddress { get; set; }
	}
}
