using Microsoft.EntityFrameworkCore;

namespace WindsorPricesMonitoringWeb.Shared.Model.Database;

public class PricesContext: DbContext
{
	public PricesContext(DbContextOptions<PricesContext> options): base(options)
	{
	}

	public DbSet<LastUnitAvailability> LastUnitAvailability { get; set; }

	public DbSet<LastApartmentAvailability> LastApartmentAvailability { get; set; }

	public DbSet<ApartmentTypes> ApartmentTypes { get; set; }

	public DbSet<ApartmentTypeAvailability> ApartmentTypeAvailability { get; set; }
}
