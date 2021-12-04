using System.ComponentModel.DataAnnotations;

namespace WindsorPricesMonitoringWeb.Shared.Model.Database;

public class ApartmentTypes
{
	[Key]
	public Guid Id { get; set; }

	public string Name { get; set; }
}
