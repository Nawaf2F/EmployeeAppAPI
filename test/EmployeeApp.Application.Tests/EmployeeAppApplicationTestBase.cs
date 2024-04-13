using Volo.Abp.Modularity;

namespace EmployeeApp;

public abstract class EmployeeAppApplicationTestBase<TStartupModule> : EmployeeAppTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
