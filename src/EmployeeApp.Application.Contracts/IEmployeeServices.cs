using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace EmployeeApp
{

    public interface IEmployeeServices : ICrudAppService< EmployeeDto,Guid, EmployeeFilterDto, CreateUpdateEmployeeDto, CreateUpdateEmployeeDto> 
    {
        
    }

}
