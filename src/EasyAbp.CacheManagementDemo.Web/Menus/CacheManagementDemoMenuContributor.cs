using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using EasyAbp.CacheManagementDemo.Localization;
using EasyAbp.CacheManagementDemo.MultiTenancy;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace EasyAbp.CacheManagementDemo.Web.Menus
{
    public class CacheManagementDemoMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
        }

        private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            if (!MultiTenancyConsts.IsEnabled)
            {
                var administration = context.Menu.GetAdministration();
                administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
            }

            var l = context.ServiceProvider.GetRequiredService<IStringLocalizer<CacheManagementDemoResource>>();

            context.Menu.Items.Insert(0, new ApplicationMenuItem("CacheManagementDemo.Home", l["Menu:Home"], "/"));
        }
    }
}
