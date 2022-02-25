namespace NorthWind.Sales.WebApi;

public static class WebApplicationHelper
{
  public static WebApplication CreateWebApplication(
    this WebApplication builder
    )
  {
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    return builder.Builder();
  }
}
