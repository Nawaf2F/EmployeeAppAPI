using Xunit;

namespace EmployeeApp.EntityFrameworkCore;

[CollectionDefinition(EmployeeAppTestConsts.CollectionDefinitionName)]
public class EmployeeAppEntityFrameworkCoreCollection : ICollectionFixture<EmployeeAppEntityFrameworkCoreFixture>
{

}
