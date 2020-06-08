using System;
using System.Collections.Generic;
using System.Text;
using EasyAbp.CacheManagementDemo.Localization;
using Volo.Abp.Application.Services;

namespace EasyAbp.CacheManagementDemo
{
    /* Inherit your application services from this class.
     */
    public abstract class CacheManagementDemoAppService : ApplicationService
    {
        protected CacheManagementDemoAppService()
        {
            LocalizationResource = typeof(CacheManagementDemoResource);
        }
    }
}
