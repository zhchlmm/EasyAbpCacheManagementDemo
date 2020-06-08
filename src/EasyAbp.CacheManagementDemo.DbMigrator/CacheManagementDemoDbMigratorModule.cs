using EasyAbp.CacheManagementDemo.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace EasyAbp.CacheManagementDemo.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(CacheManagementDemoEntityFrameworkCoreDbMigrationsModule),
        typeof(CacheManagementDemoApplicationContractsModule)
        )]
    public class CacheManagementDemoDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
