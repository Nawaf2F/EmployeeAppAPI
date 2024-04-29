using Volo.Abp.Modularity;

namespace EmployeeApp;

[DependsOn(
    typeof(EmployeeAppApplicationModule),
    typeof(EmployeeAppDomainTestModule)
)]
public class EmployeeAppApplicationTestModule : AbpModule
{

}
