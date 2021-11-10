namespace WindsorPricesMonitoringWeb.Shared.Abstractions;

public interface IUnitProcessor
{
	IEnumerable<Unit> GetAvailableUnits();
}