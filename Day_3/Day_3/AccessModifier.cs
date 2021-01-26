using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{

   public class Student
    {
        // accessability only class 
        private int _id;

        // accessability only class and child class 
        protected string name;

        // accessability everywhere

        public int position;

        //accessability only own project

        internal int marks;

        protected internal string fatherName;

        public int ID {
            get {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        protected string Name
        {
            get {
                return name;
            }
            set
            {
                name = value;
            }
        }
        internal int Mark 
        {
            get
            {
                return marks;
            }
            set 
            {
                marks = value;
            }
        }

    }
    public class AccessModifier : Student
    {
        public void inheritantName(string name)
        {
            Name = name;
            Console.WriteLine(Name);
        }

    }
}
