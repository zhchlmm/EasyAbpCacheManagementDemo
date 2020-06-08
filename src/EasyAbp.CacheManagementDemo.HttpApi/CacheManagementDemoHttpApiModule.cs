using EasyAbp.CacheManagement;
using Volo.Abp.Account;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement.HttpApi;
using Volo.Abp.TenantManagement;

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
    public class CacheManagementDemoHttpApiModule : AbpModule
    {
        
    }
}
