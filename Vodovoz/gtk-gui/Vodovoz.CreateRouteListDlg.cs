
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz
{
	public partial class CreateRouteListDlg
	{
		private global::Gtk.VBox vbox1;
		
		private global::Gtk.HBox hbox1;
		
		private global::Gtk.Button buttonSave;
		
		private global::Gtk.Button buttonCancel;
		
		private global::Gtk.DataBindings.DataTable dataRouteList;
		
		private global::Gtk.DataBindings.DataEntryReference dataentryForwarder;
		
		private global::QSOrmProject.DataDatePicker datepickerDate;
		
		private global::Gtk.DataBindings.DataEntry entryNumber;
		
		private global::Gtk.DataBindings.DataEnumComboBox enumStatus;
		
		private global::Gtk.HSeparator hseparator1;
		
		private global::Gtk.Label label1;
		
		private global::Gtk.Label label2;
		
		private global::Gtk.Label label3;
		
		private global::Gtk.Label label4;
		
		private global::Gtk.Label label5;
		
		private global::Gtk.Label label6;
		
		private global::Gtk.Label label7;
		
		private global::Gtk.Label label8;
		
		private global::Gtk.Label label9;
		
		private global::Gtk.DataBindings.DataEntryReference referenceCar;
		
		private global::Gtk.DataBindings.DataEntryReference referenceDriver;
		
		private global::Gtk.DataBindings.DataSpinButton spinActualDistance;
		
		private global::Gtk.DataBindings.DataSpinButton spinPlannedDistance;
		
		private global::Vodovoz.CreateRouteListItemsView createroutelistitemsview1;
		
		private global::Gtk.HBox hbox6;
		
		private global::Gtk.Button buttonAccept;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Vodovoz.CreateRouteListDlg
			global::Stetic.BinContainer.Attach (this);
			this.Name = "Vodovoz.CreateRouteListDlg";
			// Container child Vodovoz.CreateRouteListDlg.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			this.vbox1.BorderWidth = ((uint)(6));
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.buttonSave = new global::Gtk.Button ();
			this.buttonSave.CanFocus = true;
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.UseUnderline = true;
			this.buttonSave.Label = global::Mono.Unix.Catalog.GetString ("Сохранить");
			global::Gtk.Image w1 = new global::Gtk.Image ();
			w1.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-save", global::Gtk.IconSize.Menu);
			this.buttonSave.Image = w1;
			this.hbox1.Add (this.buttonSave);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.buttonSave]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = global::Mono.Unix.Catalog.GetString ("Отмена");
			global::Gtk.Image w3 = new global::Gtk.Image ();
			w3.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-revert-to-saved", global::Gtk.IconSize.Menu);
			this.buttonCancel.Image = w3;
			this.hbox1.Add (this.buttonCancel);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.buttonCancel]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			this.vbox1.Add (this.hbox1);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.dataRouteList = new global::Gtk.DataBindings.DataTable (((uint)(7)), ((uint)(4)), false);
			this.dataRouteList.Name = "dataRouteList";
			this.dataRouteList.RowSpacing = ((uint)(6));
			this.dataRouteList.ColumnSpacing = ((uint)(6));
			this.dataRouteList.InheritedDataSource = false;
			this.dataRouteList.InheritedBoundaryDataSource = false;
			this.dataRouteList.InheritedDataSource = false;
			this.dataRouteList.InheritedBoundaryDataSource = false;
			// Container child dataRouteList.Gtk.Table+TableChild
			this.dataentryForwarder = new global::Gtk.DataBindings.DataEntryReference ();
			this.dataentryForwarder.Events = ((global::Gdk.EventMask)(256));
			this.dataentryForwarder.Name = "dataentryForwarder";
			this.dataentryForwarder.InheritedDataSource = true;
			this.dataentryForwarder.InheritedBoundaryDataSource = false;
			this.dataentryForwarder.CursorPointsEveryType = false;
			this.dataRouteList.Add (this.dataentryForwarder);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.dataRouteList [this.dataentryForwarder]));
			w6.TopAttach = ((uint)(4));
			w6.BottomAttach = ((uint)(5));
			w6.LeftAttach = ((uint)(3));
			w6.RightAttach = ((uint)(4));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child dataRouteList.Gtk.Table+TableChild
			this.datepickerDate = new global::QSOrmProject.DataDatePicker ();
			this.datepickerDate.Events = ((global::Gdk.EventMask)(256));
			this.datepickerDate.Name = "datepickerDate";
			this.datepickerDate.Date = new global::System.DateTime (0);
			this.datepickerDate.IsEditable = true;
			this.datepickerDate.AutoSeparation = false;
			this.datepickerDate.InheritedDataSource = true;
			this.datepickerDate.Mappings = "Date";
			this.datepickerDate.InheritedBoundaryDataSource = false;
			this.dataRouteList.Add (this.datepickerDate);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.dataRouteList [this.datepickerDate]));
			w7.TopAttach = ((uint)(1));
			w7.BottomAttach = ((uint)(2));
			w7.LeftAttach = ((uint)(3));
			w7.RightAttach = ((uint)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child dataRouteList.Gtk.Table+TableChild
			this.entryNumber = new global::Gtk.DataBindings.DataEntry ();
			this.entryNumber.CanFocus = true;
			this.entryNumber.Name = "entryNumber";
			this.entryNumber.IsEditable = true;
			this.entryNumber.InvisibleChar = '●';
			this.entryNumber.InheritedDataSource = true;
			this.entryNumber.Mappings = "Number";
			this.entryNumber.InheritedBoundaryDataSource = false;
			this.entryNumber.InheritedDataSource = true;
			this.entryNumber.Mappings = "Number";
			this.entryNumber.InheritedBoundaryDataSource = false;
			this.dataRouteList.Add (this.entryNumber);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.dataRouteList [this.entryNumber]));
			w8.TopAttach = ((uint)(1));
			w8.BottomAttach = ((uint)(2));
			w8.LeftAttach = ((uint)(1));
			w8.RightAttach = ((uint)(2));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child dataRouteList.Gtk.Table+TableChild
			this.enumStatus = new global::Gtk.DataBindings.DataEnumComboBox ();
			this.enumStatus.Name = "enumStatus";
			this.enumStatus.InheritedBoundaryDataSource = false;
			this.enumStatus.InheritedDataSource = true;
			this.enumStatus.Mappings = "Status";
			this.enumStatus.InheritedBoundaryDataSource = false;
			this.enumStatus.InheritedDataSource = true;
			this.enumStatus.Mappings = "Status";
			this.dataRouteList.Add (this.enumStatus);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.dataRouteList [this.enumStatus]));
			w9.LeftAttach = ((uint)(1));
			w9.RightAttach = ((uint)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child dataRouteList.Gtk.Table+TableChild
			this.hseparator1 = new global::Gtk.HSeparator ();
			this.hseparator1.Name = "hseparator1";
			this.dataRouteList.Add (this.hseparator1);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.dataRouteList [this.hseparator1]));
			w10.TopAttach = ((uint)(3));
			w10.BottomAttach = ((uint)(4));
			w10.RightAttach = ((uint)(4));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child dataRouteList.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 1F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Номер:");
			this.dataRouteList.Add (this.label1);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.dataRouteList [this.label1]));
			w11.TopAttach = ((uint)(1));
			w11.BottomAttach = ((uint)(2));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child dataRouteList.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.Xalign = 1F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Дата:");
			this.dataRouteList.Add (this.label2);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.dataRouteList [this.label2]));
			w12.TopAttach = ((uint)(1));
			w12.BottomAttach = ((uint)(2));
			w12.LeftAttach = ((uint)(2));
			w12.RightAttach = ((uint)(3));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child dataRouteList.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.Xalign = 1F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Водитель:");
			this.dataRouteList.Add (this.label3);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.dataRouteList [this.label3]));
			w13.TopAttach = ((uint)(2));
			w13.BottomAttach = ((uint)(3));
			w13.LeftAttach = ((uint)(2));
			w13.RightAttach = ((uint)(3));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child dataRouteList.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.Xalign = 1F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Машина:");
			this.dataRouteList.Add (this.label4);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.dataRouteList [this.label4]));
			w14.TopAttach = ((uint)(2));
			w14.BottomAttach = ((uint)(3));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child dataRouteList.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.Xalign = 1F;
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Состояние:");
			this.dataRouteList.Add (this.label5);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.dataRouteList [this.label5]));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child dataRouteList.Gtk.Table+TableChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.Xalign = 1F;
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("Планируемое:");
			this.dataRouteList.Add (this.label6);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.dataRouteList [this.label6]));
			w16.TopAttach = ((uint)(6));
			w16.BottomAttach = ((uint)(7));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child dataRouteList.Gtk.Table+TableChild
			this.label7 = new global::Gtk.Label ();
			this.label7.Name = "label7";
			this.label7.Xalign = 1F;
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString ("Фактическое:");
			this.dataRouteList.Add (this.label7);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.dataRouteList [this.label7]));
			w17.TopAttach = ((uint)(6));
			w17.BottomAttach = ((uint)(7));
			w17.LeftAttach = ((uint)(2));
			w17.RightAttach = ((uint)(3));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child dataRouteList.Gtk.Table+TableChild
			this.label8 = new global::Gtk.Label ();
			this.label8.Name = "label8";
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString ("Расстояние");
			this.dataRouteList.Add (this.label8);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.dataRouteList [this.label8]));
			w18.TopAttach = ((uint)(5));
			w18.BottomAttach = ((uint)(6));
			w18.RightAttach = ((uint)(4));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child dataRouteList.Gtk.Table+TableChild
			this.label9 = new global::Gtk.Label ();
			this.label9.Name = "label9";
			this.label9.Xalign = 1F;
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString ("Экспедитор:");
			this.dataRouteList.Add (this.label9);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.dataRouteList [this.label9]));
			w19.TopAttach = ((uint)(4));
			w19.BottomAttach = ((uint)(5));
			w19.LeftAttach = ((uint)(2));
			w19.RightAttach = ((uint)(3));
			w19.XOptions = ((global::Gtk.AttachOptions)(4));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child dataRouteList.Gtk.Table+TableChild
			this.referenceCar = new global::Gtk.DataBindings.DataEntryReference ();
			this.referenceCar.Events = ((global::Gdk.EventMask)(256));
			this.referenceCar.Name = "referenceCar";
			this.referenceCar.DisplayFields = new string[] {
				"Model",
				"RegistrationNumber"
			};
			this.referenceCar.DisplayFormatString = "{0} {1}";
			this.referenceCar.InheritedDataSource = true;
			this.referenceCar.Mappings = "Car";
			this.referenceCar.InheritedBoundaryDataSource = false;
			this.referenceCar.CursorPointsEveryType = false;
			this.dataRouteList.Add (this.referenceCar);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.dataRouteList [this.referenceCar]));
			w20.TopAttach = ((uint)(2));
			w20.BottomAttach = ((uint)(3));
			w20.LeftAttach = ((uint)(1));
			w20.RightAttach = ((uint)(2));
			w20.XOptions = ((global::Gtk.AttachOptions)(4));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child dataRouteList.Gtk.Table+TableChild
			this.referenceDriver = new global::Gtk.DataBindings.DataEntryReference ();
			this.referenceDriver.Events = ((global::Gdk.EventMask)(256));
			this.referenceDriver.Name = "referenceDriver";
			this.referenceDriver.DisplayFields = new string[] {
				"Name",
				"LastName",
				"Patronymic"
			};
			this.referenceDriver.DisplayFormatString = "{0} {1} {2}";
			this.referenceDriver.InheritedDataSource = true;
			this.referenceDriver.Mappings = "Driver";
			this.referenceDriver.InheritedBoundaryDataSource = false;
			this.referenceDriver.CursorPointsEveryType = false;
			this.dataRouteList.Add (this.referenceDriver);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.dataRouteList [this.referenceDriver]));
			w21.TopAttach = ((uint)(2));
			w21.BottomAttach = ((uint)(3));
			w21.LeftAttach = ((uint)(3));
			w21.RightAttach = ((uint)(4));
			w21.XOptions = ((global::Gtk.AttachOptions)(4));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child dataRouteList.Gtk.Table+TableChild
			this.spinActualDistance = new global::Gtk.DataBindings.DataSpinButton (0, 100, 1);
			this.spinActualDistance.CanFocus = true;
			this.spinActualDistance.Name = "spinActualDistance";
			this.spinActualDistance.Adjustment.PageIncrement = 10;
			this.spinActualDistance.ClimbRate = 1;
			this.spinActualDistance.Digits = ((uint)(3));
			this.spinActualDistance.Numeric = true;
			this.spinActualDistance.InheritedDataSource = true;
			this.spinActualDistance.Mappings = "ActualDistance";
			this.spinActualDistance.InheritedBoundaryDataSource = false;
			this.spinActualDistance.InheritedDataSource = true;
			this.spinActualDistance.Mappings = "ActualDistance";
			this.spinActualDistance.InheritedBoundaryDataSource = false;
			this.dataRouteList.Add (this.spinActualDistance);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.dataRouteList [this.spinActualDistance]));
			w22.TopAttach = ((uint)(6));
			w22.BottomAttach = ((uint)(7));
			w22.LeftAttach = ((uint)(3));
			w22.RightAttach = ((uint)(4));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child dataRouteList.Gtk.Table+TableChild
			this.spinPlannedDistance = new global::Gtk.DataBindings.DataSpinButton (0, 100, 1);
			this.spinPlannedDistance.CanFocus = true;
			this.spinPlannedDistance.Name = "spinPlannedDistance";
			this.spinPlannedDistance.Adjustment.PageIncrement = 10;
			this.spinPlannedDistance.ClimbRate = 1;
			this.spinPlannedDistance.Digits = ((uint)(3));
			this.spinPlannedDistance.Numeric = true;
			this.spinPlannedDistance.InheritedDataSource = true;
			this.spinPlannedDistance.Mappings = "PlannedDistance";
			this.spinPlannedDistance.InheritedBoundaryDataSource = false;
			this.spinPlannedDistance.InheritedDataSource = true;
			this.spinPlannedDistance.Mappings = "PlannedDistance";
			this.spinPlannedDistance.InheritedBoundaryDataSource = false;
			this.dataRouteList.Add (this.spinPlannedDistance);
			global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.dataRouteList [this.spinPlannedDistance]));
			w23.TopAttach = ((uint)(6));
			w23.BottomAttach = ((uint)(7));
			w23.LeftAttach = ((uint)(1));
			w23.RightAttach = ((uint)(2));
			w23.XOptions = ((global::Gtk.AttachOptions)(4));
			w23.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox1.Add (this.dataRouteList);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.dataRouteList]));
			w24.Position = 1;
			w24.Expand = false;
			w24.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.createroutelistitemsview1 = new global::Vodovoz.CreateRouteListItemsView ();
			this.createroutelistitemsview1.Events = ((global::Gdk.EventMask)(256));
			this.createroutelistitemsview1.Name = "createroutelistitemsview1";
			this.vbox1.Add (this.createroutelistitemsview1);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.createroutelistitemsview1]));
			w25.Position = 2;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox6 = new global::Gtk.HBox ();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.buttonAccept = new global::Gtk.Button ();
			this.buttonAccept.CanFocus = true;
			this.buttonAccept.Name = "buttonAccept";
			this.buttonAccept.UseUnderline = true;
			this.buttonAccept.Label = global::Mono.Unix.Catalog.GetString ("Подтвердить");
			global::Gtk.Image w26 = new global::Gtk.Image ();
			w26.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-apply", global::Gtk.IconSize.Menu);
			this.buttonAccept.Image = w26;
			this.hbox6.Add (this.buttonAccept);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.buttonAccept]));
			w27.Position = 0;
			w27.Fill = false;
			this.vbox1.Add (this.hbox6);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox6]));
			w28.Position = 3;
			w28.Expand = false;
			w28.Fill = false;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
			this.buttonSave.Clicked += new global::System.EventHandler (this.OnButtonSaveClicked);
			this.buttonCancel.Clicked += new global::System.EventHandler (this.OnButtonCancelClicked);
			this.buttonAccept.Clicked += new global::System.EventHandler (this.OnButtonAcceptClicked);
		}
	}
}
