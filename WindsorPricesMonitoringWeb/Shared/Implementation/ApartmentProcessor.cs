using WindsorPricesMonitoringWeb.Shared.Abstractions;
using WindsorPricesMonitoringWeb.Shared.Model;

namespace WindsorPricesMonitoringWeb.Shared.Implementation;

public class ApartmentProcessor : IApartmentProcessor
{
	private readonly IApartmentRepository _apartmentRepository;

	public ApartmentProcessor(IApartmentRepository apartmentRepository)
	{
		_apartmentRepository = apartmentRepository;
	}

	public IEnumerable<PriceOnDay> GetPricesByApartmentType(string apartmentType)
	{
		return _apartmentRepository.GetPricesByApartmentType(apartmentType);
	}
}
