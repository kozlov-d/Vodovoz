﻿using System.Collections.Generic;
using Google.OrTools.ConstraintSolver;
using Vodovoz.Domain.Logistic;
using System.Linq;

namespace Vodovoz.Additions.Logistic.RouteOptimization
{
	public class CallbackDistanceDistrict : NodeEvaluator2
	{
		static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
		private CalculatedOrder[] Nodes;
		AtWorkDriver Driver;
		Dictionary<LogisticsArea, int> priorites;

		public CallbackDistanceDistrict(CalculatedOrder[] nodes, AtWorkDriver driver)
		{
			Nodes = nodes;
			Driver = driver;
			priorites = driver.Employee.Districts.ToDictionary(x => x.District, x => x.Priority);
		}

		public override long Run(int first_index, int second_index)
		{
			if(first_index > Nodes.Length || second_index > Nodes.Length || first_index < 0 || second_index < 0)
			{
				logger.Error($"Get Distance {first_index} -> {second_index} out of orders ({Nodes.Length})");
				return 0;
			}

			if(first_index == second_index)
				return 0;

			if(second_index == 0)
				return (long)(DistanceCalculator.GetDistanceToBase(Nodes[first_index - 1].Order.DeliveryPoint) * 1000);

			long distance;
			var aria = Nodes[second_index - 1].District;
			if(!priorites.ContainsKey(aria))
				return 100000;

			if(first_index == 0)
				distance = (long)(DistanceCalculator.GetDistanceFromBase(Nodes[second_index - 1].Order.DeliveryPoint) * 1000);
			else
				distance = (long)(DistanceCalculator.GetDistance(Nodes[first_index - 1].Order.DeliveryPoint, Nodes[second_index - 1].Order.DeliveryPoint) * 1000);

			return distance + priorites[aria] * 1000 ; // приоритет = 1 км. Можно умножить на нужное количество км.
		}
	}
}
