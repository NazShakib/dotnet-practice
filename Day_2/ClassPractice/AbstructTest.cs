using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice
{
    public abstract class Customer2 {
        public abstract void Print();
    }
    class AbstructTest : Customer2
    {
        public override void Print()
        {
            Console.WriteLine("Abstruct Printing");
        }
    }
}
