
// This file has been generated by the GUI designer. Do not modify.
namespace Vodovoz.ServiceDialogs
{
	public partial class LoadFrom1cClientsAndDeliveryPoints
	{
		private global::Gtk.VBox vbox2;

		private global::Gtk.FileChooserButton filechooser;

		private global::Gtk.Button buttonLoad;

		private global::Gtk.ProgressBar progressbar;

		private global::Gtk.Button button1;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Vodovoz.ServiceDialogs.LoadFrom1cClientsAndDeliveryPoints
			global::Stetic.BinContainer.Attach(this);
			this.Name = "Vodovoz.ServiceDialogs.LoadFrom1cClientsAndDeliveryPoints";
			// Container child Vodovoz.ServiceDialogs.LoadFrom1cClientsAndDeliveryPoints.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.filechooser = new global::Gtk.FileChooserButton(global::Mono.Unix.Catalog.GetString("Выберите XML файл с данными из 1с"), ((global::Gtk.FileChooserAction)(0)));
			this.filechooser.Name = "filechooser";
			this.vbox2.Add(this.filechooser);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.filechooser]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.buttonLoad = new global::Gtk.Button();
			this.buttonLoad.CanFocus = true;
			this.buttonLoad.Name = "buttonLoad";
			this.buttonLoad.UseUnderline = true;
			this.buttonLoad.Label = global::Mono.Unix.Catalog.GetString("Load");
			this.vbox2.Add(this.buttonLoad);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.buttonLoad]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.progressbar = new global::Gtk.ProgressBar();
			this.progressbar.Name = "progressbar";
			this.vbox2.Add(this.progressbar);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.progressbar]));
			w3.Position = 2;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.button1 = new global::Gtk.Button();
			this.button1.CanFocus = true;
			this.button1.Name = "button1";
			this.button1.UseUnderline = true;
			this.button1.Label = global::Mono.Unix.Catalog.GetString("Save");
			this.vbox2.Add(this.button1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.button1]));
			w4.Position = 3;
			w4.Expand = false;
			w4.Fill = false;
			this.Add(this.vbox2);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
			this.filechooser.SelectionChanged += new global::System.EventHandler(this.OnFilechooserXMLSelectionChanged);
			this.buttonLoad.Clicked += new global::System.EventHandler(this.OnButtonLoadClicked);
			this.button1.Clicked += new global::System.EventHandler(this.OnButton1Clicked);
		}
	}
}
