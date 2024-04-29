using Volo.Abp.Settings;

namespace EmployeeApp.Settings;

public class EmployeeAppSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(EmployeeAppSettings.MySetting1));
    }
}
