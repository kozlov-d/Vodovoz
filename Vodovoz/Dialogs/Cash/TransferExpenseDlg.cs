﻿using System;
using Gamma.Utilities;
using QS.Dialog.Gtk;
using QS.Dialog.GtkUI;
using QS.DomainModel.UoW;
using QS.Services;
using QSProjectsLib;
using Vodovoz.Domain.Cash;
using Vodovoz.EntityRepositories;

namespace Vodovoz.Dialogs.Cash
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class TransferExpenseDlg : EntityDialogBase<Expense>
	{
		public TransferExpenseDlg()
		{
			this.Build();
			throw new InvalidOperationException($"Для данного диалога невозможно создание новой сущности");
		}

		public TransferExpenseDlg(int id, IPermissionService permissionService)
		{
			this.Build();
			UoWGeneric = UnitOfWorkFactory.CreateForRoot<Expense>(id);
			
			var userPermission = permissionService.ValidateUserPermission(typeof(Expense), UserSingletonRepository.GetInstance().GetCurrentUser(UoW).Id);
			if(!userPermission.CanRead) {
				MessageDialogHelper.RunErrorDialog("Отсутствуют права на просмотр приходного ордера");
				FailInitialize = true;
				return;
			}
			
			if(Entity.TypeDocument != ExpenseInvoiceDocumentType.ExpenseTransferDocument) {
				throw new InvalidOperationException($"Диалог доступен только для документа типа {nameof(ExpenseInvoiceDocumentType.ExpenseTransferDocument)}");
			}
			ConfigureDlg();
		}
		public TransferExpenseDlg(Expense expense, IPermissionService permissionService) : this(expense.Id, permissionService) { }

		private void ConfigureDlg()
		{
			HasChanges = false;
			ylabelDate.Binding.AddFuncBinding(Entity, e => e.Date.ToShortDateString(), w => w.LabelProp).InitializeFromSource();
			ylabelCashier.Binding.AddFuncBinding(Entity, e => e.Casher.GetPersonNameWithInitials(), w => w.LabelProp).InitializeFromSource();
			ylabelTypeOperation.Binding.AddFuncBinding(Entity, e => e.TypeOperation.GetEnumTitle(), w => w.LabelProp).InitializeFromSource();
			ylabelExpenseCategory.Binding.AddFuncBinding(Entity, e => e.ExpenseCategory.Name, w => w.LabelProp).InitializeFromSource();
			ylabelCashSubdivions.Binding.AddFuncBinding(Entity, e => e.RelatedToSubdivision.Name, w => w.LabelProp).InitializeFromSource();
			ylabelTransferDocument.Binding.AddFuncBinding(Entity, e => e.CashTransferDocument.Title, w => w.LabelProp).InitializeFromSource();
			ylabelSum.Binding.AddFuncBinding(Entity, e => e.Money.ToShortCurrencyString(), w => w.LabelProp).InitializeFromSource();
			ylabelDescription.Binding.AddFuncBinding(Entity, e => e.Description, w => w.LabelProp).InitializeFromSource();
		}

		public override bool Save()
		{
			OnCloseTab(false);
			return true;
		}

		protected void OnButtonCloseClicked(object sender, EventArgs e)
		{
			OnCloseTab(false);
		}
	}
}
