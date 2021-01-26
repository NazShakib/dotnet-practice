using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    interface IA {
        void methodA();
    }
    interface IB {
        void methodB();
    }

    class ClassA : IA
    {
        public void methodA()
        {
            Console.WriteLine("This is class A");
        }
    }

    class ClassB : IB
    {
        public void methodB()
        {
            Console.WriteLine("This is class B");
        }
    }

    // multiple class inheritance using interface
    class MultipleClass : IA, IB
    {
        ClassA a = new ClassA();
        ClassB b = new ClassB();
        public void methodA()
        {
            a.methodA();
        }

        public void methodB()
        {
            b.methodB();
        }
    }
}
