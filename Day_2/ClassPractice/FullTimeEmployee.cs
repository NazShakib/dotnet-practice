using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice
{
    class FullTimeEmployee : Employee
    {
        string Yearly;

        //public override void printFullName()
        //{
        //    Console.WriteLine(Firstname + " " + Lastname + " - Full Time Employee");
        //}

        public new void printFullName()
        {
            Console.WriteLine(Firstname + " " + Lastname + " - Full Time Employee");
        }


    }
}
