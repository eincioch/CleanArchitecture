

namespace NorthWind.Sales.Controllers;
public static class DependencyContainer  //StarpU o IoC
{
  public static IServiceCollection AddNorthWindSalesControllers(
    this IServiceCollection services)
  {
    services.AddScoped<ICreateOrderController,
      CreateOrderController>();

    return services;
  }
}
