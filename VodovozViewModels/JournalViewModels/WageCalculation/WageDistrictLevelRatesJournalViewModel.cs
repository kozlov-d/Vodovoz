﻿using System;
using NHibernate;
using NHibernate.Transform;
using QS.DomainModel.UoW;
using QS.Project.Domain;
using QS.Project.Journal;
using QS.Project.Journal.DataLoader;
using QS.Project.Journal.Search;
using QS.Project.Journal.Search.Criterion;
using QS.Services;
using Vodovoz.Domain.WageCalculation;
using Vodovoz.JournalNodes;
using Vodovoz.ViewModels.WageCalculation;

namespace Vodovoz.JournalViewModels.WageCalculation
{
	public class WageDistrictLevelRatesJournalViewModel : SingleEntityJournalViewModelBase<WageDistrictLevelRates, WageDistrictLevelRatesViewModel, WageDistrictLevelRatesJournalNode, CriterionSearchModel>
	{
		private readonly IUnitOfWorkFactory unitOfWorkFactory;

		public WageDistrictLevelRatesJournalViewModel(
			IUnitOfWorkFactory unitOfWorkFactory, 
			ICommonServices commonServices,
			SearchViewModelBase<CriterionSearchModel> searchViewModel) 
		: base(unitOfWorkFactory, commonServices, searchViewModel)
		{
			this.unitOfWorkFactory = unitOfWorkFactory ?? throw new ArgumentNullException(nameof(unitOfWorkFactory));
			TabName = "Журнал ставок по уровням";

			var threadLoader = DataLoader as ThreadDataLoader<WageDistrictLevelRatesJournalNode>;
			threadLoader.MergeInOrderBy(x => x.IsArchive, false);
			threadLoader.MergeInOrderBy(x => x.Name, false);

			UpdateOnChanges(typeof(WageDistrictLevelRates));
		}

		protected override Func<IUnitOfWork, IQueryOver<WageDistrictLevelRates>> ItemsSourceQueryFunction => (uow) => {
			WageDistrictLevelRatesJournalNode resultAlias = null;

			var query = uow.Session.QueryOver<WageDistrictLevelRates>();
			query.Where(CriterionSearchModel.ConfigureSearch()
				.AddSearchBy<WageDistrictLevelRates>(x => x.Id)
				.GetSearchCriterion()
			);

			var result = query.SelectList(list => list
									.Select(x => x.Id).WithAlias(() => resultAlias.Id)
									.Select(x => x.Name).WithAlias(() => resultAlias.Name)
									.Select(x => x.IsArchive).WithAlias(() => resultAlias.IsArchive)
									.Select(x => x.IsDefaultLevel).WithAlias(() => resultAlias.IsDefaultLevel)
								)
								.TransformUsing(Transformers.AliasToBean<WageDistrictLevelRatesJournalNode>())
								.OrderBy(x => x.Name).Asc
								.ThenBy(x => x.IsArchive).Asc
								;

			return result;
		};

		protected override Func<WageDistrictLevelRatesViewModel> CreateDialogFunction => () => new WageDistrictLevelRatesViewModel(
			this,
			EntityUoWBuilder.ForCreate(),
			unitOfWorkFactory,
			commonServices,
			UoW
	   );

		protected override Func<WageDistrictLevelRatesJournalNode, WageDistrictLevelRatesViewModel> OpenDialogFunction => n => new WageDistrictLevelRatesViewModel(
			this,
			EntityUoWBuilder.ForOpen(n.Id),
			unitOfWorkFactory,
			commonServices,
			UoW
	   );
	}
}
