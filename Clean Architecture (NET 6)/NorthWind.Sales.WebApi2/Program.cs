//var builder = WebApplication.CreateBuilder(args);
//var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

//app.Run();


using NorthWind.Sales.WebApi2;

WebApplication.CreateBuilder(args)
  .CreateWebApplication()
  .ConfigureWebApplication()
  .Run();
