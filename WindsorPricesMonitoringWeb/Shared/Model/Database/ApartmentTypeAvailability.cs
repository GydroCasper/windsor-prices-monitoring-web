using System.ComponentModel.DataAnnotations;

namespace WindsorPricesMonitoringWeb.Shared.Model.Database;

public class ApartmentTypeAvailability
{
	[Key]
	public Guid Id { get; set; }

	public Guid TypeId { get; set; }

	public DateTime Date { get; set; }

	public byte Available { get; set; }

	public short? MinimumPrice { get; set; }
}
