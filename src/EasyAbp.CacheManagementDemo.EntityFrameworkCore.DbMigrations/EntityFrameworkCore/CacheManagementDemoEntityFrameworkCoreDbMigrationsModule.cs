using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace EasyAbp.CacheManagementDemo.EntityFrameworkCore
{
    [DependsOn(
        typeof(CacheManagementDemoEntityFrameworkCoreModule)
        )]
    public class CacheManagementDemoEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<CacheManagementDemoMigrationsDbContext>();
        }
    }
}
