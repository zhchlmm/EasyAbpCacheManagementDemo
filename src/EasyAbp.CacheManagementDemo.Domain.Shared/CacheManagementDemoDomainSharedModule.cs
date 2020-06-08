using EasyAbp.CacheManagement;
using EasyAbp.CacheManagementDemo.Localization;
using Volo.Abp.AuditLogging;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.IdentityServer;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;
using Volo.Abp.Validation.Localization;
using Volo.Abp.VirtualFileSystem;

namespace EasyAbp.CacheManagementDemo
{
    [DependsOn(
        typeof(AbpAuditLoggingDomainSharedModule),
        typeof(AbpBackgroundJobsDomainSharedModule),
        typeof(AbpFeatureManagementDomainSharedModule),
        typeof(AbpIdentityDomainSharedModule),
        typeof(AbpIdentityServerDomainSharedModule),
        typeof(AbpPermissionManagementDomainSharedModule),
        typeof(AbpSettingManagementDomainSharedModule),
        typeof(CacheManagementDomainSharedModule),
        typeof(AbpTenantManagementDomainSharedModule)
        )]
    public class CacheManagementDemoDomainSharedModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<CacheManagementDemoDomainSharedModule>("EasyAbp.CacheManagementDemo");
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Add<CacheManagementDemoResource>("en")
                    .AddBaseTypes(typeof(AbpValidationResource))
                    .AddVirtualJson("/Localization/CacheManagementDemo");
                
                options.DefaultResourceType = typeof(CacheManagementDemoResource);
            });
        }
    }
}
