using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using EasyAbp.CacheManagementDemo.Data;
using Volo.Abp.DependencyInjection;

namespace EasyAbp.CacheManagementDemo.EntityFrameworkCore
{
    public class EntityFrameworkCoreCacheManagementDemoDbSchemaMigrator
        : ICacheManagementDemoDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreCacheManagementDemoDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the CacheManagementDemoMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<CacheManagementDemoMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}