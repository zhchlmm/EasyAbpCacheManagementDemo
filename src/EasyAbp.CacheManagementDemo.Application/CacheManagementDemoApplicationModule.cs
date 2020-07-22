using EasyAbp.CacheManagement;
using Volo.Abp.Account;
using Volo.Abp.AutoMapper;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.TenantManagement;
using Volo.Blogging;
using Volo.Blogging.Admin;

namespace EasyAbp.CacheManagementDemo
{
    [DependsOn(
        typeof(CacheManagementDemoDomainModule),
        typeof(AbpAccountApplicationModule),
        typeof(CacheManagementDemoApplicationContractsModule),
        typeof(AbpIdentityApplicationModule),
        typeof(AbpPermissionManagementApplicationModule),
        typeof(AbpTenantManagementApplicationModule),
        typeof(CacheManagementApplicationModule),
        typeof(AbpFeatureManagementApplicationModule)
        )]
    [DependsOn(typeof(BloggingApplicationModule))]
    [DependsOn(typeof(BloggingAdminApplicationModule))]
    public class CacheManagementDemoApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<CacheManagementDemoApplicationModule>();
            });
        }
    }
}
