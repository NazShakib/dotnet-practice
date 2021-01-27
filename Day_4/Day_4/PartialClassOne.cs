using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    partial class PartialClass
    {
        private int _id;
        private string _firstName;
        private string _lastName;

        partial void partialMethod();

        public void Print()
        {
            Console.WriteLine("Print method Invocked !");
            partialMethod();
        }

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public int Id { get => _id; set => _id = value; }

    }
}
