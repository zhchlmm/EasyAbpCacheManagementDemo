using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using EasyAbp.CacheManagementDemo.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace EasyAbp.CacheManagementDemo.Web.Pages
{
    /* Inherit your UI Pages from this class. To do that, add this line to your Pages (.cshtml files under the Page folder):
     * @inherits EasyAbp.CacheManagementDemo.Web.Pages.CacheManagementDemoPage
     */
    public abstract class CacheManagementDemoPage : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<CacheManagementDemoResource> L { get; set; }
    }
}
