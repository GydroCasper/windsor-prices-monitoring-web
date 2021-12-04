using WindsorPricesMonitoringWeb.Shared.Abstractions;
using WindsorPricesMonitoringWeb.Shared.Model;
using WindsorPricesMonitoringWeb.Shared.Model.Database;

namespace WindsorPricesMonitoringWeb.Shared.Implementation;

public class ApartmentRepository : IApartmentRepository
{
	private readonly PricesContext _dbContext;

	public ApartmentRepository(PricesContext dbContext)
	{
		_dbContext = dbContext;
	}

	public IEnumerable<PriceOnDay> GetPricesByApartmentType(string apartmentType)
	{
		return from t in _dbContext.ApartmentTypes
			   join a in _dbContext.ApartmentTypeAvailability on t.Id equals a.TypeId
			   where t.Name == apartmentType
			   orderby a.Date
			   select new PriceOnDay
			   {
				   Price = a.MinimumPrice ?? 0,
				   Day = a.Date
			   };
	}
}
