using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    
    class AttributeTest
    {
        [Obsolete("Call add(List<int>) Method",true)]
        public int add(int a, int b)
        {
            return a + b;
        }
        public int add(List<int> numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }

    }
}
