using EasyAbp.CacheManagement;
using Volo.Abp.Account;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement.HttpApi;
using Volo.Abp.TenantManagement;
using Volo.Blogging;
using Volo.Blogging.Admin;

namespace EasyAbp.CacheManagementDemo
{
    [DependsOn(
        typeof(CacheManagementDemoApplicationContractsModule),
        typeof(AbpAccountHttpApiModule),
        typeof(AbpIdentityHttpApiModule),
        typeof(AbpPermissionManagementHttpApiModule),
        typeof(AbpTenantManagementHttpApiModule),
        typeof(CacheManagementHttpApiModule),
        typeof(AbpFeatureManagementHttpApiModule)
        )]
    [DependsOn(typeof(BloggingHttpApiModule))]
    [DependsOn(typeof(BloggingAdminHttpApiModule))]
    public class CacheManagementDemoHttpApiModule : AbpModule
    {
        
    }
}
