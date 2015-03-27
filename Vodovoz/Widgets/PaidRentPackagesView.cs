﻿using System;
using QSTDI;
using QSOrmProject;
using System.Data.Bindings.Collections.Generic;
using NHibernate;
using System.Collections.Generic;

namespace Vodovoz
{
	[System.ComponentModel.ToolboxItem (true)]
	public partial class PaidRentPackagesView : Gtk.Bin
	{
		private IPaidRentEquipmentOwner equipmentOwner;
		private GenericObservableList<PaidRentEquipment> Equipments;
		private ISession session;
		Decimal TotalPrice = 0;

		public ISession Session {
			get {
				return session;
			}
			set {
				session = value;
			}
		}

		public IPaidRentEquipmentOwner EquipmentOwner {
			get {
				return equipmentOwner;
			}
			set {
				equipmentOwner = value;
				if (equipmentOwner.Equipment == null)
					equipmentOwner.Equipment = new List<PaidRentEquipment> ();
				Equipments = new GenericObservableList<PaidRentEquipment> (EquipmentOwner.Equipment);
				foreach (PaidRentEquipment eq in Equipments)
					eq.PropertyChanged += EquimentPropertyChanged;
				UpdateTotalLabels ();
				treeRentPackages.ItemsDataSource = Equipments;
			}
		}

		void EquimentPropertyChanged (object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			UpdateTotalLabels ();
		}

		OrmParentReference parentReference;

		public OrmParentReference ParentReference {
			set {
				parentReference = value;
				if (parentReference != null) {
					Session = parentReference.Session;
					if (!(parentReference.ParentObject is IPaidRentEquipmentOwner)) {
						throw new ArgumentException (String.Format ("Родительский объект в parentReference " +
						"должен реализовывать интерфейс {0}", typeof(IAdditionalAgreementOwner)));
					}
					EquipmentOwner = (IPaidRentEquipmentOwner)parentReference.ParentObject;
				}
			}
			get {
				return parentReference;
			}
		}

		void UpdateTotalLabels ()
		{
			TotalPrice = 0;
			if (Equipments != null)
				foreach (PaidRentEquipment eq in Equipments)
					TotalPrice += eq.Price;
			labelTotalPrice.Text = String.Format ("{0} руб.", TotalPrice);
		}

		public PaidRentPackagesView ()
		{
			this.Build ();
			treeRentPackages.Selection.Changed += OnSelectionChanged;
		}

		void OnSelectionChanged (object sender, EventArgs e)
		{
			bool selected = treeRentPackages.Selection.CountSelectedRows () > 0;
			buttonEdit.Sensitive = buttonDelete.Sensitive = selected;
		}

		protected void OnButtonAddClicked (object sender, EventArgs e)
		{
			ITdiTab mytab = TdiHelper.FindMyTab (this);
			if (mytab == null)
				return;
			PaidRentEquipment equipment = new PaidRentEquipment ();
			equipment.IsNew = true;
			Equipments.Add (equipment);
			equipment.PropertyChanged += EquimentPropertyChanged;
			ITdiDialog dlg = new PaidRentEquipmentDlg (ParentReference, equipment);
			mytab.TabParent.AddSlaveTab (mytab, dlg);
		}

		protected void OnButtonEditClicked (object sender, EventArgs e)
		{
			ITdiTab mytab = TdiHelper.FindMyTab (this);
			if (mytab == null)
				return;

			ITdiDialog dlg = OrmMain.CreateObjectDialog (ParentReference, treeRentPackages.GetSelectedObjects () [0]);
			mytab.TabParent.AddSlaveTab (mytab, dlg);
		}

		protected void OnButtonDeleteClicked (object sender, EventArgs e)
		{
			ITdiTab mytab = TdiHelper.FindMyTab (this);
			if (mytab == null)
				return;

			Equipments.Remove (treeRentPackages.GetSelectedObjects () [0] as PaidRentEquipment);
		}

		protected void OnTreeRentPackagesRowActivated (object o, Gtk.RowActivatedArgs args)
		{
			buttonEdit.Click ();
		}
	}
}

