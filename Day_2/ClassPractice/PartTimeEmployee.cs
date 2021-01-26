using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice
{
    class PartTimeEmployee : Employee
    {
        string hourly;

        //public override void printFullName()
        //{
        //    Console.WriteLine(Firstname+" "+Lastname+" -Part Time employee");
        //}

        public new void printFullName()
        {
            Console.WriteLine(Firstname + " " + Lastname + " -Part Time employee");
        }

        // comment-> cltr+k+c
        // uncomiit-> cltr+k+u
        // ctor -> constuctor
        // prop-> getter/ setter


    }
}