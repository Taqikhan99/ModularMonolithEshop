using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering
{
    public static class OrderingModule
    {
        public static IServiceCollection AddOrderingModule(this IServiceCollection services, IConfiguration configuration)
        {
            // Register services, repositories, etc. related to the Ordering module here.
            // Example:
            // services.AddScoped<IOrderingService, OrderingService>();
            // services.AddScoped<IOrderingRepository, OrderingRepository>();
            return services;
        }

        //for the pipeline
        public static IApplicationBuilder UseOrderingModule(this IApplicationBuilder app)
        {
            // Configure middleware, endpoints, etc. related to the Ordering module here.
            return app;
        }
    }
}
