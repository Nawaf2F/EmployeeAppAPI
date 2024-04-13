using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    using System;
    using Volo.Abp.Domain.Entities.Auditing;

    public class Employee : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }
    }

}
