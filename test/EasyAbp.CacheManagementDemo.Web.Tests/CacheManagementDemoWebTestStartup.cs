using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace EasyAbp.CacheManagementDemo
{
    public class CacheManagementDemoWebTestStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<CacheManagementDemoWebTestModule>();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            app.InitializeApplication();
        }
    }
}