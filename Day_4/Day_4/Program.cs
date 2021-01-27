using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Runtime.InteropServices; // make optional parameter

namespace Day_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //////// attribute 
            ///
            //AttributeTest test = new AttributeTest();
            //// add(int, int) function is deprecated  
            //int result = test.add(10,15);
            //int result2 = test.add(new List<int>(){10,15,20,25});
            //Console.WriteLine("Result: {0} & Result List {1}",result,result2);


            //////// Reflects

            ////Type T = Type.GetType("Day_4.ReflectTest");

            //Type T = typeof(ReflectTest);

            //Console.WriteLine("Class Name: {0}",T.Name);
            //Console.WriteLine("NameSpcae: {0}", T.Namespace);

            //Console.WriteLine();
            //Console.WriteLine("Print Property");
            //PropertyInfo[] propertyInfo = T.GetProperties();
            //foreach (PropertyInfo info in propertyInfo)
            //{
            //    Console.WriteLine(info.PropertyType.Name+" "+info.Name);
            //}

            //Console.WriteLine();
            //Console.WriteLine("Print Method");
            //MethodInfo[] methodInfo = T.GetMethods();
            //foreach (MethodInfo info in methodInfo)
            //{
            //    Console.WriteLine(info.ReturnType.Name + " " + info.Name);
            //}

            //Console.WriteLine();
            //Console.WriteLine("Constructor Method");
            //ConstructorInfo[] constructors = T.GetConstructors();
            //foreach (ConstructorInfo constructor in constructors)
            //{
            //    Console.WriteLine (constructor.ToString());
            //}

            /////// partial class

            //PartialClass partial = new PartialClass();
            //partial.FirstName = "Nazzmus";
            //partial.LastName = "Sakib";
            //partial.Id = 123;
            //partial.getDetails();
            //partial.Print();

            ///// optional parameter

            //Add(10, 20);  //optional parameter
            //Add(10, 20, new object[] { 30, 40, 50 });

            // using method overloading 
            //addNumber(10,15);
            //addNumber(10,25,new int[] { 15,20,30});

            //addNumberOptional(10,25, new int[] { 25,30,35});    
            
        }

        public static void Add(int number1, int number2, params object[] restOfNumbers) 
        {
            int result = number1 + number2;
            foreach (int num in restOfNumbers)
            {
                result += num;
            }
            Console.WriteLine("Sum = {0}",result);

        }

        /// parameter optional using method overloading
        public static void addNumber(int number1, int number2)
        {
            addNumber(number1, number2, null);
        }

        public static void addNumber(int num1, int num2, int[] restNum)
        {
            int result = num1 + num2;
            if (restNum != null)
            {
                foreach (int num in restNum)
                {
                    result += num;
                }
            }

            Console.WriteLine("Result is: {0}",result);
            
        }


        public static void addNumberOptional(int num1, int num2, [Optional] int[] restOfNum)
        {
            int result = num1 + num2;
            if (restOfNum!=null)
            {
                foreach (int num in restOfNum)
                {
                    result += num;
                }
            }
            Console.WriteLine("Result :{0}",result);
        }



    }
}
