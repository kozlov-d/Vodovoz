
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz.Filters.GtkViews
{
	public partial class DistrictJournalFilterView
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.HBox hbox1;

		private global::Gamma.GtkWidgets.yLabel ylabelSetStatus;

		private global::Gamma.Widgets.yEnumComboBox cmbDistrictsSetStatus;

		private global::Gamma.GtkWidgets.yCheckButton ycheckOnlyWithBorders;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Vodovoz.Filters.GtkViews.DistrictJournalFilterView
			global::Stetic.BinContainer.Attach(this);
			this.Name = "Vodovoz.Filters.GtkViews.DistrictJournalFilterView";
			// Container child Vodovoz.Filters.GtkViews.DistrictJournalFilterView.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.ylabelSetStatus = new global::Gamma.GtkWidgets.yLabel();
			this.ylabelSetStatus.Name = "ylabelSetStatus";
			this.ylabelSetStatus.LabelProp = global::Mono.Unix.Catalog.GetString("Статус версии районов:");
			this.hbox1.Add(this.ylabelSetStatus);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.ylabelSetStatus]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.cmbDistrictsSetStatus = new global::Gamma.Widgets.yEnumComboBox();
			this.cmbDistrictsSetStatus.Name = "cmbDistrictsSetStatus";
			this.cmbDistrictsSetStatus.ShowSpecialStateAll = false;
			this.cmbDistrictsSetStatus.ShowSpecialStateNot = false;
			this.cmbDistrictsSetStatus.UseShortTitle = false;
			this.cmbDistrictsSetStatus.DefaultFirst = false;
			this.hbox1.Add(this.cmbDistrictsSetStatus);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.cmbDistrictsSetStatus]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.ycheckOnlyWithBorders = new global::Gamma.GtkWidgets.yCheckButton();
			this.ycheckOnlyWithBorders.CanFocus = true;
			this.ycheckOnlyWithBorders.Name = "ycheckOnlyWithBorders";
			this.ycheckOnlyWithBorders.Label = global::Mono.Unix.Catalog.GetString("Только районы с границами");
			this.ycheckOnlyWithBorders.DrawIndicator = true;
			this.ycheckOnlyWithBorders.UseUnderline = true;
			this.hbox1.Add(this.ycheckOnlyWithBorders);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.ycheckOnlyWithBorders]));
			w3.Position = 2;
			w3.Expand = false;
			w3.Fill = false;
			this.vbox1.Add(this.hbox1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}
