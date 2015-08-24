
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz
{
	public partial class AdditionalAgreementWater
	{
		private global::Gtk.VBox vbox1;
		
		private global::Gtk.HBox hbox1;
		
		private global::Gtk.Button buttonSave;
		
		private global::Gtk.Button buttonCancel;
		
		private global::Gtk.DataBindings.DataTable datatable1;
		
		private global::QSOrmProject.DataDatePicker dateIssue;
		
		private global::QSOrmProject.DataDatePicker dateStart;
		
		private global::Gtk.HBox hbox5;
		
		private global::Gtk.DataBindings.DataLabel dataAgreementType;
		
		private global::Gtk.DataBindings.DataEntry entryAgreementNumber;
		
		private global::Gtk.HBox hbox6;
		
		private global::Gtk.DataBindings.DataCheckButton checkIsFixedPrice;
		
		private global::Gtk.DataBindings.DataSpinButton spinFixedPrice;
		
		private global::QSProjectsLib.CurrencyLabel currencylabel1;
		
		private global::Gtk.Label label1;
		
		private global::Gtk.Label label2;
		
		private global::Gtk.Label label3;
		
		private global::Gtk.Label label4;
		
		private global::Gtk.Label label5;
		
		private global::Gtk.DataBindings.DataEntryReferenceVM referenceDeliveryPoint;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Vodovoz.AdditionalAgreementWater
			global::Stetic.BinContainer.Attach (this);
			this.Name = "Vodovoz.AdditionalAgreementWater";
			// Container child Vodovoz.AdditionalAgreementWater.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
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
			this.datatable1 = new global::Gtk.DataBindings.DataTable (((uint)(5)), ((uint)(2)), false);
			this.datatable1.Name = "datatable1";
			this.datatable1.RowSpacing = ((uint)(6));
			this.datatable1.ColumnSpacing = ((uint)(6));
			this.datatable1.BorderWidth = ((uint)(6));
			this.datatable1.InheritedDataSource = false;
			this.datatable1.InheritedBoundaryDataSource = false;
			this.datatable1.InheritedDataSource = false;
			this.datatable1.InheritedBoundaryDataSource = false;
			// Container child datatable1.Gtk.Table+TableChild
			this.dateIssue = new global::QSOrmProject.DataDatePicker ();
			this.dateIssue.Events = ((global::Gdk.EventMask)(256));
			this.dateIssue.Name = "dateIssue";
			this.dateIssue.Date = new global::System.DateTime (0);
			this.dateIssue.IsEditable = true;
			this.dateIssue.AutoSeparation = false;
			this.dateIssue.InheritedDataSource = true;
			this.dateIssue.Mappings = "IssueDate";
			this.dateIssue.InheritedBoundaryDataSource = false;
			this.datatable1.Add (this.dateIssue);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.datatable1 [this.dateIssue]));
			w6.TopAttach = ((uint)(2));
			w6.BottomAttach = ((uint)(3));
			w6.LeftAttach = ((uint)(1));
			w6.RightAttach = ((uint)(2));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.dateStart = new global::QSOrmProject.DataDatePicker ();
			this.dateStart.Events = ((global::Gdk.EventMask)(256));
			this.dateStart.Name = "dateStart";
			this.dateStart.Date = new global::System.DateTime (0);
			this.dateStart.IsEditable = true;
			this.dateStart.AutoSeparation = false;
			this.dateStart.InheritedDataSource = true;
			this.dateStart.Mappings = "StartDate";
			this.dateStart.InheritedBoundaryDataSource = false;
			this.datatable1.Add (this.dateStart);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.datatable1 [this.dateStart]));
			w7.TopAttach = ((uint)(3));
			w7.BottomAttach = ((uint)(4));
			w7.LeftAttach = ((uint)(1));
			w7.RightAttach = ((uint)(2));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.hbox5 = new global::Gtk.HBox ();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.dataAgreementType = new global::Gtk.DataBindings.DataLabel ();
			this.dataAgreementType.Name = "dataAgreementType";
			this.dataAgreementType.InheritedDataSource = false;
			this.dataAgreementType.InheritedBoundaryDataSource = false;
			this.dataAgreementType.Important = false;
			this.dataAgreementType.InheritedDataSource = false;
			this.dataAgreementType.InheritedBoundaryDataSource = false;
			this.hbox5.Add (this.dataAgreementType);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.dataAgreementType]));
			w8.Position = 0;
			w8.Expand = false;
			w8.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.entryAgreementNumber = new global::Gtk.DataBindings.DataEntry ();
			this.entryAgreementNumber.CanFocus = true;
			this.entryAgreementNumber.Name = "entryAgreementNumber";
			this.entryAgreementNumber.IsEditable = true;
			this.entryAgreementNumber.InvisibleChar = '●';
			this.entryAgreementNumber.InheritedDataSource = true;
			this.entryAgreementNumber.Mappings = "AgreementNumber";
			this.entryAgreementNumber.InheritedBoundaryDataSource = false;
			this.entryAgreementNumber.InheritedDataSource = true;
			this.entryAgreementNumber.Mappings = "AgreementNumber";
			this.entryAgreementNumber.InheritedBoundaryDataSource = false;
			this.hbox5.Add (this.entryAgreementNumber);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.entryAgreementNumber]));
			w9.Position = 1;
			this.datatable1.Add (this.hbox5);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.datatable1 [this.hbox5]));
			w10.LeftAttach = ((uint)(1));
			w10.RightAttach = ((uint)(2));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.hbox6 = new global::Gtk.HBox ();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.checkIsFixedPrice = new global::Gtk.DataBindings.DataCheckButton ();
			this.checkIsFixedPrice.CanFocus = true;
			this.checkIsFixedPrice.Name = "checkIsFixedPrice";
			this.checkIsFixedPrice.Label = "";
			this.checkIsFixedPrice.DrawIndicator = true;
			this.checkIsFixedPrice.UseUnderline = true;
			this.checkIsFixedPrice.InheritedDataSource = true;
			this.checkIsFixedPrice.Mappings = "IsFixedPrice";
			this.checkIsFixedPrice.InheritedBoundaryDataSource = false;
			this.checkIsFixedPrice.Editable = true;
			this.checkIsFixedPrice.AutomaticTitle = false;
			this.checkIsFixedPrice.InheritedBoundaryDataSource = false;
			this.checkIsFixedPrice.InheritedDataSource = true;
			this.checkIsFixedPrice.Mappings = "IsFixedPrice";
			this.hbox6.Add (this.checkIsFixedPrice);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.checkIsFixedPrice]));
			w11.Position = 0;
			w11.Expand = false;
			w11.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.spinFixedPrice = new global::Gtk.DataBindings.DataSpinButton (0, 10000, 1);
			this.spinFixedPrice.CanFocus = true;
			this.spinFixedPrice.Name = "spinFixedPrice";
			this.spinFixedPrice.Adjustment.PageIncrement = 10;
			this.spinFixedPrice.ClimbRate = 1;
			this.spinFixedPrice.Digits = ((uint)(2));
			this.spinFixedPrice.Numeric = true;
			this.spinFixedPrice.InheritedDataSource = true;
			this.spinFixedPrice.Mappings = "FixedPrice";
			this.spinFixedPrice.InheritedBoundaryDataSource = false;
			this.spinFixedPrice.InheritedDataSource = true;
			this.spinFixedPrice.Mappings = "FixedPrice";
			this.spinFixedPrice.InheritedBoundaryDataSource = false;
			this.hbox6.Add (this.spinFixedPrice);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.spinFixedPrice]));
			w12.Position = 1;
			// Container child hbox6.Gtk.Box+BoxChild
			this.currencylabel1 = new global::QSProjectsLib.CurrencyLabel ();
			this.currencylabel1.Name = "currencylabel1";
			this.currencylabel1.LabelProp = global::Mono.Unix.Catalog.GetString ("currencylabel1");
			this.hbox6.Add (this.currencylabel1);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.currencylabel1]));
			w13.Position = 2;
			w13.Expand = false;
			w13.Fill = false;
			this.datatable1.Add (this.hbox6);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.datatable1 [this.hbox6]));
			w14.TopAttach = ((uint)(4));
			w14.BottomAttach = ((uint)(5));
			w14.LeftAttach = ((uint)(1));
			w14.RightAttach = ((uint)(2));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 1F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Номер доп. соглашения:");
			this.datatable1.Add (this.label1);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.datatable1 [this.label1]));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.Xalign = 1F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Точка доставки:");
			this.datatable1.Add (this.label2);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.datatable1 [this.label2]));
			w16.TopAttach = ((uint)(1));
			w16.BottomAttach = ((uint)(2));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.Xalign = 1F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Дата создания:");
			this.datatable1.Add (this.label3);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.datatable1 [this.label3]));
			w17.TopAttach = ((uint)(2));
			w17.BottomAttach = ((uint)(3));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.Xalign = 1F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Дата начала действия:");
			this.datatable1.Add (this.label4);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.datatable1 [this.label4]));
			w18.TopAttach = ((uint)(3));
			w18.BottomAttach = ((uint)(4));
			w18.XOptions = ((global::Gtk.AttachOptions)(4));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.Xalign = 1F;
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Фиксированная стоимость:");
			this.datatable1.Add (this.label5);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.datatable1 [this.label5]));
			w19.TopAttach = ((uint)(4));
			w19.BottomAttach = ((uint)(5));
			w19.XOptions = ((global::Gtk.AttachOptions)(4));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.referenceDeliveryPoint = new global::Gtk.DataBindings.DataEntryReferenceVM ();
			this.referenceDeliveryPoint.Events = ((global::Gdk.EventMask)(256));
			this.referenceDeliveryPoint.Name = "referenceDeliveryPoint";
			this.referenceDeliveryPoint.InheritedDataSource = true;
			this.referenceDeliveryPoint.Mappings = "DeliveryPoint";
			this.referenceDeliveryPoint.ColumnMappings = "";
			this.referenceDeliveryPoint.InheritedBoundaryDataSource = false;
			this.referenceDeliveryPoint.CursorPointsEveryType = false;
			this.datatable1.Add (this.referenceDeliveryPoint);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.datatable1 [this.referenceDeliveryPoint]));
			w20.TopAttach = ((uint)(1));
			w20.BottomAttach = ((uint)(2));
			w20.LeftAttach = ((uint)(1));
			w20.RightAttach = ((uint)(2));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox1.Add (this.datatable1);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.datatable1]));
			w21.Position = 1;
			w21.Expand = false;
			w21.Fill = false;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
			this.buttonSave.Clicked += new global::System.EventHandler (this.OnButtonSaveClicked);
			this.buttonCancel.Clicked += new global::System.EventHandler (this.OnButtonCancelClicked);
			this.checkIsFixedPrice.Toggled += new global::System.EventHandler (this.OnCheckIsFixedPriceToggled);
		}
	}
}
