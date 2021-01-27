using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    class ReflectTest
    {
        int _id;
        string _name;
        private int marks;
        private int position;

        public ReflectTest()
        {
            this.marks = -1;
            this.position = -1;
        }
        public ReflectTest(int marks, int position)
        {
            this.marks = marks;
            this.position = position;
        }


        public int ID {
            get {
                return _id;
            }
            set {
                _id = value;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public void getDetails()
        {
            Console.WriteLine("ID is {0} and Name is {1}",this._id,this._name);
        }
    }
}
