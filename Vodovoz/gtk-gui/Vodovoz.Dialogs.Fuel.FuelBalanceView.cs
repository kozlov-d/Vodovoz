
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz.Dialogs.Fuel
{
	public partial class FuelBalanceView
	{
		private global::Gtk.VBox vboxFuelsBalances;

		private global::Gamma.GtkWidgets.yLabel labelAllFuelBalance;

		private global::Gtk.VBox vboxAllBalance;

		private global::Gamma.GtkWidgets.yLabel labelSubdivisionsFuelsBalance;

		private global::Gtk.VBox vboxSubdivisionsBalance;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Vodovoz.Dialogs.Fuel.FuelBalanceView
			global::Stetic.BinContainer.Attach(this);
			this.Name = "Vodovoz.Dialogs.Fuel.FuelBalanceView";
			// Container child Vodovoz.Dialogs.Fuel.FuelBalanceView.Gtk.Container+ContainerChild
			this.vboxFuelsBalances = new global::Gtk.VBox();
			this.vboxFuelsBalances.Name = "vboxFuelsBalances";
			this.vboxFuelsBalances.Spacing = 6;
			// Container child vboxFuelsBalances.Gtk.Box+BoxChild
			this.labelAllFuelBalance = new global::Gamma.GtkWidgets.yLabel();
			this.labelAllFuelBalance.Name = "labelAllFuelBalance";
			this.labelAllFuelBalance.Xalign = 0F;
			this.labelAllFuelBalance.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Общий баланс:</b>");
			this.labelAllFuelBalance.UseMarkup = true;
			this.vboxFuelsBalances.Add(this.labelAllFuelBalance);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vboxFuelsBalances[this.labelAllFuelBalance]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vboxFuelsBalances.Gtk.Box+BoxChild
			this.vboxAllBalance = new global::Gtk.VBox();
			this.vboxAllBalance.Name = "vboxAllBalance";
			this.vboxAllBalance.Spacing = 6;
			this.vboxFuelsBalances.Add(this.vboxAllBalance);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vboxFuelsBalances[this.vboxAllBalance]));
			w2.Position = 1;
			// Container child vboxFuelsBalances.Gtk.Box+BoxChild
			this.labelSubdivisionsFuelsBalance = new global::Gamma.GtkWidgets.yLabel();
			this.labelSubdivisionsFuelsBalance.Name = "labelSubdivisionsFuelsBalance";
			this.labelSubdivisionsFuelsBalance.Xalign = 0F;
			this.labelSubdivisionsFuelsBalance.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Баланс по кассам:</b>");
			this.labelSubdivisionsFuelsBalance.UseMarkup = true;
			this.vboxFuelsBalances.Add(this.labelSubdivisionsFuelsBalance);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vboxFuelsBalances[this.labelSubdivisionsFuelsBalance]));
			w3.Position = 2;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vboxFuelsBalances.Gtk.Box+BoxChild
			this.vboxSubdivisionsBalance = new global::Gtk.VBox();
			this.vboxSubdivisionsBalance.Name = "vboxSubdivisionsBalance";
			this.vboxSubdivisionsBalance.Spacing = 6;
			this.vboxFuelsBalances.Add(this.vboxSubdivisionsBalance);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vboxFuelsBalances[this.vboxSubdivisionsBalance]));
			w4.Position = 3;
			this.Add(this.vboxFuelsBalances);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}
