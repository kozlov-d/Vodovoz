﻿using System;
using System.Collections.Generic;
using Gtk;
using QS.Dialog.GtkUI;
using QS.DomainModel.UoW;
using QS.Project.Services;
using QSProjectsLib;
using Vodovoz.Parameters;
using Vodovoz.Tools.CommerceML;

namespace Vodovoz.Dialogs.OnlineStore
{
	public partial class ExportToSiteDlg : QS.Dialog.Gtk.TdiTabBase
	{
		public ExportToSiteDlg()
		{
			if(!ServicesConfig.CommonServices.CurrentPermissionService.ValidatePresetPermission("database_maintenance")) {
				MessageDialogHelper.RunWarningDialog("Доступ запрещён!", "У вас недостаточно прав для доступа к этой вкладке. Обратитесь к своему руководителю.", Gtk.ButtonsType.Ok);
				FailInitialize = true;
				return;
			}

			this.Build();
			TabName = "Экспорт интернет магазин";
			comboExportMode.ItemsEnum = typeof(ExportMode);
			if(ParametersProvider.Instance.ContainsParameter(Export.OnlineStoreUrlParameterName))
				entrySitePath.Text = ParametersProvider.Instance.GetParameterValue(Export.OnlineStoreUrlParameterName);
			if(ParametersProvider.Instance.ContainsParameter(Export.OnlineStoreLoginParameterName))
				entryUser.Text = ParametersProvider.Instance.GetParameterValue(Export.OnlineStoreLoginParameterName);
			if(ParametersProvider.Instance.ContainsParameter(Export.OnlineStorePasswordParameterName))
				entryPassword.Text = ParametersProvider.Instance.GetParameterValue(Export.OnlineStorePasswordParameterName);
			if(ParametersProvider.Instance.ContainsParameter(Export.OnlineStoreExportMode))
				comboExportMode.SelectedItem = Enum.Parse(typeof(ExportMode), ParametersProvider.Instance.GetParameterValue(Export.OnlineStoreExportMode));
		}

		protected void OnButtonRunToFileClicked(object sender, EventArgs e)
		{
			using(var uow = UnitOfWorkFactory.CreateWithoutRoot())
			{
				var fileChooser = new Gtk.FileChooserDialog("Выберите папку для сохранения выгрузки",
					(Window)this.Toplevel,
				                                            Gtk.FileChooserAction.SelectFolder,
					"Отмена", ResponseType.Cancel,
					"Выбрать", ResponseType.Accept
				);

				if(fileChooser.Run() == (int)ResponseType.Cancel)
				{
					fileChooser.Destroy();
					return;
				}

				var directory = fileChooser.Filename;
				fileChooser.Destroy();

				var export = new Export(uow);
				export.ProgressUpdated += Export_ProgressUpdated;

				export.RunToDirectory(directory);

				if(UpdateErrors(export.Errors))
					return;

                UpdateResults(export.Results);
                progressbarTotal.Text = "Готово";
				progressbarTotal.Adjustment.Value = progressbarTotal.Adjustment.Upper;
			}
		}

		protected void OnEntrySitePathFocusOutEvent(object o, FocusOutEventArgs args)
		{
			ParametersProvider.Instance.CreateOrUpdateParameter(Export.OnlineStoreUrlParameterName, entrySitePath.Text);
		}

		protected void OnEntryUserFocusOutEvent(object o, FocusOutEventArgs args)
		{
			ParametersProvider.Instance.CreateOrUpdateParameter(Export.OnlineStoreLoginParameterName, entryUser.Text);
		}

		protected void OnEntryPasswordFocusOutEvent(object o, FocusOutEventArgs args)
		{
			ParametersProvider.Instance.CreateOrUpdateParameter(Export.OnlineStorePasswordParameterName, entryPassword.Text);
		}

		protected void OnComboExportModeChangedByUser(object sender, EventArgs e)
		{
			ParametersProvider.Instance.CreateOrUpdateParameter(Export.OnlineStoreExportMode,  comboExportMode.SelectedItem.ToString());
		}

		protected void OnButtonExportToSiteClicked(object sender, EventArgs e)
		{
			using(var uow = UnitOfWorkFactory.CreateWithoutRoot()) {
				var export = new Export(uow);
				export.ProgressUpdated += Export_ProgressUpdated;

				export.RunToSite();

				if(UpdateErrors(export.Errors))
					return;

                UpdateResults(export.Results);
				progressbarTotal.Text = "Готово";
				progressbarTotal.Adjustment.Value = progressbarTotal.Adjustment.Upper;
			}
		}

		void Export_ProgressUpdated(object sender, EventArgs e)
		{
			var export = sender as Export;
			progressbarTotal.Text = export.CurrentTaskText + export.CurrentStepText;
			progressbarTotal.Adjustment.Upper = export.TotalTasks;
			progressbarTotal.Adjustment.Value = export.CurrentTask;
            UpdateErrors(export.Errors);
			QSMain.WaitRedraw();
		}

		/// <summary>
		/// Если метод вернул true, это значит что есть ошибки.
		/// </summary>
		private bool UpdateErrors(List<string> errors)
		{
			GtkScrolledWindowErrors.Visible = errors.Count > 0;
			if(errors.Count > 0) {
				TextTagTable textTags = new TextTagTable();
				var tag = new TextTag("Red");
				tag.Foreground = "red";
				textTags.Add(tag);
				TextBuffer tempBuffer = new TextBuffer(textTags);
				TextIter iter = tempBuffer.EndIter;
				tempBuffer.InsertWithTags(ref iter, String.Join("\n", errors), tag);
				textviewErrors.Buffer = tempBuffer;
				return true;
			}
			return false;
		}

		private void UpdateResults(List<string> results)
        {
            GtkScrolledWindowErrors.Visible = true;
            TextTagTable textResultTags = new TextTagTable();
            var tagResult = new TextTag("blue");
            tagResult.Foreground = "blue";
            textResultTags.Add(tagResult);
            TextBuffer tempBuffer = new TextBuffer(textResultTags);
            TextIter iter = tempBuffer.EndIter;
            tempBuffer.InsertWithTags(ref iter, String.Join("\n", results), tagResult);
            textviewErrors.Buffer = tempBuffer;
        }

	}
}
