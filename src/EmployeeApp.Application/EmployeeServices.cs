using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace EmployeeApp
{

    public class EmployeeServices : CrudAppService<Employee,EmployeeDto,Guid, EmployeeFilterDto, CreateUpdateEmployeeDto>,IEmployeeServices
    {

        public EmployeeServices(IRepository<Employee, Guid> repository)
    : base(repository)
        {
        }

        // Overriding GetListAsync to apply custom filtering
        public override async Task<PagedResultDto<EmployeeDto>> GetListAsync(EmployeeFilterDto input)
        {
            var query = await Repository.GetQueryableAsync();

            // Apply filters
            if (!string.IsNullOrWhiteSpace(input.NameFilter))
            {
                query = query.Where(e => e.Name.Contains(input.NameFilter));
            }

            if (!string.IsNullOrWhiteSpace(input.EmailFilter))
            {
                query = query.Where(e => e.Email.Contains(input.EmailFilter));
            }

            if (!string.IsNullOrWhiteSpace(input.PositionFilter))
            {
                query = query.Where(e => e.Position.Contains(input.PositionFilter));
            }

            if (input.MinSalaryFilter.HasValue)
            {
                query = query.Where(e => e.Salary >= input.MinSalaryFilter.Value);
            }

            if (input.MaxSalaryFilter.HasValue)
            {
                query = query.Where(e => e.Salary <= input.MaxSalaryFilter.Value);
            }

            // Apply sorting
            if (!string.IsNullOrWhiteSpace(input.Sorting))
            {
                query = query.OrderBy(input.Sorting);
            }
            else
            {
                query = query.OrderBy(e => e.Name); // Default sorting
            }

            // Apply pagination
            var totalCount = await query.CountAsync();
            var items = await query.PageBy(input.SkipCount, input.MaxResultCount).ToListAsync();

            return new PagedResultDto<EmployeeDto>(totalCount, ObjectMapper.Map<List<Employee>, List<EmployeeDto>>(items));
        }


        //public async Task<EmployeeDto> CreateAsync(string name, string email, string position, int salary)
        //{
        //    var employee = await _employeeRepository.InsertAsync(new Employee { Name = name, Email = email, Position = position, Salary = salary });
        //    return new EmployeeDto { Name = employee.Name, Email = employee.Email,Position = employee.Position ,Salary = employee.Salary };
        //}

        //public async Task DeleteAsync(Guid id)
        //{
        //    await _employeeRepository.DeleteAsync(id);
        //}

        //public async Task<List<EmployeeDto>> GetListAsync()
        //{
        //    var employee = await _employeeRepository.GetListAsync();
        //    return employee.Select(x => new EmployeeDto { Name = x.Name, Email = x.Email, Position = x.Position, Salary =x.Salary }).ToList();
        //}
    }
}
