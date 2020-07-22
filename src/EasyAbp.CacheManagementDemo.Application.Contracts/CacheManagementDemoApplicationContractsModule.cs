using EasyAbp.CacheManagement;
using Volo.Abp.Account;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.ObjectExtending;
using Volo.Abp.PermissionManagement;
using Volo.Abp.TenantManagement;
using Volo.Blogging;
using Volo.Blogging.Admin;

namespace EasyAbp.CacheManagementDemo
{
    [DependsOn(
        typeof(CacheManagementDemoDomainSharedModule),
        typeof(AbpAccountApplicationContractsModule),
        typeof(AbpFeatureManagementApplicationContractsModule),
        typeof(AbpIdentityApplicationContractsModule),
        typeof(AbpPermissionManagementApplicationContractsModule),
        typeof(CacheManagementApplicationContractsModule),
        typeof(AbpTenantManagementApplicationContractsModule),
        typeof(AbpObjectExtendingModule)
    )]
    [DependsOn(typeof(BloggingApplicationContractsModule))]
    [DependsOn(typeof(BloggingAdminApplicationContractsModule))]
    public class CacheManagementDemoApplicationContractsModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            CacheManagementDemoDtoExtensions.Configure();
        }
    }
}
