using System.Collections.Generic;
using WindsorPricesMonitoringWeb.Shared;
using WindsorPricesMonitoringWeb.Shared.Abstractions;

namespace WindsorPricesMonitoringWeb.Shared.Implementation;

public class UnitProcessor : IUnitProcessor
{
	private readonly IUnitRepository _unitRepository;

	public UnitProcessor(IUnitRepository unitRepository)
	{
		_unitRepository = unitRepository;
	}

	public IEnumerable<Unit> GetAvailableUnits()
	{
		return _unitRepository.GetAvailableUnits();
	}
}
