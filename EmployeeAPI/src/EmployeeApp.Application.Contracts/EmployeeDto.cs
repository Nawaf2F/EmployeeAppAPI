using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeApp
{
    public class EmployeeDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }
    }
}
