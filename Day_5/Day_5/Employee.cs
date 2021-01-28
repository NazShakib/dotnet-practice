using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    class EmployeeCompare : IEqualityComparer<Employee>
    {
        public bool Equals(Employee x, Employee y)
        {
            return String.Equals(x.name, y.name);
        }

        public int GetHashCode(Employee obj)
        {
            return obj.name.GetHashCode();
        }
    }


    class Employee
    {
        public string name { get; set; }
        public int department_id { get; set; }
    }
}
