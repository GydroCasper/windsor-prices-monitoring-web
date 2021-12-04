using System.ComponentModel.DataAnnotations;

namespace WindsorPricesMonitoringWeb.Shared.Model.Database;

public class LastApartmentAvailability
{
	[Key]
	public Guid Id { get; set; }

	public string Type { get; set; }

	public DateTime Date { get; set; }

	public byte Available { get; set; }

	public short? MinimumPrice { get; set; }
}
