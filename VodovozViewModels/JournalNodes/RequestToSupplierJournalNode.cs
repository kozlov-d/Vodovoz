﻿using System;
using QS.Project.Journal;
using Vodovoz.Domain.Suppliers;

namespace Vodovoz.JournalNodes
{
	public class RequestToSupplierJournalNode : JournalEntityNodeBase<RequestToSupplier>
	{
		public string Name { get; set; }
		public DateTime Created { get; set; }
		public string Author { get; set; }
	}
}