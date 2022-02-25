using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NorthWind.Sales.BusinessObjects.Interfaces.Repositories;
using NothWind.EFCore.Repositories.DataContexts;
using NothWind.EFCore.Repositories.Repositories;

namespace NothWind.EFCore.Repositories;
public static class DependencyContainer  //StarpU o IoC
{
  public static IServiceCollection AddRepositories(
    this IServiceCollection services,
    IConfiguration configuration,
    string connectionStringName)
  {
    services.AddDbContext<NorthWindSalesContext>(
      options =>
      options.UseSqlServer(
        configuration.GetConnectionString(
          connectionStringName)));

    services.AddScoped<INorthWindSalesCommadsRepository,
      NorthWindSalesCommandsRepository>();

    return services;
  }
}
