

namespace NorthWind.Sales.UseCases;
public static class DependencyContainer  //StarpU o IoC
{
  public static IServiceCollection AddUseCasesServices(
    this IServiceCollection services)
  {
    services.AddScoped<ICreateOrderInputPort,
      CreateOrderInteractor>();

    return services;
  }
}
