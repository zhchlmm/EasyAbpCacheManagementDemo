using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace EasyAbp.CacheManagementDemo.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class CacheManagementDemoMigrationsDbContextFactory : IDesignTimeDbContextFactory<CacheManagementDemoMigrationsDbContext>
    {
        public CacheManagementDemoMigrationsDbContext CreateDbContext(string[] args)
        {
            CacheManagementDemoEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<CacheManagementDemoMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new CacheManagementDemoMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
