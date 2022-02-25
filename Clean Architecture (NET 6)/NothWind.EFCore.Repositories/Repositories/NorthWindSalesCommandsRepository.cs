using NorthWind.Sales.BusinessObjects.Aggregates;
using NorthWind.Sales.BusinessObjects.Interfaces.Repositories;
using NothWind.EFCore.Repositories.DataContexts;

namespace NothWind.EFCore.Repositories.Repositories;
public class NorthWindSalesCommandsRepository :
  INorthWindSalesCommadsRepository
{
  readonly NorthWindSalesContext Context;

  public NorthWindSalesCommandsRepository(NorthWindSalesContext context)
  {
    Context = context;
  }

  public async ValueTask CreateOrder(OrderAggregate order)
  {
    await Context.AddAsync(order);
    foreach (var Item in order.OrderDetails)
    {
      await Context.AddAsync(new OrderDetail
      {
        Order = order,
        ProductId = Item.ProductId,
        Quantity = Item.Quantity,
        UnitPrice = Item.UnitPrice,

      }

        );
    }
  }

  public async ValueTask SaveChanges()
  {
    await Context.SaveChangesAsync();
  }
}
