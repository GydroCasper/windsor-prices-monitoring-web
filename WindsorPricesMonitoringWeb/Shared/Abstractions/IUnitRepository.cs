namespace WindsorPricesMonitoringWeb.Shared.Abstractions;

public interface IUnitRepository
{
	IEnumerable<Unit> GetAvailableUnits();
}