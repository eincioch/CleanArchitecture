﻿namespace NorthWind.Sales.WebApi2;

public static class Endpoints
{
  public static WebApplication UseNorthWindSalesEndpoint(
    this WebApplication app
    )
  {
    app.MapPost("/create",
      async (CreateOrderDTO order,
      ICreateOrderController controller) =>
      Results.Ok(await controller.CreateOrder(order)));

    return app;
  }
}
