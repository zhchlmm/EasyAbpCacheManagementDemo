using EasyAbp.CacheManagementDemo.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace EasyAbp.CacheManagementDemo.Permissions
{
    public class CacheManagementDemoPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(CacheManagementDemoPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(CacheManagementDemoPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<CacheManagementDemoResource>(name);
        }
    }
}
