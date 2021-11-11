using System.ComponentModel.DataAnnotations;

namespace WindsorPricesMonitoringWeb.Shared.Model.Database;

public class LastUnitAvailability
{
	[Key]
	public Guid Id { get; set; }

	public string FullNumber { get; set; }

	public DateTime Date { get; set; }

	public DateTime? DateAvailable { get; set; }

	public short? MinimumPrice { get; set; }

	public bool IsAvailable { get; set; }

	public byte BedsCount { get; set; }

	public byte BuildingNumber { get; set; }

	public short UnitNumber { get; set; }

	public string ApartmentType { get; set; }
}
