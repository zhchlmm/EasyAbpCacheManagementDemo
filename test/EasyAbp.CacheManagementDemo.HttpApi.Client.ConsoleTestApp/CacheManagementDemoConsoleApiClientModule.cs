using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace EasyAbp.CacheManagementDemo.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(CacheManagementDemoHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class CacheManagementDemoConsoleApiClientModule : AbpModule
    {
        
    }
}
