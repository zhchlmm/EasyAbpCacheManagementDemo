using Volo.Abp.Modularity;

namespace EasyAbp.CacheManagementDemo
{
    [DependsOn(
        typeof(CacheManagementDemoApplicationModule),
        typeof(CacheManagementDemoDomainTestModule)
        )]
    public class CacheManagementDemoApplicationTestModule : AbpModule
    {

    }
}