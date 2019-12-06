﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Bindings.Collections.Generic;
using System.Linq;
using Gamma.Utilities;
using QS.DomainModel.Entity;
using QS.DomainModel.Entity.EntityPermissions;
using QS.HistoryLog;
using QS.Utilities.Text;

namespace Vodovoz.Domain.WageCalculation
{
	[
		Appellative(
			Gender = GrammaticalGender.Feminine,
			NominativePlural = "ставки по зарплатномым районам и уровням",
			Nominative = "ставка по зарплатномым районам и уровням"
		)
	]
	[HistoryTrace]
	[EntityPermission]
	public class WageDistrictLevelRates : PropertyChangedBase, IDomainObject, IValidatableObject
	{
		#region Свойства

		public virtual int Id { get; set; }

		string name;
		[Display(Name = "Название")]
		public virtual string Name {
			get => name;
			set => SetField(ref name, value);
		}

		IList<WageDistrictLevelRate> levelRates = new List<WageDistrictLevelRate>();
		[Display(Name = "Зарплатные ставки")]
		public virtual IList<WageDistrictLevelRate> LevelRates {
			get => levelRates;
			set => SetField(ref levelRates, value);
		}

		GenericObservableList<WageDistrictLevelRate> observableLevelRates;
		//FIXME Кослыль пока не разберемся как научить hibernate работать с обновляемыми списками.
		public virtual GenericObservableList<WageDistrictLevelRate> ObservableLevelRates {
			get {
				if(observableLevelRates == null)
					observableLevelRates = new GenericObservableList<WageDistrictLevelRate>(LevelRates);
				return observableLevelRates;
			}
		}

		bool isArchive;
		[Display(Name = "Архивный")]
		public virtual bool IsArchive {
			get => isArchive;
			set => SetField(ref isArchive, value);
		}

		bool isDefaultLevel;
		[Display(Name = "По умолчанию для новых сотрудников")]
		public virtual bool IsDefaultLevel {
			get => isDefaultLevel;
			set => SetField(ref isDefaultLevel, value);
		}

		#endregion Свойства

		#region Вычисляемые

		public virtual string Title => $"{GetType().GetSubjectName().StringToTitleCase()} №{Id} ({Name})";

		public virtual IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
		{
			if(string.IsNullOrWhiteSpace(Name))
				yield return new ValidationResult(
					"Укажите название ставки",
					new[] { this.GetPropertyName(o => o.Name) }
				);

			#region валидация ставок

			var allValidationResultsOfItems = LevelRates.SelectMany(x => x.Validate(validationContext));
			foreach(var result in allValidationResultsOfItems)
				yield return result;

			foreach(var item in LevelRates) {
				foreach(var result in item.Validate(validationContext))
					yield return result;
			}

			#endregion валидация ставок
		}

		#endregion Вычисляемые
	}
}
