using EasyAbp.CacheManagementDemo.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace EasyAbp.CacheManagementDemo
{
    [DependsOn(
        typeof(CacheManagementDemoEntityFrameworkCoreTestModule)
        )]
    public class CacheManagementDemoDomainTestModule : AbpModule
    {

    }
}