using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace EmployeeApp.Data;

/* This is used if database provider does't define
 * IEmployeeAppDbSchemaMigrator implementation.
 */
public class NullEmployeeAppDbSchemaMigrator : IEmployeeAppDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
