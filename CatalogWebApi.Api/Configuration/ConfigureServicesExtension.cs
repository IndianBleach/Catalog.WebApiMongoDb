using CatalogWebApi.Core.Interfaces;
using CatalogWebApi.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogWebApi.Api.Configuration
{
    public static class ConfigureServicesExtension
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddSingleton(typeof(ICatalogRepository), typeof(MongoDbCatalogRepository));


            //services.AddSingleton(typeof(ICatalogRepository), typeof(CatalogRepository));
        }
    }
}
