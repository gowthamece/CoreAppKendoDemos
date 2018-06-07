using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCoreAPI.Model
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public bool HasEmployees { get; set; }
        public int? ReportsTo { get; set; }

        public Employee(int EmployeeId, string Name, bool HasEmployee, int? ReportsTo)
        {
            this.EmployeeId = EmployeeId;
            this.Name = Name;
            this.HasEmployees = HasEmployee;
            this.ReportsTo = ReportsTo;
        }

    }

  
}
