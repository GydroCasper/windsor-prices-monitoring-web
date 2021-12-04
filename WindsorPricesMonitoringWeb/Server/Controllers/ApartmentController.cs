using Microsoft.AspNetCore.Mvc;
using WindsorPricesMonitoringWeb.Shared.Abstractions;
using WindsorPricesMonitoringWeb.Shared.Model;

namespace WindsorPricesMonitoringWeb.Server.Controllers;

[ApiController]
[Route("[controller]")]
public class ApartmentController : Controller
{
	private readonly IApartmentProcessor _priceProcessor;

	public ApartmentController(IApartmentProcessor priceProcessor)
	{
		_priceProcessor = priceProcessor;
	}

	[HttpGet]
	[Route("type/{apartmentType}")]
	public PriceOnDay[] GetByApartmentType(string apartmentType)
	{
		return _priceProcessor.GetPricesByApartmentType(apartmentType).ToArray();
	}
}
