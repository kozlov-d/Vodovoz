﻿using QSOrmProject;
using System.Collections.Generic;
using Vodovoz.Domain.Service;
using Vodovoz.Domain;
using NHibernate;
using NHibernate.Criterion;

namespace Vodovoz.Repository
{
	public static class ServiceClaimRepository
	{
		public static IList<ServiceClaim> GetServiceClaimForOrder (IUnitOfWork uow, Vodovoz.Domain.Orders.Order order)
		{
			ServiceClaim serviceClaimAlias = null;
			Vodovoz.Domain.Orders.Order initialOrderAlias = null, finalOrderAlias = null;

			var queryOver = uow.Session.QueryOver<ServiceClaim> (() => serviceClaimAlias)
				.JoinAlias (s => s.InitialOrder, () => initialOrderAlias, NHibernate.SqlCommand.JoinType.LeftOuterJoin)
				.JoinAlias (s => s.FinalOrder, () => finalOrderAlias, NHibernate.SqlCommand.JoinType.LeftOuterJoin)
			.Where (s => initialOrderAlias.Id == order.Id || finalOrderAlias.Id == order.Id);
			return queryOver.List<ServiceClaim> ();
		}

		public static QueryOver<ServiceClaim> GetDoneClaimsForClient (Vodovoz.Domain.Orders.Order order)
		{
			ServiceClaim serviceClaimAlias = null;
			Counterparty counterpartyAlias = null;

			var queryOver = QueryOver.Of<ServiceClaim> (() => serviceClaimAlias)
				.JoinAlias (s => s.Counterparty, () => counterpartyAlias)
				.Where (s => counterpartyAlias.Id == order.Client.Id &&
			                s.Status == ServiceClaimStatus.Ready &&
			                s.FinalOrder == null &&
			                s.Payment == order.PaymentType);
			return queryOver;
		}
	}
}