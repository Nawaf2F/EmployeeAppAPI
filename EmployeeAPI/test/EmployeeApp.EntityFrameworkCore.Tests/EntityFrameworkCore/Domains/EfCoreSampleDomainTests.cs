using EmployeeApp.Samples;
using Xunit;

namespace EmployeeApp.EntityFrameworkCore.Domains;

[Collection(EmployeeAppTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<EmployeeAppEntityFrameworkCoreTestModule>
{

}
