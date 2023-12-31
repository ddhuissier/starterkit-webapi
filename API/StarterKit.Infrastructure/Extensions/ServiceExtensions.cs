﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using StarterKit.Infrastructure.Data;
using StarterKit.Infrastructure.Repositories;
using StarterKit.Domain.Interfaces.Repositories;
using StarterKit.Domain.Interfaces;

namespace StarterKit.Infrastructure.Extensions
{
    public static class ServiceExtensions
    {
         public static void AddApplicationInfrastructureServices(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddOptions();

            //Infrastructure
            var conStrStarterKitBuilder = new SqlConnectionStringBuilder(configuration.GetConnectionString("StarterKitConnection"));

            var connectionStarterKit = conStrStarterKitBuilder.ConnectionString;

            services.AddDbContext<StarterKitContext>(options =>
            {
                options.UseSqlServer(connectionStarterKit);
            });
 
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            #region Repositories
            services.AddTransient<IDataTranslationRepositoryAsync, DataTranslationRepositoryAsync>();
            services.AddTransient<IProductRepositoryAsync, ProductRepositoryAsync>();
            services.AddTransient<IUserRepositoryAsync, UserRepositoryAsync>();
            services.AddTransient<IGuitarRepositoryAsync, GuitarRepositoryAsync>();
            services.AddTransient<IOrderRepositoryAsync, OrderRepositoryAsync>();
            #endregion

        }
    }
}
