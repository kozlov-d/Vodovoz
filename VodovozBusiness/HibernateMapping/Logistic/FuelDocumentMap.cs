﻿using System;
using FluentNHibernate.Mapping;
using Vodovoz.Domain.Logistic;

namespace Vodovoz
{
	public class FuelDocumentMap: ClassMap<FuelDocument>
	{
		public FuelDocumentMap ()
		{
			Table ("fuel_documents");

			Id (x => x.Id).Column ("id").GeneratedBy.Native ();

			Map (x => x.Date)		 .Column ("date");
			Map (x => x.PayedForFuel).Column ("payed_for_fuel");
			Map (x => x.LiterCost)	 .Column ("liter_cost");

			References (x => x.Fuel)			.Column ("fuel_type_id");
			References (x => x.Driver)			.Column ("driver_id");
			References (x => x.Operation)		.Column ("fuel_operation_id").Cascade.All();
			References (x => x.FuelCashExpense)	.Column ("fuel_cash_expense_id").Cascade.All();

			HasMany(x => x.FuelTickets).KeyColumn("fuel_document_id").LazyLoad().Inverse().Cascade.AllDeleteOrphan();
		}
	}
}

