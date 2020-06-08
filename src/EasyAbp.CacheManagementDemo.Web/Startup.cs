using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace EasyAbp.CacheManagementDemo.Web
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<CacheManagementDemoWebModule>();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.InitializeApplication();
        }
    }
}
