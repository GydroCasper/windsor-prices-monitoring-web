using WindsorPricesMonitoringWeb.Shared.Abstractions;
using WindsorPricesMonitoringWeb.Shared.Model.Database;

namespace WindsorPricesMonitoringWeb.Shared.Implementation;

public class UnitRepository : IUnitRepository
{
	private readonly PricesContext _dbContext;

	public UnitRepository(PricesContext dbContext)
	{
		_dbContext = dbContext;
	}

	public IEnumerable<Unit> GetAvailableUnits()
	{
		return _dbContext.LastUnitAvailability.Where(x => x.IsAvailable)
			.Select(x => new Unit
			{
				FullNumber = x.FullNumber,
				Date = x.Date,
				DateAvailable = x.DateAvailable,
				MinimumPrice = x.MinimumPrice,
				BedsCount = x.BedsCount,
				BuildingNumber = x.BuildingNumber,
				UnitNumber = x.UnitNumber,
				ApartmentType = x.ApartmentType
			})
			.OrderBy(x => x.FullNumber);
	}
}
