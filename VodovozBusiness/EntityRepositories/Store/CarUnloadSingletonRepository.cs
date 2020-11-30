﻿using System;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Criterion;
using QS.DomainModel.UoW;
using Vodovoz.Domain.Documents;
using Vodovoz.Domain.Logistic;
using Vodovoz.Domain.Operations;
using Vodovoz.Domain.Store;

namespace Vodovoz.Repository.Store
{
	public class CarUnloadSingletonRepository : ICarUnloadRepository
	{
		private static CarUnloadSingletonRepository instance;
		public static CarUnloadSingletonRepository GetInstance()
		{
			if(instance == null)
				instance = new CarUnloadSingletonRepository();
			return instance;
		}
		protected CarUnloadSingletonRepository() { }

		public Dictionary<int, decimal> NomenclatureUnloaded(IUnitOfWork UoW, RouteList routeList, Warehouse warehouse, CarUnloadDocument excludeDoc)
		{
			CarUnloadDocument docAlias = null;
			CarUnloadDocumentItem docItemsAlias = null;
			WarehouseMovementOperation movementOperationAlias = null;

			var unloadedlist = UoW.Session.QueryOver<CarUnloadDocument>(() => docAlias)
								  .Where(d => d.RouteList.Id == routeList.Id)
								  .Where(d => d.Warehouse.Id == warehouse.Id)
								  .Where(d => d.Id != excludeDoc.Id)
								  .JoinAlias(d => d.Items, () => docItemsAlias)
								  .JoinAlias(() => docItemsAlias.WarehouseMovementOperation, () => movementOperationAlias)
				.SelectList(list => list
							.SelectGroup(() => movementOperationAlias.Nomenclature.Id)
							.SelectSum(() => movementOperationAlias.Amount)
						   ).List<object[]>();
			return unloadedlist.ToDictionary(r => (int)r[0], r => (decimal)r[1]);
		}

		public bool IsUniqueDocumentAtDay(IUnitOfWork UoW, RouteList routeList, Warehouse warehouse,int documentId)
		{
			if(documentId != 0)
				return true;

			var start = DateTime.Now.Date;
			var end = DateTime.Now.Date.AddHours(23).AddMinutes(59).AddSeconds(59).AddMilliseconds(59).AddTicks(59);

			CarUnloadDocument carUnloadDocument = null;
			var getSimilarCarUnloadDoc = QueryOver.Of<CarUnloadDocument>(() => carUnloadDocument)
									.Where(() => carUnloadDocument.RouteList.Id == routeList.Id)
									.And(() => carUnloadDocument.Warehouse.Id == warehouse.Id)
									.And(() => start <= carUnloadDocument.TimeStamp)
									.And(() => carUnloadDocument.TimeStamp <= end);
			IList<CarUnloadDocument> documents = getSimilarCarUnloadDoc.GetExecutableQueryOver(UoW.Session)
				.List();

			if(documents.Count > 0)
				return false;
			else
				return true;
		}
	}
}
