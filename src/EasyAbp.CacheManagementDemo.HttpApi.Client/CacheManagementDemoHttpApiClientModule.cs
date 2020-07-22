using EasyAbp.CacheManagement;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Account;
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
        typeof(CacheManagementDemoApplicationContractsModule),
        typeof(AbpAccountHttpApiClientModule),
        typeof(AbpIdentityHttpApiClientModule),
        typeof(AbpPermissionManagementHttpApiClientModule),
        typeof(AbpTenantManagementHttpApiClientModule),
        typeof(CacheManagementHttpApiClientModule),
        typeof(AbpFeatureManagementHttpApiClientModule)
    )]
    [DependsOn(typeof(BloggingHttpApiClientModule))]
    [DependsOn(typeof(BloggingAdminHttpApiClientModule))]
    public class CacheManagementDemoHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "Default";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(CacheManagementDemoApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
