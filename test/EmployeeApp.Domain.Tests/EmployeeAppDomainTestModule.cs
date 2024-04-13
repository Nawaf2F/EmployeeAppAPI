using Volo.Abp.Modularity;

namespace EmployeeApp;

[DependsOn(
    typeof(EmployeeAppDomainModule),
    typeof(EmployeeAppTestBaseModule)
)]
public class EmployeeAppDomainTestModule : AbpModule
{

}
