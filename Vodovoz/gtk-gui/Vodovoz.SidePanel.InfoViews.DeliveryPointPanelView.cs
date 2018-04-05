
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz.SidePanel.InfoViews
{
	public partial class DeliveryPointPanelView
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.Label label1;

		private global::Gtk.Label label2;

		private global::Vodovoz.WrapLabel labelAddress;

		private global::Gtk.Table table2;

		private global::Gtk.Label label4;

		private global::Gtk.Label label5;

		private global::Vodovoz.WrapLabel labelBottles;

		private global::Vodovoz.WrapLabel labelDeposits;

		private global::Vodovoz.WrapLabel labelPhone;

		private global::Gtk.Label labelPhoneText;

		private global::Gtk.VBox vboxLastOrders;

		private global::Gtk.Label labelLastOrders;

		private global::Gtk.ScrolledWindow GtkScrolledWindow1;

		private global::Gamma.GtkWidgets.yTreeView ytreeLastOrders;

		private global::Gtk.Label label3;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gtk.TextView textviewComment;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Button buttonSaveComment;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Vodovoz.SidePanel.InfoViews.DeliveryPointPanelView
			global::Stetic.BinContainer.Attach(this);
			this.Name = "Vodovoz.SidePanel.InfoViews.DeliveryPointPanelView";
			// Container child Vodovoz.SidePanel.InfoViews.DeliveryPointPanelView.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("<u><b>Точка доставки:</b></u>");
			this.label1.UseMarkup = true;
			this.vbox1.Add(this.label1);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.label1]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Адрес:</b>");
			this.label2.UseMarkup = true;
			this.vbox1.Add(this.label2);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.label2]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.labelAddress = new global::Vodovoz.WrapLabel();
			this.labelAddress.Name = "labelAddress";
			this.labelAddress.LabelProp = global::Mono.Unix.Catalog.GetString("wraplabel1");
			this.labelAddress.Wrap = true;
			this.labelAddress.Selectable = true;
			this.vbox1.Add(this.labelAddress);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.labelAddress]));
			w3.Position = 2;
			w3.Expand = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.table2 = new global::Gtk.Table(((uint)(3)), ((uint)(2)), false);
			this.table2.Name = "table2";
			this.table2.RowSpacing = ((uint)(6));
			this.table2.ColumnSpacing = ((uint)(6));
			// Container child table2.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.Xalign = 1F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Бутылей:");
			this.label4.Wrap = true;
			this.label4.Justify = ((global::Gtk.Justification)(2));
			this.table2.Add(this.label4);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table2[this.label4]));
			w4.TopAttach = ((uint)(1));
			w4.BottomAttach = ((uint)(2));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label();
			this.label5.Name = "label5";
			this.label5.Xalign = 1F;
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Залогов:");
			this.label5.Wrap = true;
			this.label5.Justify = ((global::Gtk.Justification)(2));
			this.table2.Add(this.label5);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table2[this.label5]));
			w5.TopAttach = ((uint)(2));
			w5.BottomAttach = ((uint)(3));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.labelBottles = new global::Vodovoz.WrapLabel();
			this.labelBottles.Name = "labelBottles";
			this.labelBottles.LabelProp = global::Mono.Unix.Catalog.GetString("wraplabel1");
			this.labelBottles.Wrap = true;
			this.labelBottles.Justify = ((global::Gtk.Justification)(2));
			this.labelBottles.Selectable = true;
			this.table2.Add(this.labelBottles);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table2[this.labelBottles]));
			w6.TopAttach = ((uint)(1));
			w6.BottomAttach = ((uint)(2));
			w6.LeftAttach = ((uint)(1));
			w6.RightAttach = ((uint)(2));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.labelDeposits = new global::Vodovoz.WrapLabel();
			this.labelDeposits.Name = "labelDeposits";
			this.labelDeposits.LabelProp = global::Mono.Unix.Catalog.GetString("wraplabel3");
			this.labelDeposits.Selectable = true;
			this.table2.Add(this.labelDeposits);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table2[this.labelDeposits]));
			w7.TopAttach = ((uint)(2));
			w7.BottomAttach = ((uint)(3));
			w7.LeftAttach = ((uint)(1));
			w7.RightAttach = ((uint)(2));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.labelPhone = new global::Vodovoz.WrapLabel();
			this.labelPhone.Name = "labelPhone";
			this.labelPhone.LabelProp = global::Mono.Unix.Catalog.GetString("wraplabel1");
			this.table2.Add(this.labelPhone);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table2[this.labelPhone]));
			w8.LeftAttach = ((uint)(1));
			w8.RightAttach = ((uint)(2));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.labelPhoneText = new global::Gtk.Label();
			this.labelPhoneText.Name = "labelPhoneText";
			this.labelPhoneText.Xalign = 1F;
			this.labelPhoneText.LabelProp = global::Mono.Unix.Catalog.GetString("Телефон:");
			this.table2.Add(this.labelPhoneText);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table2[this.labelPhoneText]));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox1.Add(this.table2);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.table2]));
			w10.Position = 3;
			// Container child vbox1.Gtk.Box+BoxChild
			this.vboxLastOrders = new global::Gtk.VBox();
			this.vboxLastOrders.Name = "vboxLastOrders";
			this.vboxLastOrders.Spacing = 6;
			// Container child vboxLastOrders.Gtk.Box+BoxChild
			this.labelLastOrders = new global::Gtk.Label();
			this.labelLastOrders.Name = "labelLastOrders";
			this.labelLastOrders.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Последние заказы:</b>");
			this.labelLastOrders.UseMarkup = true;
			this.vboxLastOrders.Add(this.labelLastOrders);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vboxLastOrders[this.labelLastOrders]));
			w11.Position = 0;
			w11.Expand = false;
			w11.Fill = false;
			// Container child vboxLastOrders.Gtk.Box+BoxChild
			this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
			this.GtkScrolledWindow1.VscrollbarPolicy = ((global::Gtk.PolicyType)(2));
			this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
			this.ytreeLastOrders = new global::Gamma.GtkWidgets.yTreeView();
			this.ytreeLastOrders.TooltipMarkup = "tooltip\nnot tooltip";
			this.ytreeLastOrders.CanFocus = true;
			this.ytreeLastOrders.Name = "ytreeLastOrders";
			this.ytreeLastOrders.HeadersVisible = false;
			this.ytreeLastOrders.HoverSelection = true;
			this.GtkScrolledWindow1.Add(this.ytreeLastOrders);
			this.vboxLastOrders.Add(this.GtkScrolledWindow1);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vboxLastOrders[this.GtkScrolledWindow1]));
			w13.Position = 1;
			this.vbox1.Add(this.vboxLastOrders);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.vboxLastOrders]));
			w14.Position = 4;
			// Container child vbox1.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Комментарий:</b>");
			this.label3.UseMarkup = true;
			this.vbox1.Add(this.label3);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.label3]));
			w15.Position = 5;
			w15.Expand = false;
			w15.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.VscrollbarPolicy = ((global::Gtk.PolicyType)(2));
			this.GtkScrolledWindow.HscrollbarPolicy = ((global::Gtk.PolicyType)(2));
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.textviewComment = new global::Gtk.TextView();
			this.textviewComment.CanFocus = true;
			this.textviewComment.Name = "textviewComment";
			this.textviewComment.WrapMode = ((global::Gtk.WrapMode)(3));
			this.GtkScrolledWindow.Add(this.textviewComment);
			this.vbox1.Add(this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.GtkScrolledWindow]));
			w17.Position = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.buttonSaveComment = new global::Gtk.Button();
			this.buttonSaveComment.CanFocus = true;
			this.buttonSaveComment.Name = "buttonSaveComment";
			this.buttonSaveComment.UseUnderline = true;
			this.buttonSaveComment.Label = global::Mono.Unix.Catalog.GetString("Сохранить комментарий");
			global::Gtk.Image w18 = new global::Gtk.Image();
			w18.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-floppy", global::Gtk.IconSize.Menu);
			this.buttonSaveComment.Image = w18;
			this.hbox1.Add(this.buttonSaveComment);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.buttonSaveComment]));
			w19.Position = 0;
			w19.Expand = false;
			w19.Fill = false;
			this.vbox1.Add(this.hbox1);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
			w20.Position = 7;
			w20.Expand = false;
			w20.Fill = false;
			this.Add(this.vbox1);
			if((this.Child != null)) {
				this.Child.ShowAll();
			}
			this.Hide();
			this.buttonSaveComment.Clicked += new global::System.EventHandler(this.OnButtonSaveCommentClicked);
		}
	}
}
