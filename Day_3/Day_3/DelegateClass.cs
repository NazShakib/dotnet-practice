using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    public delegate void addnum(int a, int b);
    public delegate void subnum(int a, int b);
    public delegate bool IsPromotble(Employee emp);
    public delegate void SampleMulticast();
    class DelegateClass
    {

        public void sum(int a, int b) {
            Console.WriteLine("a + b = {0}", a + b);
        }
        public void substruct(int a, int b) {
            Console.WriteLine("a - b = {0}", a-b);
        }

        public bool promot(Employee emp) {
            if (emp.Experience>5)
            {
                return true;
            }
            return false;
        }


        // mutlicast delegate functions

        public void sampleMethodOne() {

            Console.WriteLine("sampleMethodOne Invoked");
        }

        public void sampleMethodTwo() {
            Console.WriteLine("sampleMethodTwo Invoked");
        }

        public void sampleMethodThree()
        {
            Console.WriteLine("sampleMethodThree Invoked");
        }


    }
}
