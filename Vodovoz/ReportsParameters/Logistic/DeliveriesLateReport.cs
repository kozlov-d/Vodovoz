﻿using System;
using System.Collections.Generic;
using QS.Report;
using QSProjectsLib;
using QSReport;

namespace Vodovoz.Reports.Logistic
{
	public partial class DeliveriesLateReport : Gtk.Bin, IParametersWidget
	{
		public DeliveriesLateReport ()
		{
			this.Build ();
		}

		#region IParametersWidget implementation

		public event EventHandler<LoadReportEventArgs> LoadReport;

		public string Title {
			get {
				return "Отчет по опозданиям";
			}
		}

		#endregion

		void OnUpdate (bool hide = false)
		{
			if (LoadReport != null) {
				LoadReport (this, new LoadReportEventArgs (GetReportInfo (), hide));
			}
		}

		private ReportInfo GetReportInfo ()
		{
			return new ReportInfo {
				Identifier = "Logistic.DeliveriesLate",
				Parameters = new Dictionary<string, object>
				{
					{ "start_date", dateperiodpicker.StartDate },
					{ "end_date", dateperiodpicker.EndDate.AddHours(3) },
                    { "is_driver_sort", ychkDriverSort.Active }
                }
			};
		}

		protected void OnButtonCreateReportClicked (object sender, EventArgs e)
		{
			if (dateperiodpicker.StartDateOrNull == null) {
				MessageDialogWorks.RunErrorDialog ("Необходимо выбрать дату");
				return;
			}
			OnUpdate (true);
		}

	}
}
