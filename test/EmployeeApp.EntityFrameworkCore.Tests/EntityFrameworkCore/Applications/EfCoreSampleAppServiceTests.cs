using EmployeeApp.Samples;
using Xunit;

namespace EmployeeApp.EntityFrameworkCore.Applications;

[Collection(EmployeeAppTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<EmployeeAppEntityFrameworkCoreTestModule>
{

}
