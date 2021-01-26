using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    
    public class Employee
    {
        #region Property
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }
        #endregion

        #region Method
        public void  promotEmployee(List<Employee> empList, IsPromotble promot) {
            foreach (Employee emp  in empList)
            {
                if (promot(emp))
                {
                    Console.WriteLine(emp.Name+ " is Promoted!");
                }
            }
        }
        #endregion
    }
}
