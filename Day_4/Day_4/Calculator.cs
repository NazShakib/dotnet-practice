using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    public class Calculator
    {
        private int number1;
        private int number2;

        public int Number1 { get => number1; set => number1 = value; }
        public int Number2 { get => number2; set => number2 = value; }

        public int Add()
        {
            return number1 + number2;
        }
        public int Substuct()
        {
            return number1 - number2;
        }
        public int Divided()
        {
            return number1 / number2;
        }
        public int Multiplication()
        {
            return number1 * number2;
        }
    }
}
