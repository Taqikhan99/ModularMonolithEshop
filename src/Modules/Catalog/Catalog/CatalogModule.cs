
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog
{
    public static class CatalogModule
    {

        public static IServiceCollection AddCatalogModule(this IServiceCollection services, IConfiguration configuration)
        {
            // Register services, repositories, etc. related to the Catalog module here.
            // Example:
            // services.AddScoped<ICatalogService, CatalogService>();
            // services.AddScoped<ICatalogRepository, CatalogRepository>();
            return services;
        }

        //for the pipeline
        public static IApplicationBuilder UseCatalogModule(this IApplicationBuilder app)
        {
            // Configure middleware, endpoints, etc. related to the Catalog module here.
            return app;
        }
    }
}
