﻿using System;
using QSTDI;
using QSOrmProject;
using Vodovoz.Domain.Logistic;

namespace Vodovoz
{
	
	public partial class ReadyForReceptionView : TdiTabBase
	{
		private IUnitOfWork uow;

		ViewModel.ReadyForReceptionVM viewModel;

		public IUnitOfWork UoW {
			get {
				return uow;
			}
			set {
				if (uow == value)
					return;
				uow = value;
				viewModel = new ViewModel.ReadyForReceptionVM (value);
				readyforreceptionfilter1.UoW = value;
				viewModel.Filter = readyforreceptionfilter1;
				tableReadyForReception.RepresentationModel = viewModel;
				tableReadyForReception.RepresentationModel.UpdateNodes ();
			}
		}


		public ReadyForReceptionView ()
		{
			this.Build ();
			this.TabName = "Готовые к приему";
			UoW = UnitOfWorkFactory.CreateWithoutRoot ();
			tableReadyForReception.Selection.Changed += OnSelectionChanged;
		}

		void OnSelectionChanged (object sender, EventArgs e)
		{
			buttonOpen.Sensitive = tableReadyForReception.Selection.CountSelectedRows () > 0;
			buttonConfirmReception.Sensitive = tableReadyForReception.Selection.CountSelectedRows() > 0;
		}

		protected void OnButtonOpenClicked (object sender, EventArgs e)
		{
			var node = tableReadyForReception.GetSelectedNode () as ViewModel.ReadyForReceptionVMNode;
			var dlg = new ReadyForReceptionDlg (node.Id, viewModel.Filter.RestrictWarehouse);
			TabParent.AddTab (dlg, this);
		}

		protected void OnTableReadyForReceptionRowActivated (object o, Gtk.RowActivatedArgs args)
		{
			buttonOpen.Click ();
		}

		protected void OnButtonConfirmReceptionClicked (object sender, EventArgs e)
		{
			var node = tableReadyForReception.GetSelectedNode () as ViewModel.ReadyForReceptionVMNode;
			var routeList = UoW.GetById<RouteList>(node.Id);
			routeList.ConfirmReception();
			UoW.Save(routeList);
			UoW.Commit();
		}
	}
}

