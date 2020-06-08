using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace EasyAbp.CacheManagementDemo.Web
{
    [Dependency(ReplaceServices = true)]
    public class CacheManagementDemoBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "CacheManagementDemo";
    }
}
