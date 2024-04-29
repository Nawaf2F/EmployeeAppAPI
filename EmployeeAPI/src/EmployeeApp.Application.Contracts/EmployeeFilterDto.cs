using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace EmployeeApp
{
    public class EmployeeFilterDto : PagedAndSortedResultRequestDto
    {
        public string? NameFilter { get; set; }
        public string? EmailFilter { get; set; }
        public string? PositionFilter { get; set; }
        public int? MinSalaryFilter { get; set; }
        public int? MaxSalaryFilter { get; set; }
    }

}
