
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz
{
	public partial class PaidRentPackageDlg
	{
		private global::Gtk.VBox vbox2;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Button buttonSave;

		private global::Gtk.Button buttonCancel;

		private global::Gtk.Table datatable1;

		private global::Gamma.GtkWidgets.yEntry dataentryName;

		private global::Gtk.HBox hbox6;

		private global::Gamma.GtkWidgets.ySpinButton spinPriceDaily;

		private global::QSProjectsLib.CurrencyLabel currencylabel1;

		private global::Gtk.HBox hbox7;

		private global::Gamma.GtkWidgets.ySpinButton spinPriceMonthly;

		private global::QSProjectsLib.CurrencyLabel currencylabel2;

		private global::Gtk.HBox hbox8;

		private global::Gamma.GtkWidgets.ySpinButton spinDeposit;

		private global::QSProjectsLib.CurrencyLabel currencylabel3;

		private global::Gtk.Label label1;

		private global::Gtk.Label label3;

		private global::Gtk.Label label4;

		private global::Gtk.Label label5;

		private global::Gtk.Label label6;

		private global::Gtk.Label label7;

		private global::Gtk.Label label8;

		private global::Gtk.Label label9;

		private global::Gamma.Widgets.yEntryReference referenceDepositService;

		private global::Gamma.Widgets.yEntryReference referenceEquipmentType;

		private global::Gamma.Widgets.yEntryReference referenceRentServiceDaily;

		private global::Gamma.Widgets.yEntryReference referenceRentServiceMonthly;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Vodovoz.PaidRentPackageDlg
			global::Stetic.BinContainer.Attach(this);
			this.Name = "Vodovoz.PaidRentPackageDlg";
			// Container child Vodovoz.PaidRentPackageDlg.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.buttonSave = new global::Gtk.Button();
			this.buttonSave.CanFocus = true;
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.UseUnderline = true;
			this.buttonSave.Label = global::Mono.Unix.Catalog.GetString("Сохранить");
			global::Gtk.Image w1 = new global::Gtk.Image();
			w1.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-save", global::Gtk.IconSize.Menu);
			this.buttonSave.Image = w1;
			this.hbox1.Add(this.buttonSave);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.buttonSave]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.buttonCancel = new global::Gtk.Button();
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = global::Mono.Unix.Catalog.GetString("Отменить");
			global::Gtk.Image w3 = new global::Gtk.Image();
			w3.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-revert-to-saved", global::Gtk.IconSize.Menu);
			this.buttonCancel.Image = w3;
			this.hbox1.Add(this.buttonCancel);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.buttonCancel]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			this.vbox2.Add(this.hbox1);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox1]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.datatable1 = new global::Gtk.Table(((uint)(8)), ((uint)(2)), false);
			this.datatable1.Name = "datatable1";
			this.datatable1.RowSpacing = ((uint)(6));
			this.datatable1.ColumnSpacing = ((uint)(6));
			this.datatable1.BorderWidth = ((uint)(6));
			// Container child datatable1.Gtk.Table+TableChild
			this.dataentryName = new global::Gamma.GtkWidgets.yEntry();
			this.dataentryName.CanFocus = true;
			this.dataentryName.Name = "dataentryName";
			this.dataentryName.IsEditable = true;
			this.dataentryName.InvisibleChar = '●';
			this.datatable1.Add(this.dataentryName);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.datatable1[this.dataentryName]));
			w6.LeftAttach = ((uint)(1));
			w6.RightAttach = ((uint)(2));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.hbox6 = new global::Gtk.HBox();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.spinPriceDaily = new global::Gamma.GtkWidgets.ySpinButton(0, 9000000, 1);
			this.spinPriceDaily.CanFocus = true;
			this.spinPriceDaily.Name = "spinPriceDaily";
			this.spinPriceDaily.Adjustment.PageIncrement = 10;
			this.spinPriceDaily.ClimbRate = 1;
			this.spinPriceDaily.Digits = ((uint)(2));
			this.spinPriceDaily.Numeric = true;
			this.spinPriceDaily.ValueAsDecimal = 0m;
			this.spinPriceDaily.ValueAsInt = 0;
			this.hbox6.Add(this.spinPriceDaily);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.spinPriceDaily]));
			w7.Position = 0;
			// Container child hbox6.Gtk.Box+BoxChild
			this.currencylabel1 = new global::QSProjectsLib.CurrencyLabel();
			this.currencylabel1.Name = "currencylabel1";
			this.currencylabel1.LabelProp = global::Mono.Unix.Catalog.GetString("currencylabel1");
			this.hbox6.Add(this.currencylabel1);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.currencylabel1]));
			w8.Position = 1;
			w8.Expand = false;
			w8.Fill = false;
			this.datatable1.Add(this.hbox6);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.datatable1[this.hbox6]));
			w9.TopAttach = ((uint)(1));
			w9.BottomAttach = ((uint)(2));
			w9.LeftAttach = ((uint)(1));
			w9.RightAttach = ((uint)(2));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.hbox7 = new global::Gtk.HBox();
			this.hbox7.Name = "hbox7";
			this.hbox7.Spacing = 6;
			// Container child hbox7.Gtk.Box+BoxChild
			this.spinPriceMonthly = new global::Gamma.GtkWidgets.ySpinButton(0, 9000000, 1);
			this.spinPriceMonthly.CanFocus = true;
			this.spinPriceMonthly.Name = "spinPriceMonthly";
			this.spinPriceMonthly.Adjustment.PageIncrement = 10;
			this.spinPriceMonthly.ClimbRate = 1;
			this.spinPriceMonthly.Digits = ((uint)(2));
			this.spinPriceMonthly.Numeric = true;
			this.spinPriceMonthly.ValueAsDecimal = 0m;
			this.spinPriceMonthly.ValueAsInt = 0;
			this.hbox7.Add(this.spinPriceMonthly);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.spinPriceMonthly]));
			w10.Position = 0;
			// Container child hbox7.Gtk.Box+BoxChild
			this.currencylabel2 = new global::QSProjectsLib.CurrencyLabel();
			this.currencylabel2.Name = "currencylabel2";
			this.currencylabel2.LabelProp = global::Mono.Unix.Catalog.GetString("currencylabel1");
			this.hbox7.Add(this.currencylabel2);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.currencylabel2]));
			w11.Position = 1;
			w11.Expand = false;
			w11.Fill = false;
			this.datatable1.Add(this.hbox7);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.datatable1[this.hbox7]));
			w12.TopAttach = ((uint)(3));
			w12.BottomAttach = ((uint)(4));
			w12.LeftAttach = ((uint)(1));
			w12.RightAttach = ((uint)(2));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.hbox8 = new global::Gtk.HBox();
			this.hbox8.Name = "hbox8";
			this.hbox8.Spacing = 6;
			// Container child hbox8.Gtk.Box+BoxChild
			this.spinDeposit = new global::Gamma.GtkWidgets.ySpinButton(0, 99999, 1);
			this.spinDeposit.CanFocus = true;
			this.spinDeposit.Name = "spinDeposit";
			this.spinDeposit.Adjustment.PageIncrement = 10;
			this.spinDeposit.ClimbRate = 1;
			this.spinDeposit.Digits = ((uint)(2));
			this.spinDeposit.Numeric = true;
			this.spinDeposit.ValueAsDecimal = 0m;
			this.spinDeposit.ValueAsInt = 0;
			this.hbox8.Add(this.spinDeposit);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.spinDeposit]));
			w13.Position = 0;
			// Container child hbox8.Gtk.Box+BoxChild
			this.currencylabel3 = new global::QSProjectsLib.CurrencyLabel();
			this.currencylabel3.Name = "currencylabel3";
			this.currencylabel3.LabelProp = global::Mono.Unix.Catalog.GetString("currencylabel1");
			this.hbox8.Add(this.currencylabel3);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.currencylabel3]));
			w14.Position = 1;
			w14.Expand = false;
			w14.Fill = false;
			this.datatable1.Add(this.hbox8);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.datatable1[this.hbox8]));
			w15.TopAttach = ((uint)(6));
			w15.BottomAttach = ((uint)(7));
			w15.LeftAttach = ((uint)(1));
			w15.RightAttach = ((uint)(2));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.Xalign = 1F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Название:");
			this.datatable1.Add(this.label1);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.datatable1[this.label1]));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.Xalign = 1F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Услуга посуточной \nаренды:");
			this.label3.Justify = ((global::Gtk.Justification)(1));
			this.datatable1.Add(this.label3);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.datatable1[this.label3]));
			w17.TopAttach = ((uint)(2));
			w17.BottomAttach = ((uint)(3));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.Xalign = 1F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Стоимость (месяц):");
			this.datatable1.Add(this.label4);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.datatable1[this.label4]));
			w18.TopAttach = ((uint)(3));
			w18.BottomAttach = ((uint)(4));
			w18.XOptions = ((global::Gtk.AttachOptions)(4));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label();
			this.label5.Name = "label5";
			this.label5.Xalign = 1F;
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Услуга залога:");
			this.datatable1.Add(this.label5);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.datatable1[this.label5]));
			w19.TopAttach = ((uint)(7));
			w19.BottomAttach = ((uint)(8));
			w19.XOptions = ((global::Gtk.AttachOptions)(4));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.label6 = new global::Gtk.Label();
			this.label6.Name = "label6";
			this.label6.Xalign = 1F;
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString("Стоимость (сутки):");
			this.datatable1.Add(this.label6);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.datatable1[this.label6]));
			w20.TopAttach = ((uint)(1));
			w20.BottomAttach = ((uint)(2));
			w20.XOptions = ((global::Gtk.AttachOptions)(4));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.label7 = new global::Gtk.Label();
			this.label7.Name = "label7";
			this.label7.Xalign = 1F;
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString("Тип оборудования:");
			this.datatable1.Add(this.label7);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.datatable1[this.label7]));
			w21.TopAttach = ((uint)(5));
			w21.BottomAttach = ((uint)(6));
			w21.XOptions = ((global::Gtk.AttachOptions)(4));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.label8 = new global::Gtk.Label();
			this.label8.Name = "label8";
			this.label8.Xalign = 1F;
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString("Услуга долгосрочной\nаренды:");
			this.label8.Justify = ((global::Gtk.Justification)(1));
			this.datatable1.Add(this.label8);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.datatable1[this.label8]));
			w22.TopAttach = ((uint)(4));
			w22.BottomAttach = ((uint)(5));
			w22.XOptions = ((global::Gtk.AttachOptions)(4));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.label9 = new global::Gtk.Label();
			this.label9.Name = "label9";
			this.label9.Xalign = 1F;
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString("Сумма залога:");
			this.datatable1.Add(this.label9);
			global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.datatable1[this.label9]));
			w23.TopAttach = ((uint)(6));
			w23.BottomAttach = ((uint)(7));
			w23.XOptions = ((global::Gtk.AttachOptions)(4));
			w23.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.referenceDepositService = new global::Gamma.Widgets.yEntryReference();
			this.referenceDepositService.Events = ((global::Gdk.EventMask)(256));
			this.referenceDepositService.Name = "referenceDepositService";
			this.datatable1.Add(this.referenceDepositService);
			global::Gtk.Table.TableChild w24 = ((global::Gtk.Table.TableChild)(this.datatable1[this.referenceDepositService]));
			w24.TopAttach = ((uint)(7));
			w24.BottomAttach = ((uint)(8));
			w24.LeftAttach = ((uint)(1));
			w24.RightAttach = ((uint)(2));
			w24.XOptions = ((global::Gtk.AttachOptions)(4));
			w24.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.referenceEquipmentType = new global::Gamma.Widgets.yEntryReference();
			this.referenceEquipmentType.Events = ((global::Gdk.EventMask)(256));
			this.referenceEquipmentType.Name = "referenceEquipmentType";
			this.datatable1.Add(this.referenceEquipmentType);
			global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.datatable1[this.referenceEquipmentType]));
			w25.TopAttach = ((uint)(5));
			w25.BottomAttach = ((uint)(6));
			w25.LeftAttach = ((uint)(1));
			w25.RightAttach = ((uint)(2));
			w25.XOptions = ((global::Gtk.AttachOptions)(4));
			w25.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.referenceRentServiceDaily = new global::Gamma.Widgets.yEntryReference();
			this.referenceRentServiceDaily.Events = ((global::Gdk.EventMask)(256));
			this.referenceRentServiceDaily.Name = "referenceRentServiceDaily";
			this.datatable1.Add(this.referenceRentServiceDaily);
			global::Gtk.Table.TableChild w26 = ((global::Gtk.Table.TableChild)(this.datatable1[this.referenceRentServiceDaily]));
			w26.TopAttach = ((uint)(2));
			w26.BottomAttach = ((uint)(3));
			w26.LeftAttach = ((uint)(1));
			w26.RightAttach = ((uint)(2));
			w26.XOptions = ((global::Gtk.AttachOptions)(4));
			w26.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatable1.Gtk.Table+TableChild
			this.referenceRentServiceMonthly = new global::Gamma.Widgets.yEntryReference();
			this.referenceRentServiceMonthly.Events = ((global::Gdk.EventMask)(256));
			this.referenceRentServiceMonthly.Name = "referenceRentServiceMonthly";
			this.datatable1.Add(this.referenceRentServiceMonthly);
			global::Gtk.Table.TableChild w27 = ((global::Gtk.Table.TableChild)(this.datatable1[this.referenceRentServiceMonthly]));
			w27.TopAttach = ((uint)(4));
			w27.BottomAttach = ((uint)(5));
			w27.LeftAttach = ((uint)(1));
			w27.RightAttach = ((uint)(2));
			w27.XOptions = ((global::Gtk.AttachOptions)(4));
			w27.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox2.Add(this.datatable1);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.datatable1]));
			w28.Position = 1;
			w28.Expand = false;
			w28.Fill = false;
			this.Add(this.vbox2);
			if((this.Child != null)) {
				this.Child.ShowAll();
			}
			this.Hide();
			this.buttonSave.Clicked += new global::System.EventHandler(this.OnButtonSaveClicked);
			this.buttonCancel.Clicked += new global::System.EventHandler(this.OnButtonCancelClicked);
		}
	}
}
