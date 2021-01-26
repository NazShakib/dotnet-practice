using System;
using System.Collections.Generic;

namespace firstProject
{
    class Program
    {
        // calculate the average
        public static void calAvg() {
            List<double> grades = new List<double>() { 10.0, 20.1, 23.5, 25.5, 26.0 };
            var result = 0.0;
            foreach (var number in grades)
            {
                result += number;
            }
            result /= grades.Count;
            //Console.WriteLine(result);
            Console.WriteLine($"Total average is { result:N3}");

        }

        public static int findMax(int x, int y, int z)
        {
            var max = Math.Max(x, Math.Max(y, z));
            return max;
        }

        public static string upperCase(string str)
        {
            return str.Length < 3 ? str.ToUpper() : str.Remove(str.Length - 3) + str.Substring(str.Length - 3).ToUpper();
        }

        public static int reminderFind(int x, int y) {
            if (x == y) return 0;
            else if (x % 7 == y % 7) return (x < y) ? x : y;
            return (x > y) ? x : y;
        
        }

        public static string concatString(string s1, string s2) {

            if (s1.Length < 1)
            {
                return s2;
            }
            else if (s2.Length < 1)
            {
                return s1;
            }
            else
            {
                return !s1.EndsWith(s2.Substring(0, 1)) ? s1 + s2 : s1 + s2.Substring(1);
            }
        
        }

        public static bool IsExits(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 3 && nums[i] != 5) return false;
            }
            return true;
        }

        public static int loopAdd(int init, int last)
        {
            var sum = 0;
            for (var i = init; i <= last; i++)
            {
                sum += i;
            }
            return sum;

        }

        public static double circleArea(int r)
        {
            return Math.PI * Math.Pow(r, 2);
        }

        public static void switchPractice(int val) {

            switch (val) {
                case 1:
                    Console.WriteLine("1st");
                    break;
                case 2:
                    Console.WriteLine("2nd");
                    break;
                case 3:
                    Console.WriteLine("3nd");
                    break;
                default:
                    Console.WriteLine("None");
                    break;
            }
        }

        static void Main(string[] args)
        {
            var x = 34.1;
            var y = 10.0;
            var result = x + y;
            var numbers = new[] { 10.0, 20.1,23.5,25.5,26.0};
            //calAvg();

            //find maximum 
            //var val = findMax(10, 5, 21);
            //string val = upperCase("Python");
            //var val = reminderFind(24, 11);
            //var val = concatString("python", "nodejs");
            // var num = new[] { 3, 3, 3, 5, 5, 5 };
            //var val = IsExits(num);
            //var sum = loopAdd(1, 20);
            /*  Console.WriteLine("Enter Radious: ");
                var r = Convert.ToInt32(Console.ReadLine());
                var area = circleArea(r);            
               Console.WriteLine($"Total is {area}"); */
            Console.WriteLine("Enter value :");
            var n = Convert.ToInt32(Console.ReadLine());
            switchPractice(n);
        }
    }
}
