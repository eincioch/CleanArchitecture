

namespace NorthWind.Sales.Presenters;
public static class DependencyContainer  //StarpU o IoC
{
  public static IServiceCollection AddPresenter(
    this IServiceCollection services)
  {
    //quiero registrar order Presenter
    services.AddScoped<CreateOrderPresenter>();

    services.AddScoped<ICreateOrderPresenter>(
      provider => provider.GetService<CreateOrderPresenter>()
      );

    services.AddScoped<ICreateOrderOutputPort>(
      provider => provider.GetService<CreateOrderPresenter>()
      );

    // -- revisa Enrique (cosa de locos)
    //services.AddScoped<ICreateOrderPresenter,
    //  CreateOrderPresenter>();


    //services.AddScoped<ICreateOrderOutputPort,
    //CreateOrderPresenter>();

    return services;
  }
}
