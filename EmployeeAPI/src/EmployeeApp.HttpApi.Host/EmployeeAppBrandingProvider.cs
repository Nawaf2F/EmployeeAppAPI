using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace EmployeeApp;

[Dependency(ReplaceServices = true)]
public class EmployeeAppBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "EmployeeApp";
}
