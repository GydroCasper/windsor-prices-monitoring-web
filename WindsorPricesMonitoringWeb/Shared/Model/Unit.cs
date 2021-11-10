﻿namespace WindsorPricesMonitoringWeb.Shared
{
	public class Unit
	{
		public string FullNumber { get; set; }

		public DateTime Date { get; set; }

		public DateTime? DateAvailable { get; set; }

		public int? MinimumPrice { get; set; }
	}
}
