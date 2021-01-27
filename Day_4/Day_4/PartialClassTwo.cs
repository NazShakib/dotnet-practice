using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    partial class PartialClass
    {
        public string getFullName()
        {
            return this._firstName + " " + this._lastName;
        }
        public void getDetails()
        {
            Console.WriteLine("Full Name is: {0}",getFullName());
            Console.WriteLine("Id is {0}",Id);
        }
        partial void partialMethod()
        {
            Console.WriteLine("Partial Method called !");
        }
    }
}
