using Basket;
using Catalog;
using Ordering;

var builder = WebApplication.CreateBuilder(args);

//services will be added here

builder.Services.AddControllers();

//adding extension methods to register module services
builder.Services
    .AddCatalogModule(builder.Configuration)
    .AddBasketModule(builder.Configuration)
    .AddOrderingModule(builder.Configuration);

var app = builder.Build();

//Request pipeline will be configured here using middleware calls

app.Run();
