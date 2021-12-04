using WindsorPricesMonitoringWeb.Shared.Model;

namespace WindsorPricesMonitoringWeb.Shared.Abstractions;

public interface IApartmentRepository
{
	IEnumerable<PriceOnDay> GetPricesByApartmentType(string apartmentType);
}