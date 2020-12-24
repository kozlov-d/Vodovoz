﻿using System;
using Vodovoz.Services;
using System.ServiceModel.Dispatcher;
using System.ServiceModel;
using System.ServiceModel.Channels;
using Vodovoz.EntityRepositories.Orders;

namespace VodovozSalesReceiptsService
{
	public class SalesReceiptsInstanceProvider : IInstanceProvider
	{
		private readonly ISalesReceiptsServiceSettings salesReceiptsServiceSettings;
		private readonly IOrderRepository orderRepository;
		private readonly IOrderPrametersProvider orderPrametersProvider;
		private readonly IOrganizationParametersProvider organizationParametersProvider;

		public SalesReceiptsInstanceProvider(
			ISalesReceiptsServiceSettings salesReceiptsServiceSettings,
			IOrderRepository orderRepository,
			IOrderPrametersProvider orderPrametersProvider,
			IOrganizationParametersProvider organizationParametersProvider
			)
		{
			this.salesReceiptsServiceSettings = salesReceiptsServiceSettings ?? throw new ArgumentNullException(nameof(salesReceiptsServiceSettings));
			this.orderRepository = orderRepository ?? throw new ArgumentNullException(nameof(orderRepository));
			this.orderPrametersProvider = orderPrametersProvider ?? throw new ArgumentNullException(nameof(orderPrametersProvider));
			this.organizationParametersProvider = organizationParametersProvider ?? throw new ArgumentNullException(nameof(organizationParametersProvider));
		}

		#region IInstanceProvider implementation

		public object GetInstance(InstanceContext instanceContext)
		{
			return new SalesReceiptsService(salesReceiptsServiceSettings, orderRepository, orderPrametersProvider, organizationParametersProvider);
		}

		public object GetInstance(InstanceContext instanceContext, Message message)
		{
			return GetInstance(instanceContext);
		}

		public void ReleaseInstance(InstanceContext instanceContext, object instance)
		{
		}

		#endregion IInstanceProvider implementation
	}
}
