
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz.ReportsParameters.Payments
{
	public partial class PaymentsFromBankClientFinDepartmentReport
	{
		private global::Gtk.VBox vbox2;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Label label1;

		private global::QS.Widgets.GtkUI.DateRangePicker daterangepicker;

		private global::Gamma.GtkWidgets.yButton btnCreateReport;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Vodovoz.ReportsParameters.Payments.PaymentsFromBankClientFinDepartmentReport
			global::Stetic.BinContainer.Attach(this);
			this.Name = "Vodovoz.ReportsParameters.Payments.PaymentsFromBankClientFinDepartmentReport";
			// Container child Vodovoz.ReportsParameters.Payments.PaymentsFromBankClientFinDepartmentReport.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Дата платежа: ");
			this.hbox1.Add(this.label1);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.label1]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.daterangepicker = new global::QS.Widgets.GtkUI.DateRangePicker();
			this.daterangepicker.Events = ((global::Gdk.EventMask)(256));
			this.daterangepicker.Name = "daterangepicker";
			this.daterangepicker.StartDate = new global::System.DateTime(0);
			this.daterangepicker.EndDate = new global::System.DateTime(0);
			this.hbox1.Add(this.daterangepicker);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.daterangepicker]));
			w2.Position = 1;
			this.vbox2.Add(this.hbox1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox1]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.btnCreateReport = new global::Gamma.GtkWidgets.yButton();
			this.btnCreateReport.CanFocus = true;
			this.btnCreateReport.Name = "btnCreateReport";
			this.btnCreateReport.UseUnderline = true;
			this.btnCreateReport.Label = global::Mono.Unix.Catalog.GetString("Сформировать отчет");
			this.vbox2.Add(this.btnCreateReport);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.btnCreateReport]));
			w4.Position = 2;
			w4.Expand = false;
			w4.Fill = false;
			this.Add(this.vbox2);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}
