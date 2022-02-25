

namespace NorthWind.Sales.BusinessObjects.Interfaces.Repositories;
public interface INorthWindSalesCommadsRepository : IUnitOfWork
{
  ValueTask CreateOrder(OrderAggregate order);

}
