using EasyAbp.CacheManagementDemo.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace EasyAbp.CacheManagementDemo.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class CacheManagementDemoPageModel : AbpPageModel
    {
        protected CacheManagementDemoPageModel()
        {
            LocalizationResourceType = typeof(CacheManagementDemoResource);
        }
    }
}