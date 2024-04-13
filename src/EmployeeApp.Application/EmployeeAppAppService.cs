using System;
using System.Collections.Generic;
using System.Text;
using EmployeeApp.Localization;
using Volo.Abp.Application.Services;

namespace EmployeeApp;

/* Inherit your application services from this class.
 */
public abstract class EmployeeAppAppService : ApplicationService
{
    protected EmployeeAppAppService()
    {
        LocalizationResource = typeof(EmployeeAppResource);
    }
}
