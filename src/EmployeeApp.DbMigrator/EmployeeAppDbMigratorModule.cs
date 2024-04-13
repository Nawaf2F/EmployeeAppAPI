using EmployeeApp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace EmployeeApp.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(EmployeeAppEntityFrameworkCoreModule),
    typeof(EmployeeAppApplicationContractsModule)
    )]
public class EmployeeAppDbMigratorModule : AbpModule
{
}
