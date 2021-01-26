using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice
{
    class Employee
    {
        private string FirstName;
        private string LastName;

        // concept of overriding
        //public virtual void printFullName() {
        //    Console.WriteLine(FirstName+" "+LastName);
        //}

        public void printFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }

        public string Firstname {
            get {
                return string.IsNullOrEmpty(this.FirstName) ? "No First Name" : this.FirstName;
            }
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("First Name can't Empty!");
                }
                this.FirstName = value;
            }
        }

        public string Lastname {
            get {
                
                return string.IsNullOrEmpty(this.LastName) ? "No Last name" : this.LastName;
            }
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Last Name can't empty!");
                }
                this.LastName = value;
            }
        }
    }
}
