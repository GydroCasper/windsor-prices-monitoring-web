using Microsoft.AspNetCore.Mvc;
using WindsorPricesMonitoringWeb.Shared;
using WindsorPricesMonitoringWeb.Shared.Abstractions;

namespace WindsorPricesMonitoringWeb.Server.Controllers;

[ApiController]
[Route("[controller]")]
public class UnitController : ControllerBase
{
	private readonly IUnitProcessor _unitProcessor;

	public UnitController(IUnitProcessor unitProcessor)
	{
		_unitProcessor = unitProcessor;
	}

	[HttpGet]
	public IEnumerable<Unit> Get()
	{
		return _unitProcessor.GetAvailableUnits();
	}
}
