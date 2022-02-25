using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NorthWind.Sales.Controllers;
using NorthWind.Sales.Presenters;
using NorthWind.Sales.UseCases;
using NothWind.EFCore.Repositories;

namespace NothWind.Sales.IoC;
public static class DependencyContainer  //StarpU o IoC
{
  public static IServiceCollection AddNorthWindSalesServices(
    this IServiceCollection services,
    IConfiguration configuration,
    string connectionStringName)
  {
    services.AddRepositories(configuration, connectionStringName)
      .AddUseCasesServices()
      .AddPresenter()
      .AddNorthWindSalesControllers();

    return services;
  }
}
