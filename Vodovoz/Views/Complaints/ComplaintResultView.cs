﻿using QS.Views.GtkUI;
using Vodovoz.ViewModels.Complaints;

namespace Vodovoz.Views.Complaints
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class ComplaintResultView : TabViewBase<ComplaintResultViewModel>
	{
		public ComplaintResultView(ComplaintResultViewModel viewModel) : base(viewModel)
		{
			this.Build();
			ConfigureDlg();
		}

		private void ConfigureDlg()
		{
			yentryName.Binding.AddBinding(ViewModel.Entity, e => e.Name, w => w.Text).InitializeFromSource();

			buttonSave.Clicked += (sender, e) => ViewModel.SaveAndClose();
			buttonCancel.Clicked += (sender, e) => ViewModel.Close(false, QS.Navigation.CloseSource.Cancel);
		}
	}
}
