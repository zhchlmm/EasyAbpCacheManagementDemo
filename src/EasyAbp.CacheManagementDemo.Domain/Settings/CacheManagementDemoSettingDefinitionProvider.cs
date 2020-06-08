using Volo.Abp.Settings;

namespace EasyAbp.CacheManagementDemo.Settings
{
    public class CacheManagementDemoSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(CacheManagementDemoSettings.MySetting1));
        }
    }
}
