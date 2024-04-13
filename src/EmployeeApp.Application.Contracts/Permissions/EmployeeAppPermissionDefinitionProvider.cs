using EmployeeApp.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace EmployeeApp.Permissions;

public class EmployeeAppPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(EmployeeAppPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(EmployeeAppPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<EmployeeAppResource>(name);
    }
}
