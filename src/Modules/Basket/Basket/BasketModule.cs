using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basket
{
    public static class BasketModule
    {
        public static IServiceCollection AddBasketModule(this IServiceCollection services, IConfiguration configuration)
        {
            // Register services, repositories, etc. related to the Basket module here.
            // Example:
            // services.AddScoped<IBasketService, BasketService>();
            // services.AddScoped<IBasketRepository, BasketRepository>();
            return services;
        }
    }
}
