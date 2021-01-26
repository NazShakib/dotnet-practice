using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day_3;

namespace Testing
{
    public class Test
    {
        // internal member type not visible in this class
        public void Print()
        {
            AccessModifier access = new AccessModifier();
            access.ID = 10;
            access.position = 5;
            Console.WriteLine(access.ID);

        }
    }
}
