using EasyAbp.CacheManagementDemo.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace EasyAbp.CacheManagementDemo.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class CacheManagementDemoController : AbpController
    {
        protected CacheManagementDemoController()
        {
            LocalizationResource = typeof(CacheManagementDemoResource);
        }
    }
}