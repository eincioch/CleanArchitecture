

namespace NorthWind.Sales.UseCases.CreateOrder;
public class CreateOrderInteractor : ICreateOrderInputPort
{
  readonly ICreateOrderOutputPort _OutputPort;
  readonly INorthWindSalesCommadsRepository _Repository;

  public CreateOrderInteractor(ICreateOrderOutputPort outputPort,
    INorthWindSalesCommadsRepository repository)
  {
    _OutputPort = outputPort;
    _Repository = repository;
  }

  public async ValueTask Handle(CreateOrderDTO orderDTO)
  {
    OrderAggregate Order = new OrderAggregate
    {
      CustomerId = orderDTO.CustomerId,
      ShipAddress = orderDTO.ShipAddress,
      ShipCity = orderDTO.ShipCity,
      ShipCountry = orderDTO.ShipCountry,
      ShipPostalCode = orderDTO.ShipPostalCode,

    };

    foreach (var item in orderDTO.OrderDetails)
    {
      Order.AddDetail(item.ProductId, item.UnitPrice, item.Quantity);

    }

    await _Repository.CreateOrder(Order);
    await _Repository.SaveChanges();
    await _OutputPort.Handle(Order.Id);
  }
}
