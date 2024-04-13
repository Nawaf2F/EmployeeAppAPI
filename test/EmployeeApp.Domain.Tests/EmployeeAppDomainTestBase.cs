using Volo.Abp.Modularity;

namespace EmployeeApp;

/* Inherit from this class for your domain layer tests. */
public abstract class EmployeeAppDomainTestBase<TStartupModule> : EmployeeAppTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
