using EasyAbp.CacheManagement;
using EasyAbp.CacheManagementDemo.MultiTenancy;
using EasyAbp.CacheManagementDemo.ObjectExtending;
using Volo.Abp.AuditLogging;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.IdentityServer;
using Volo.Abp.Modularity;
using Volo.Abp.MultiTenancy;
using Volo.Abp.PermissionManagement.Identity;
using Volo.Abp.PermissionManagement.IdentityServer;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;
using Volo.Blogging;

namespace EasyAbp.CacheManagementDemo
{
    [DependsOn(
        typeof(CacheManagementDemoDomainSharedModule),
        typeof(AbpAuditLoggingDomainModule),
        typeof(AbpBackgroundJobsDomainModule),
        typeof(AbpFeatureManagementDomainModule),
        typeof(AbpIdentityDomainModule),
        typeof(AbpPermissionManagementDomainIdentityModule),
        typeof(AbpIdentityServerDomainModule),
        typeof(AbpPermissionManagementDomainIdentityServerModule),
        typeof(CacheManagementDomainModule),
        typeof(AbpSettingManagementDomainModule),
        typeof(CacheManagementStackExchangeRedisModule),
        typeof(AbpTenantManagementDomainModule)
        )]
    [DependsOn(typeof(BloggingDomainModule))]
    public class CacheManagementDemoDomainModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            CacheManagementDemoDomainObjectExtensions.Configure();
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpMultiTenancyOptions>(options =>
            {
                options.IsEnabled = MultiTenancyConsts.IsEnabled;
            });
        }
    }
}
