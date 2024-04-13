using System.Threading.Tasks;

namespace EmployeeApp.Data;

public interface IEmployeeAppDbSchemaMigrator
{
    Task MigrateAsync();
}
