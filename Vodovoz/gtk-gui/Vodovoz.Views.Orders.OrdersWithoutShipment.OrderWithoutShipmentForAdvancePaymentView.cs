
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz.Views.Orders.OrdersWithoutShipment
{
	public partial class OrderWithoutShipmentForAdvancePaymentView
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.HBox hbox1;

		private global::Gamma.GtkWidgets.yLabel ylabel1;

		private global::Gamma.GtkWidgets.yLabel ylabelOrderNum;

		private global::Gamma.GtkWidgets.yLabel ylabel3;

		private global::Gamma.GtkWidgets.yLabel ylabelOrderDate;

		private global::Gamma.GtkWidgets.yLabel ylabel5;

		private global::Gamma.GtkWidgets.yLabel ylabelOrderAuthor;

		private global::Gtk.HBox hbox2;

		private global::Gamma.GtkWidgets.yLabel ylabel7;

		private global::QS.Widgets.GtkUI.EntityViewModelEntry entityviewmodelentry1;

		private global::Gtk.Label label9;

		private global::Gamma.GtkWidgets.yTreeView treeItems;

		private global::Gtk.HBox hbox11;

		private global::Gtk.Button buttonAddForSale;

		private global::Gtk.Button buttonAddMaster;

		private global::QS.Widgets.EnumMenuButton enumAddRentButton;

		private global::QS.Widgets.GtkUI.SpecialListComboBox yCmbPromoSets;

		private global::Gtk.VSeparator vseparator1;

		private global::Gtk.Button btnDeleteOrderItem;

		private global::Gtk.HBox hbox12;

		private global::Gamma.GtkWidgets.yCheckButton yChkActionBottle;

		private global::Gtk.Label labelDiscont;

		private global::Gamma.Widgets.ySpecComboBox ycomboboxReason;

		private global::QSOrmProject.EnumListComboBox enumDiscountUnit;

		private global::Gamma.GtkWidgets.ySpinButton spinDiscount;

		private global::Gtk.HBox hbox5;

		private global::Gamma.GtkWidgets.yLabel ylabel9;

		private global::Gamma.GtkWidgets.yEntry yentryEmail;

		private global::Gamma.GtkWidgets.yButton ybtnSendEmail;

		private global::Gtk.HBox hbox6;

		private global::Gamma.GtkWidgets.yLabel ylabel10;

		private global::Gtk.HBox hbox8;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gamma.GtkWidgets.yTreeView ytreeviewSentOrders;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Vodovoz.Views.Orders.OrdersWithoutShipment.OrderWithoutShipmentForAdvancePaymentView
			global::Stetic.BinContainer.Attach(this);
			this.Name = "Vodovoz.Views.Orders.OrdersWithoutShipment.OrderWithoutShipmentForAdvancePaymentV" +
				"iew";
			// Container child Vodovoz.Views.Orders.OrdersWithoutShipment.OrderWithoutShipmentForAdvancePaymentView.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.ylabel1 = new global::Gamma.GtkWidgets.yLabel();
			this.ylabel1.Name = "ylabel1";
			this.ylabel1.LabelProp = global::Mono.Unix.Catalog.GetString("Счет без доставки № ");
			this.hbox1.Add(this.ylabel1);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.ylabel1]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.ylabelOrderNum = new global::Gamma.GtkWidgets.yLabel();
			this.ylabelOrderNum.Name = "ylabelOrderNum";
			this.ylabelOrderNum.LabelProp = global::Mono.Unix.Catalog.GetString("ylabel2");
			this.hbox1.Add(this.ylabelOrderNum);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.ylabelOrderNum]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.ylabel3 = new global::Gamma.GtkWidgets.yLabel();
			this.ylabel3.Name = "ylabel3";
			this.ylabel3.LabelProp = global::Mono.Unix.Catalog.GetString(" от ");
			this.hbox1.Add(this.ylabel3);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.ylabel3]));
			w3.Position = 2;
			w3.Expand = false;
			w3.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.ylabelOrderDate = new global::Gamma.GtkWidgets.yLabel();
			this.ylabelOrderDate.Name = "ylabelOrderDate";
			this.ylabelOrderDate.LabelProp = global::Mono.Unix.Catalog.GetString("orderDate");
			this.hbox1.Add(this.ylabelOrderDate);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.ylabelOrderDate]));
			w4.Position = 3;
			w4.Expand = false;
			w4.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.ylabel5 = new global::Gamma.GtkWidgets.yLabel();
			this.ylabel5.Name = "ylabel5";
			this.ylabel5.LabelProp = global::Mono.Unix.Catalog.GetString(" Автор: ");
			this.hbox1.Add(this.ylabel5);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.ylabel5]));
			w5.Position = 4;
			w5.Expand = false;
			w5.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.ylabelOrderAuthor = new global::Gamma.GtkWidgets.yLabel();
			this.ylabelOrderAuthor.Name = "ylabelOrderAuthor";
			this.ylabelOrderAuthor.LabelProp = global::Mono.Unix.Catalog.GetString("author");
			this.hbox1.Add(this.ylabelOrderAuthor);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.ylabelOrderAuthor]));
			w6.Position = 5;
			w6.Expand = false;
			w6.Fill = false;
			this.vbox1.Add(this.hbox1);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.ylabel7 = new global::Gamma.GtkWidgets.yLabel();
			this.ylabel7.Name = "ylabel7";
			this.ylabel7.LabelProp = global::Mono.Unix.Catalog.GetString("Контрагент: ");
			this.hbox2.Add(this.ylabel7);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.ylabel7]));
			w8.Position = 0;
			w8.Expand = false;
			w8.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.entityviewmodelentry1 = new global::QS.Widgets.GtkUI.EntityViewModelEntry();
			this.entityviewmodelentry1.Events = ((global::Gdk.EventMask)(256));
			this.entityviewmodelentry1.Name = "entityviewmodelentry1";
			this.entityviewmodelentry1.CanEditReference = false;
			this.hbox2.Add(this.entityviewmodelentry1);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.entityviewmodelentry1]));
			w9.Position = 1;
			this.vbox1.Add(this.hbox2);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox2]));
			w10.Position = 1;
			w10.Expand = false;
			w10.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.label9 = new global::Gtk.Label();
			this.label9.Name = "label9";
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Товары</b>");
			this.label9.UseMarkup = true;
			this.vbox1.Add(this.label9);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.label9]));
			w11.Position = 2;
			w11.Expand = false;
			w11.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.treeItems = new global::Gamma.GtkWidgets.yTreeView();
			this.treeItems.CanFocus = true;
			this.treeItems.Name = "treeItems";
			this.vbox1.Add(this.treeItems);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.treeItems]));
			w12.Position = 3;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox11 = new global::Gtk.HBox();
			this.hbox11.Name = "hbox11";
			this.hbox11.Spacing = 6;
			// Container child hbox11.Gtk.Box+BoxChild
			this.buttonAddForSale = new global::Gtk.Button();
			this.buttonAddForSale.CanFocus = true;
			this.buttonAddForSale.Name = "buttonAddForSale";
			this.buttonAddForSale.Label = global::Mono.Unix.Catalog.GetString("На продажу");
			global::Gtk.Image w13 = new global::Gtk.Image();
			w13.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-add", global::Gtk.IconSize.Menu);
			this.buttonAddForSale.Image = w13;
			this.hbox11.Add(this.buttonAddForSale);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox11[this.buttonAddForSale]));
			w14.Position = 0;
			w14.Expand = false;
			w14.Fill = false;
			// Container child hbox11.Gtk.Box+BoxChild
			this.buttonAddMaster = new global::Gtk.Button();
			this.buttonAddMaster.CanFocus = true;
			this.buttonAddMaster.Name = "buttonAddMaster";
			this.buttonAddMaster.Label = global::Mono.Unix.Catalog.GetString("Выезд мастера");
			global::Gtk.Image w15 = new global::Gtk.Image();
			w15.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-add", global::Gtk.IconSize.Menu);
			this.buttonAddMaster.Image = w15;
			this.hbox11.Add(this.buttonAddMaster);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox11[this.buttonAddMaster]));
			w16.Position = 1;
			w16.Expand = false;
			w16.Fill = false;
			// Container child hbox11.Gtk.Box+BoxChild
			this.enumAddRentButton = new global::QS.Widgets.EnumMenuButton();
			this.enumAddRentButton.CanFocus = true;
			this.enumAddRentButton.Name = "enumAddRentButton";
			this.enumAddRentButton.UseUnderline = true;
			this.enumAddRentButton.UseMarkup = false;
			this.enumAddRentButton.LabelXAlign = 0F;
			this.enumAddRentButton.Label = global::Mono.Unix.Catalog.GetString("В аренду");
			global::Gtk.Image w17 = new global::Gtk.Image();
			w17.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-add", global::Gtk.IconSize.Menu);
			this.enumAddRentButton.Image = w17;
			this.hbox11.Add(this.enumAddRentButton);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox11[this.enumAddRentButton]));
			w18.Position = 2;
			w18.Expand = false;
			w18.Fill = false;
			// Container child hbox11.Gtk.Box+BoxChild
			this.yCmbPromoSets = new global::QS.Widgets.GtkUI.SpecialListComboBox();
			this.yCmbPromoSets.Name = "yCmbPromoSets";
			this.yCmbPromoSets.AddIfNotExist = false;
			this.yCmbPromoSets.DefaultFirst = false;
			this.yCmbPromoSets.ShowSpecialStateAll = false;
			this.yCmbPromoSets.ShowSpecialStateNot = true;
			this.yCmbPromoSets.NameForSpecialStateNot = "Нет";
			this.hbox11.Add(this.yCmbPromoSets);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox11[this.yCmbPromoSets]));
			w19.Position = 3;
			w19.Expand = false;
			w19.Fill = false;
			// Container child hbox11.Gtk.Box+BoxChild
			this.vseparator1 = new global::Gtk.VSeparator();
			this.vseparator1.Name = "vseparator1";
			this.hbox11.Add(this.vseparator1);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox11[this.vseparator1]));
			w20.Position = 4;
			w20.Expand = false;
			w20.Fill = false;
			// Container child hbox11.Gtk.Box+BoxChild
			this.btnDeleteOrderItem = new global::Gtk.Button();
			this.btnDeleteOrderItem.CanFocus = true;
			this.btnDeleteOrderItem.Name = "btnDeleteOrderItem";
			this.btnDeleteOrderItem.UseUnderline = true;
			this.btnDeleteOrderItem.Label = global::Mono.Unix.Catalog.GetString("Удалить");
			global::Gtk.Image w21 = new global::Gtk.Image();
			w21.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-delete", global::Gtk.IconSize.Menu);
			this.btnDeleteOrderItem.Image = w21;
			this.hbox11.Add(this.btnDeleteOrderItem);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox11[this.btnDeleteOrderItem]));
			w22.Position = 5;
			w22.Expand = false;
			w22.Fill = false;
			this.vbox1.Add(this.hbox11);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox11]));
			w23.Position = 4;
			w23.Expand = false;
			w23.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox12 = new global::Gtk.HBox();
			this.hbox12.Name = "hbox12";
			this.hbox12.Spacing = 6;
			// Container child hbox12.Gtk.Box+BoxChild
			this.yChkActionBottle = new global::Gamma.GtkWidgets.yCheckButton();
			this.yChkActionBottle.CanFocus = true;
			this.yChkActionBottle.Name = "yChkActionBottle";
			this.yChkActionBottle.Label = global::Mono.Unix.Catalog.GetString("Акция \"Бутыль\"");
			this.yChkActionBottle.DrawIndicator = true;
			this.yChkActionBottle.UseUnderline = true;
			this.hbox12.Add(this.yChkActionBottle);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox12[this.yChkActionBottle]));
			w24.Position = 0;
			w24.Expand = false;
			w24.Fill = false;
			// Container child hbox12.Gtk.Box+BoxChild
			this.labelDiscont = new global::Gtk.Label();
			this.labelDiscont.Name = "labelDiscont";
			this.labelDiscont.LabelProp = global::Mono.Unix.Catalog.GetString("Скидка на все:");
			this.hbox12.Add(this.labelDiscont);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hbox12[this.labelDiscont]));
			w25.Position = 1;
			w25.Expand = false;
			w25.Fill = false;
			// Container child hbox12.Gtk.Box+BoxChild
			this.ycomboboxReason = new global::Gamma.Widgets.ySpecComboBox();
			this.ycomboboxReason.Name = "ycomboboxReason";
			this.ycomboboxReason.AddIfNotExist = false;
			this.ycomboboxReason.DefaultFirst = false;
			this.ycomboboxReason.ShowSpecialStateAll = false;
			this.ycomboboxReason.ShowSpecialStateNot = false;
			this.hbox12.Add(this.ycomboboxReason);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox12[this.ycomboboxReason]));
			w26.Position = 2;
			w26.Expand = false;
			w26.Fill = false;
			// Container child hbox12.Gtk.Box+BoxChild
			this.enumDiscountUnit = new global::QSOrmProject.EnumListComboBox();
			this.enumDiscountUnit.CanDefault = true;
			this.enumDiscountUnit.Name = "enumDiscountUnit";
			this.hbox12.Add(this.enumDiscountUnit);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.hbox12[this.enumDiscountUnit]));
			w27.Position = 3;
			w27.Expand = false;
			w27.Fill = false;
			// Container child hbox12.Gtk.Box+BoxChild
			this.spinDiscount = new global::Gamma.GtkWidgets.ySpinButton(0D, 100D, 1D);
			this.spinDiscount.CanFocus = true;
			this.spinDiscount.Name = "spinDiscount";
			this.spinDiscount.Adjustment.PageIncrement = 1D;
			this.spinDiscount.ClimbRate = 1D;
			this.spinDiscount.Numeric = true;
			this.spinDiscount.ValueAsDecimal = 0m;
			this.spinDiscount.ValueAsInt = 0;
			this.hbox12.Add(this.spinDiscount);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.hbox12[this.spinDiscount]));
			w28.Position = 4;
			w28.Expand = false;
			w28.Fill = false;
			this.vbox1.Add(this.hbox12);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox12]));
			w29.Position = 5;
			w29.Expand = false;
			w29.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox5 = new global::Gtk.HBox();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.ylabel9 = new global::Gamma.GtkWidgets.yLabel();
			this.ylabel9.Name = "ylabel9";
			this.ylabel9.LabelProp = global::Mono.Unix.Catalog.GetString("Email");
			this.hbox5.Add(this.ylabel9);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.ylabel9]));
			w30.Position = 0;
			w30.Expand = false;
			w30.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.yentryEmail = new global::Gamma.GtkWidgets.yEntry();
			this.yentryEmail.CanFocus = true;
			this.yentryEmail.Name = "yentryEmail";
			this.yentryEmail.IsEditable = true;
			this.yentryEmail.InvisibleChar = '•';
			this.hbox5.Add(this.yentryEmail);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.yentryEmail]));
			w31.Position = 1;
			w31.Expand = false;
			w31.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.ybtnSendEmail = new global::Gamma.GtkWidgets.yButton();
			this.ybtnSendEmail.CanFocus = true;
			this.ybtnSendEmail.Name = "ybtnSendEmail";
			this.ybtnSendEmail.UseUnderline = true;
			this.ybtnSendEmail.Label = global::Mono.Unix.Catalog.GetString("Отправить");
			this.hbox5.Add(this.ybtnSendEmail);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.ybtnSendEmail]));
			w32.Position = 2;
			w32.Expand = false;
			w32.Fill = false;
			this.vbox1.Add(this.hbox5);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox5]));
			w33.Position = 6;
			w33.Expand = false;
			w33.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox6 = new global::Gtk.HBox();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.ylabel10 = new global::Gamma.GtkWidgets.yLabel();
			this.ylabel10.Name = "ylabel10";
			this.ylabel10.LabelProp = global::Mono.Unix.Catalog.GetString("Отправленные счета:");
			this.hbox6.Add(this.ylabel10);
			global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.ylabel10]));
			w34.Position = 0;
			w34.Expand = false;
			w34.Fill = false;
			this.vbox1.Add(this.hbox6);
			global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox6]));
			w35.Position = 7;
			w35.Expand = false;
			w35.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox8 = new global::Gtk.HBox();
			this.hbox8.Name = "hbox8";
			this.hbox8.Spacing = 6;
			// Container child hbox8.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.ytreeviewSentOrders = new global::Gamma.GtkWidgets.yTreeView();
			this.ytreeviewSentOrders.CanFocus = true;
			this.ytreeviewSentOrders.Name = "ytreeviewSentOrders";
			this.GtkScrolledWindow.Add(this.ytreeviewSentOrders);
			this.hbox8.Add(this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.GtkScrolledWindow]));
			w37.Position = 0;
			this.vbox1.Add(this.hbox8);
			global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox8]));
			w38.Position = 8;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}
