
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz.ReportsParameters.Logistic
{
	public partial class ScheduleOnLinePerShiftReport
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Label label1;

		private global::QS.Widgets.GtkUI.DateRangePicker dateperiodpicker;

		private global::Vodovoz.ViewWidgets.GeographicGroupsToStringWidget geographicGroup;

		private global::Gtk.HBox hbox4;

		private global::Gtk.Label label2;

		private global::Gamma.Widgets.yEnumComboBox yEnumCmbTransport;

		private global::Gamma.GtkWidgets.yCheckButton ycheckRaskat;

		private global::Gtk.CheckButton chkDetailed;

		private global::Gtk.Button buttonCreateReport;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Vodovoz.ReportsParameters.Logistic.ScheduleOnLinePerShiftReport
			global::Stetic.BinContainer.Attach(this);
			this.Name = "Vodovoz.ReportsParameters.Logistic.ScheduleOnLinePerShiftReport";
			// Container child Vodovoz.ReportsParameters.Logistic.ScheduleOnLinePerShiftReport.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Дата:");
			this.hbox1.Add(this.label1);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.label1]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.dateperiodpicker = new global::QS.Widgets.GtkUI.DateRangePicker();
			this.dateperiodpicker.Events = ((global::Gdk.EventMask)(256));
			this.dateperiodpicker.Name = "dateperiodpicker";
			this.dateperiodpicker.StartDate = new global::System.DateTime(0);
			this.dateperiodpicker.EndDate = new global::System.DateTime(0);
			this.hbox1.Add(this.dateperiodpicker);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.dateperiodpicker]));
			w2.Position = 1;
			this.vbox1.Add(this.hbox1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.geographicGroup = new global::Vodovoz.ViewWidgets.GeographicGroupsToStringWidget();
			this.geographicGroup.Events = ((global::Gdk.EventMask)(256));
			this.geographicGroup.Name = "geographicGroup";
			this.geographicGroup.Label = "";
			this.vbox1.Add(this.geographicGroup);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.geographicGroup]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Тип ТС:");
			this.hbox4.Add(this.label2);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.label2]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.yEnumCmbTransport = new global::Gamma.Widgets.yEnumComboBox();
			this.yEnumCmbTransport.Name = "yEnumCmbTransport";
			this.yEnumCmbTransport.ShowSpecialStateAll = true;
			this.yEnumCmbTransport.ShowSpecialStateNot = false;
			this.yEnumCmbTransport.UseShortTitle = false;
			this.yEnumCmbTransport.DefaultFirst = false;
			this.hbox4.Add(this.yEnumCmbTransport);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.yEnumCmbTransport]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.ycheckRaskat = new global::Gamma.GtkWidgets.yCheckButton();
			this.ycheckRaskat.CanFocus = true;
			this.ycheckRaskat.Name = "ycheckRaskat";
			this.ycheckRaskat.Label = global::Mono.Unix.Catalog.GetString("Раскат:");
			this.ycheckRaskat.DrawIndicator = true;
			this.ycheckRaskat.UseUnderline = true;
			this.hbox4.Add(this.ycheckRaskat);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.ycheckRaskat]));
			w7.Position = 2;
			w7.Expand = false;
			w7.Fill = false;
			this.vbox1.Add(this.hbox4);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox4]));
			w8.Position = 2;
			w8.Expand = false;
			w8.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.chkDetailed = new global::Gtk.CheckButton();
			this.chkDetailed.CanFocus = true;
			this.chkDetailed.Name = "chkDetailed";
			this.chkDetailed.Label = global::Mono.Unix.Catalog.GetString("Подробный отчёт");
			this.chkDetailed.DrawIndicator = true;
			this.chkDetailed.UseUnderline = true;
			this.vbox1.Add(this.chkDetailed);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.chkDetailed]));
			w9.Position = 3;
			w9.Expand = false;
			w9.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.buttonCreateReport = new global::Gtk.Button();
			this.buttonCreateReport.CanFocus = true;
			this.buttonCreateReport.Name = "buttonCreateReport";
			this.buttonCreateReport.UseUnderline = true;
			this.buttonCreateReport.Label = global::Mono.Unix.Catalog.GetString("Сформировать отчет");
			this.vbox1.Add(this.buttonCreateReport);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.buttonCreateReport]));
			w10.Position = 5;
			w10.Expand = false;
			w10.Fill = false;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}