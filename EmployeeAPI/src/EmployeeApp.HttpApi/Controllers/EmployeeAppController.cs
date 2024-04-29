using EmployeeApp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace EmployeeApp.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class EmployeeAppController : AbpControllerBase
{
    protected EmployeeAppController()
    {
        LocalizationResource = typeof(EmployeeAppResource);
    }
}
