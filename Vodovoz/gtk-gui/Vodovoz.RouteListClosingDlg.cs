
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz
{
	public partial class RouteListClosingDlg
	{
		private global::Gtk.VBox vbox1;
		
		private global::Gtk.HBox hbox8;
		
		private global::Gtk.Button buttonSave;
		
		private global::Gtk.Button buttonCancel;
		
		private global::Gtk.Expander expander1;
		
		private global::Gtk.Table table1;
		
		private global::Gamma.Widgets.yDatePicker datePickerDate;
		
		private global::Gtk.Label label1;
		
		private global::Gtk.Label label10;
		
		private global::Gtk.Label label2;
		
		private global::Gtk.Label label3;
		
		private global::Gtk.Label label4;
		
		private global::Gtk.Label label5;
		
		private global::Gtk.Label label6;
		
		private global::Gtk.Label label9;
		
		private global::Gamma.Widgets.yEntryReference referenceCar;
		
		private global::Gamma.Widgets.yEntryReference referenceDriver;
		
		private global::Gamma.Widgets.yEntryReference referenceForwarder;
		
		private global::Gamma.Widgets.yEntryReference referenceLogistican;
		
		private global::Gamma.Widgets.ySpecComboBox speccomboShift;
		
		private global::Gamma.GtkWidgets.ySpinButton yspinActualDistance;
		
		private global::Gamma.GtkWidgets.ySpinButton yspinPlannedDistance;
		
		private global::Gtk.Label GtkLabel14;
		
		private global::Gtk.HBox hbox6;
		
		private global::Vodovoz.RouteListClosingItemsView routeListAddressesView;
		
		private global::Gtk.VBox vbox3;
		
		private global::Vodovoz.RouteListDiscrepancyView routelistdiscrepancyview;
		
		private global::Gtk.HBox hbox11;
		
		private global::Gtk.Label labelEmptyBottles1;
		
		private global::Gtk.Label labelBottleDifference;
		
		private global::Gtk.HBox hbox10;
		
		private global::Gtk.Label labelFullBottles;
		
		private global::Gtk.VSeparator vseparator9;
		
		private global::Gtk.Label labelAddressCount;
		
		private global::Gtk.VSeparator vseparator8;
		
		private global::Gtk.Label labelPhone;
		
		private global::Gtk.VSeparator vseparator5;
		
		private global::Gtk.Label labelDeposits;
		
		private global::Gtk.VSeparator vseparator4;
		
		private global::Gtk.Label labelCash;
		
		private global::Gtk.Label labelWage1;
		
		private global::Gtk.Label labelSum1;
		
		private global::Gtk.HBox hbox9;
		
		private global::Gtk.Label labelTotalCollected;
		
		private global::Gtk.VSeparator vseparator7;
		
		private global::Gtk.Label labelTotal;
		
		private global::Gtk.Button buttonAccept;
		
		private global::Gtk.Button buttonBackToUnloading;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Vodovoz.RouteListClosingDlg
			global::Stetic.BinContainer.Attach (this);
			this.Name = "Vodovoz.RouteListClosingDlg";
			// Container child Vodovoz.RouteListClosingDlg.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			this.vbox1.BorderWidth = ((uint)(6));
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox8 = new global::Gtk.HBox ();
			this.hbox8.Name = "hbox8";
			this.hbox8.Spacing = 6;
			// Container child hbox8.Gtk.Box+BoxChild
			this.buttonSave = new global::Gtk.Button ();
			this.buttonSave.CanFocus = true;
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.UseUnderline = true;
			this.buttonSave.Label = global::Mono.Unix.Catalog.GetString ("Сохранить");
			global::Gtk.Image w1 = new global::Gtk.Image ();
			w1.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-save", global::Gtk.IconSize.Menu);
			this.buttonSave.Image = w1;
			this.hbox8.Add (this.buttonSave);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.buttonSave]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox8.Gtk.Box+BoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = global::Mono.Unix.Catalog.GetString ("Отменить");
			global::Gtk.Image w3 = new global::Gtk.Image ();
			w3.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-revert-to-saved", global::Gtk.IconSize.Menu);
			this.buttonCancel.Image = w3;
			this.hbox8.Add (this.buttonCancel);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.buttonCancel]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			this.vbox1.Add (this.hbox8);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox8]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.expander1 = new global::Gtk.Expander (null);
			this.expander1.CanFocus = true;
			this.expander1.Name = "expander1";
			this.expander1.Expanded = true;
			// Container child expander1.Gtk.Container+ContainerChild
			this.table1 = new global::Gtk.Table (((uint)(4)), ((uint)(4)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.datePickerDate = new global::Gamma.Widgets.yDatePicker ();
			this.datePickerDate.Events = ((global::Gdk.EventMask)(256));
			this.datePickerDate.Name = "datePickerDate";
			this.datePickerDate.Date = new global::System.DateTime (0);
			this.datePickerDate.IsEditable = false;
			this.datePickerDate.AutoSeparation = false;
			this.table1.Add (this.datePickerDate);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1 [this.datePickerDate]));
			w6.LeftAttach = ((uint)(1));
			w6.RightAttach = ((uint)(2));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 1F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Смена:");
			this.table1.Add (this.label1);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1 [this.label1]));
			w7.TopAttach = ((uint)(1));
			w7.BottomAttach = ((uint)(2));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label10 = new global::Gtk.Label ();
			this.label10.Name = "label10";
			this.label10.Xalign = 1F;
			this.label10.LabelProp = global::Mono.Unix.Catalog.GetString ("Логист:");
			this.table1.Add (this.label10);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1 [this.label10]));
			w8.LeftAttach = ((uint)(2));
			w8.RightAttach = ((uint)(3));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.Xalign = 1F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Дата:");
			this.table1.Add (this.label2);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1 [this.label2]));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.Xalign = 1F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Водитель:");
			this.table1.Add (this.label3);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1 [this.label3]));
			w10.TopAttach = ((uint)(2));
			w10.BottomAttach = ((uint)(3));
			w10.LeftAttach = ((uint)(2));
			w10.RightAttach = ((uint)(3));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.Xalign = 1F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Машина:");
			this.table1.Add (this.label4);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1 [this.label4]));
			w11.TopAttach = ((uint)(1));
			w11.BottomAttach = ((uint)(2));
			w11.LeftAttach = ((uint)(2));
			w11.RightAttach = ((uint)(3));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Фактическое расстояние:");
			this.table1.Add (this.label5);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table1 [this.label5]));
			w12.TopAttach = ((uint)(3));
			w12.BottomAttach = ((uint)(4));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("Планируемое расстояние:");
			this.table1.Add (this.label6);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table1 [this.label6]));
			w13.TopAttach = ((uint)(2));
			w13.BottomAttach = ((uint)(3));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label9 = new global::Gtk.Label ();
			this.label9.Name = "label9";
			this.label9.Xalign = 1F;
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString ("Экспедитор:");
			this.table1.Add (this.label9);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table1 [this.label9]));
			w14.TopAttach = ((uint)(3));
			w14.BottomAttach = ((uint)(4));
			w14.LeftAttach = ((uint)(2));
			w14.RightAttach = ((uint)(3));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.referenceCar = new global::Gamma.Widgets.yEntryReference ();
			this.referenceCar.Events = ((global::Gdk.EventMask)(256));
			this.referenceCar.Name = "referenceCar";
			this.table1.Add (this.referenceCar);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table1 [this.referenceCar]));
			w15.TopAttach = ((uint)(1));
			w15.BottomAttach = ((uint)(2));
			w15.LeftAttach = ((uint)(3));
			w15.RightAttach = ((uint)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.referenceDriver = new global::Gamma.Widgets.yEntryReference ();
			this.referenceDriver.Events = ((global::Gdk.EventMask)(256));
			this.referenceDriver.Name = "referenceDriver";
			this.table1.Add (this.referenceDriver);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table1 [this.referenceDriver]));
			w16.TopAttach = ((uint)(2));
			w16.BottomAttach = ((uint)(3));
			w16.LeftAttach = ((uint)(3));
			w16.RightAttach = ((uint)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.referenceForwarder = new global::Gamma.Widgets.yEntryReference ();
			this.referenceForwarder.Events = ((global::Gdk.EventMask)(256));
			this.referenceForwarder.Name = "referenceForwarder";
			this.table1.Add (this.referenceForwarder);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table1 [this.referenceForwarder]));
			w17.TopAttach = ((uint)(3));
			w17.BottomAttach = ((uint)(4));
			w17.LeftAttach = ((uint)(3));
			w17.RightAttach = ((uint)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.referenceLogistican = new global::Gamma.Widgets.yEntryReference ();
			this.referenceLogistican.Events = ((global::Gdk.EventMask)(256));
			this.referenceLogistican.Name = "referenceLogistican";
			this.table1.Add (this.referenceLogistican);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table1 [this.referenceLogistican]));
			w18.LeftAttach = ((uint)(3));
			w18.RightAttach = ((uint)(4));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.speccomboShift = new global::Gamma.Widgets.ySpecComboBox ();
			this.speccomboShift.Name = "speccomboShift";
			this.speccomboShift.AddIfNotExist = false;
			this.speccomboShift.DefaultFirst = false;
			this.speccomboShift.ShowSpecialStateAll = false;
			this.speccomboShift.ShowSpecialStateNot = false;
			this.table1.Add (this.speccomboShift);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.table1 [this.speccomboShift]));
			w19.TopAttach = ((uint)(1));
			w19.BottomAttach = ((uint)(2));
			w19.LeftAttach = ((uint)(1));
			w19.RightAttach = ((uint)(2));
			w19.XOptions = ((global::Gtk.AttachOptions)(4));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.yspinActualDistance = new global::Gamma.GtkWidgets.ySpinButton (0, 10000, 1);
			this.yspinActualDistance.CanFocus = true;
			this.yspinActualDistance.Name = "yspinActualDistance";
			this.yspinActualDistance.Adjustment.PageIncrement = 10;
			this.yspinActualDistance.ClimbRate = 1;
			this.yspinActualDistance.Numeric = true;
			this.yspinActualDistance.ValueAsDecimal = 0m;
			this.yspinActualDistance.ValueAsInt = 0;
			this.table1.Add (this.yspinActualDistance);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table1 [this.yspinActualDistance]));
			w20.TopAttach = ((uint)(3));
			w20.BottomAttach = ((uint)(4));
			w20.LeftAttach = ((uint)(1));
			w20.RightAttach = ((uint)(2));
			w20.XOptions = ((global::Gtk.AttachOptions)(4));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.yspinPlannedDistance = new global::Gamma.GtkWidgets.ySpinButton (0, 10000, 1);
			this.yspinPlannedDistance.CanFocus = true;
			this.yspinPlannedDistance.Name = "yspinPlannedDistance";
			this.yspinPlannedDistance.Adjustment.PageIncrement = 10;
			this.yspinPlannedDistance.ClimbRate = 1;
			this.yspinPlannedDistance.Numeric = true;
			this.yspinPlannedDistance.ValueAsDecimal = 0m;
			this.yspinPlannedDistance.ValueAsInt = 0;
			this.table1.Add (this.yspinPlannedDistance);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.table1 [this.yspinPlannedDistance]));
			w21.TopAttach = ((uint)(2));
			w21.BottomAttach = ((uint)(3));
			w21.LeftAttach = ((uint)(1));
			w21.RightAttach = ((uint)(2));
			w21.XOptions = ((global::Gtk.AttachOptions)(4));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			this.expander1.Add (this.table1);
			this.GtkLabel14 = new global::Gtk.Label ();
			this.GtkLabel14.Name = "GtkLabel14";
			this.GtkLabel14.LabelProp = global::Mono.Unix.Catalog.GetString ("Информация о маршрутном листе");
			this.GtkLabel14.UseUnderline = true;
			this.expander1.LabelWidget = this.GtkLabel14;
			this.vbox1.Add (this.expander1);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.expander1]));
			w23.Position = 1;
			w23.Expand = false;
			w23.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox6 = new global::Gtk.HBox ();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.routeListAddressesView = new global::Vodovoz.RouteListClosingItemsView ();
			this.routeListAddressesView.Events = ((global::Gdk.EventMask)(256));
			this.routeListAddressesView.Name = "routeListAddressesView";
			this.hbox6.Add (this.routeListAddressesView);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.routeListAddressesView]));
			w24.Position = 0;
			// Container child hbox6.Gtk.Box+BoxChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.routelistdiscrepancyview = new global::Vodovoz.RouteListDiscrepancyView ();
			this.routelistdiscrepancyview.Events = ((global::Gdk.EventMask)(256));
			this.routelistdiscrepancyview.Name = "routelistdiscrepancyview";
			this.vbox3.Add (this.routelistdiscrepancyview);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.routelistdiscrepancyview]));
			w25.Position = 0;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox11 = new global::Gtk.HBox ();
			this.hbox11.Name = "hbox11";
			this.hbox11.Spacing = 6;
			// Container child hbox11.Gtk.Box+BoxChild
			this.labelEmptyBottles1 = new global::Gtk.Label ();
			this.labelEmptyBottles1.Name = "labelEmptyBottles1";
			this.labelEmptyBottles1.LabelProp = global::Mono.Unix.Catalog.GetString ("Тара");
			this.labelEmptyBottles1.UseMarkup = true;
			this.hbox11.Add (this.labelEmptyBottles1);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox11 [this.labelEmptyBottles1]));
			w26.Position = 0;
			w26.Expand = false;
			w26.Fill = false;
			// Container child hbox11.Gtk.Box+BoxChild
			this.labelBottleDifference = new global::Gtk.Label ();
			this.labelBottleDifference.Name = "labelBottleDifference";
			this.labelBottleDifference.LabelProp = global::Mono.Unix.Catalog.GetString ("(разница)");
			this.labelBottleDifference.UseMarkup = true;
			this.hbox11.Add (this.labelBottleDifference);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.hbox11 [this.labelBottleDifference]));
			w27.Position = 1;
			w27.Expand = false;
			w27.Fill = false;
			this.vbox3.Add (this.hbox11);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox11]));
			w28.Position = 1;
			w28.Expand = false;
			w28.Fill = false;
			this.hbox6.Add (this.vbox3);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.vbox3]));
			w29.Position = 1;
			w29.Expand = false;
			w29.Fill = false;
			this.vbox1.Add (this.hbox6);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox6]));
			w30.Position = 2;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox10 = new global::Gtk.HBox ();
			this.hbox10.Name = "hbox10";
			this.hbox10.Spacing = 6;
			// Container child hbox10.Gtk.Box+BoxChild
			this.labelFullBottles = new global::Gtk.Label ();
			this.labelFullBottles.Name = "labelFullBottles";
			this.labelFullBottles.LabelProp = global::Mono.Unix.Catalog.GetString ("Полн. бутылей");
			this.hbox10.Add (this.labelFullBottles);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.hbox10 [this.labelFullBottles]));
			w31.Position = 0;
			w31.Expand = false;
			w31.Fill = false;
			// Container child hbox10.Gtk.Box+BoxChild
			this.vseparator9 = new global::Gtk.VSeparator ();
			this.vseparator9.Name = "vseparator9";
			this.hbox10.Add (this.vseparator9);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.hbox10 [this.vseparator9]));
			w32.Position = 1;
			w32.Expand = false;
			w32.Fill = false;
			// Container child hbox10.Gtk.Box+BoxChild
			this.labelAddressCount = new global::Gtk.Label ();
			this.labelAddressCount.Name = "labelAddressCount";
			this.labelAddressCount.LabelProp = global::Mono.Unix.Catalog.GetString ("Адресов");
			this.hbox10.Add (this.labelAddressCount);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.hbox10 [this.labelAddressCount]));
			w33.Position = 2;
			w33.Expand = false;
			w33.Fill = false;
			// Container child hbox10.Gtk.Box+BoxChild
			this.vseparator8 = new global::Gtk.VSeparator ();
			this.vseparator8.Name = "vseparator8";
			this.hbox10.Add (this.vseparator8);
			global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.hbox10 [this.vseparator8]));
			w34.Position = 3;
			w34.Expand = false;
			w34.Fill = false;
			// Container child hbox10.Gtk.Box+BoxChild
			this.labelPhone = new global::Gtk.Label ();
			this.labelPhone.Name = "labelPhone";
			this.labelPhone.LabelProp = global::Mono.Unix.Catalog.GetString ("Сот. связь");
			this.hbox10.Add (this.labelPhone);
			global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.hbox10 [this.labelPhone]));
			w35.Position = 4;
			w35.Expand = false;
			w35.Fill = false;
			// Container child hbox10.Gtk.Box+BoxChild
			this.vseparator5 = new global::Gtk.VSeparator ();
			this.vseparator5.Name = "vseparator5";
			this.hbox10.Add (this.vseparator5);
			global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.hbox10 [this.vseparator5]));
			w36.Position = 5;
			w36.Expand = false;
			w36.Fill = false;
			// Container child hbox10.Gtk.Box+BoxChild
			this.labelDeposits = new global::Gtk.Label ();
			this.labelDeposits.Name = "labelDeposits";
			this.labelDeposits.LabelProp = global::Mono.Unix.Catalog.GetString ("Залогов");
			this.hbox10.Add (this.labelDeposits);
			global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.hbox10 [this.labelDeposits]));
			w37.Position = 6;
			w37.Expand = false;
			w37.Fill = false;
			// Container child hbox10.Gtk.Box+BoxChild
			this.vseparator4 = new global::Gtk.VSeparator ();
			this.vseparator4.Name = "vseparator4";
			this.hbox10.Add (this.vseparator4);
			global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.hbox10 [this.vseparator4]));
			w38.Position = 7;
			w38.Expand = false;
			w38.Fill = false;
			// Container child hbox10.Gtk.Box+BoxChild
			this.labelCash = new global::Gtk.Label ();
			this.labelCash.Name = "labelCash";
			this.labelCash.LabelProp = global::Mono.Unix.Catalog.GetString ("Итого(нал)");
			this.hbox10.Add (this.labelCash);
			global::Gtk.Box.BoxChild w39 = ((global::Gtk.Box.BoxChild)(this.hbox10 [this.labelCash]));
			w39.Position = 8;
			w39.Expand = false;
			w39.Fill = false;
			// Container child hbox10.Gtk.Box+BoxChild
			this.labelWage1 = new global::Gtk.Label ();
			this.labelWage1.Name = "labelWage1";
			this.labelWage1.LabelProp = global::Mono.Unix.Catalog.GetString ("Зарплата:");
			this.hbox10.Add (this.labelWage1);
			global::Gtk.Box.BoxChild w40 = ((global::Gtk.Box.BoxChild)(this.hbox10 [this.labelWage1]));
			w40.Position = 10;
			w40.Expand = false;
			w40.Fill = false;
			// Container child hbox10.Gtk.Box+BoxChild
			this.labelSum1 = new global::Gtk.Label ();
			this.labelSum1.Name = "labelSum1";
			this.labelSum1.Xalign = 1F;
			this.hbox10.Add (this.labelSum1);
			global::Gtk.Box.BoxChild w41 = ((global::Gtk.Box.BoxChild)(this.hbox10 [this.labelSum1]));
			w41.PackType = ((global::Gtk.PackType)(1));
			w41.Position = 11;
			w41.Expand = false;
			w41.Fill = false;
			this.vbox1.Add (this.hbox10);
			global::Gtk.Box.BoxChild w42 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox10]));
			w42.Position = 3;
			w42.Expand = false;
			w42.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox9 = new global::Gtk.HBox ();
			this.hbox9.Name = "hbox9";
			this.hbox9.Spacing = 6;
			// Container child hbox9.Gtk.Box+BoxChild
			this.labelTotalCollected = new global::Gtk.Label ();
			this.labelTotalCollected.Name = "labelTotalCollected";
			this.labelTotalCollected.LabelProp = global::Mono.Unix.Catalog.GetString ("Итого сдано");
			this.hbox9.Add (this.labelTotalCollected);
			global::Gtk.Box.BoxChild w43 = ((global::Gtk.Box.BoxChild)(this.hbox9 [this.labelTotalCollected]));
			w43.Position = 0;
			w43.Expand = false;
			w43.Fill = false;
			// Container child hbox9.Gtk.Box+BoxChild
			this.vseparator7 = new global::Gtk.VSeparator ();
			this.vseparator7.Name = "vseparator7";
			this.hbox9.Add (this.vseparator7);
			global::Gtk.Box.BoxChild w44 = ((global::Gtk.Box.BoxChild)(this.hbox9 [this.vseparator7]));
			w44.Position = 1;
			w44.Expand = false;
			w44.Fill = false;
			// Container child hbox9.Gtk.Box+BoxChild
			this.labelTotal = new global::Gtk.Label ();
			this.labelTotal.Name = "labelTotal";
			this.labelTotal.LabelProp = global::Mono.Unix.Catalog.GetString ("Итого");
			this.hbox9.Add (this.labelTotal);
			global::Gtk.Box.BoxChild w45 = ((global::Gtk.Box.BoxChild)(this.hbox9 [this.labelTotal]));
			w45.Position = 2;
			w45.Expand = false;
			w45.Fill = false;
			// Container child hbox9.Gtk.Box+BoxChild
			this.buttonAccept = new global::Gtk.Button ();
			this.buttonAccept.CanFocus = true;
			this.buttonAccept.Name = "buttonAccept";
			this.buttonAccept.UseUnderline = true;
			this.buttonAccept.Label = global::Mono.Unix.Catalog.GetString ("Подтвердить");
			global::Gtk.Image w46 = new global::Gtk.Image ();
			w46.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-apply", global::Gtk.IconSize.Menu);
			this.buttonAccept.Image = w46;
			this.hbox9.Add (this.buttonAccept);
			global::Gtk.Box.BoxChild w47 = ((global::Gtk.Box.BoxChild)(this.hbox9 [this.buttonAccept]));
			w47.PackType = ((global::Gtk.PackType)(1));
			w47.Position = 3;
			w47.Expand = false;
			w47.Fill = false;
			// Container child hbox9.Gtk.Box+BoxChild
			this.buttonBackToUnloading = new global::Gtk.Button ();
			this.buttonBackToUnloading.CanFocus = true;
			this.buttonBackToUnloading.Name = "buttonBackToUnloading";
			this.buttonBackToUnloading.UseUnderline = true;
			this.buttonBackToUnloading.Label = global::Mono.Unix.Catalog.GetString ("Отправить на доразгрузку");
			global::Gtk.Image w48 = new global::Gtk.Image ();
			w48.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-undo", global::Gtk.IconSize.Button);
			this.buttonBackToUnloading.Image = w48;
			this.hbox9.Add (this.buttonBackToUnloading);
			global::Gtk.Box.BoxChild w49 = ((global::Gtk.Box.BoxChild)(this.hbox9 [this.buttonBackToUnloading]));
			w49.PackType = ((global::Gtk.PackType)(1));
			w49.Position = 4;
			w49.Expand = false;
			w49.Fill = false;
			this.vbox1.Add (this.hbox9);
			global::Gtk.Box.BoxChild w50 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox9]));
			w50.Position = 4;
			w50.Expand = false;
			w50.Fill = false;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
			this.buttonSave.Clicked += new global::System.EventHandler (this.OnButtonSaveClicked);
			this.buttonCancel.Clicked += new global::System.EventHandler (this.OnButtonCancelClicked);
			this.buttonBackToUnloading.Clicked += new global::System.EventHandler (this.OnButtonBackToUnloadingClicked);
			this.buttonAccept.Clicked += new global::System.EventHandler (this.OnButtonAcceptClicked);
		}
	}
}
