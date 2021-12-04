using WindsorPricesMonitoringWeb.Shared.Model;

namespace WindsorPricesMonitoringWeb.Shared.Abstractions;

public interface IApartmentProcessor
{
	IEnumerable<PriceOnDay> GetPricesByApartmentType(string apartmentType);
}
