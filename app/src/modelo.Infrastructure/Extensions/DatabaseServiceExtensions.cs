﻿using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using modelo.Infrastructure.DataProviders;
using Microsoft.EntityFrameworkCore;

namespace modelo.Infrastructure.Extensions
{
    public static class DatabaseServiceExtensions
    {
        public static void RegisterDatabases(this IServiceCollection services, IConfiguration configurations, IWebHostEnvironment environment)
        {
            try
            {
                if (environment.IsTesting()) return;

                var connectionString = environment.IsDevelopment() ? GetConnectionString(configurations) : GetLocalConnectionStringDocker(configurations);

                services.AddDbContextPool<DBContext>(options => options.UseMysqlServer(connectionString.ToString()));
            }
            catch (Exception)
            {
                throw;
            }
        }

        private static object GetConnectionString(IConfiguration configurations) => configurations.GetConnectionString("Local");

        private static object GetLocalConnectionStringDocker(IConfiguration configurations) => configurations.GetConnectionString("Docker");
    }
}
