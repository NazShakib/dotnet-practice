using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice
{
    interface ICustomer1 {
        void Print1();
    }
    interface ICustomer2 : ICustomer1{
        void Print2();
    }

    public class Customer1  :ICustomer2 {
        public void Print1() {
            Console.WriteLine("Interface 1");
        }
        public void Print2() {
            Console.WriteLine("Interface 2");
        }
    }

    // explicit interface

    interface I1 {
        void interfaceMethod();
    }
    interface I2 {
        void interfaceMethod();
    }


    public class Program : I1,I2 
    {
        void I1.interfaceMethod() {
            Console.WriteLine("Interfce I1");
        }
        void I2.interfaceMethod()
        {
            Console.WriteLine("Interfce I2");
        }
        static void Main(string[] args)
        {
            //var book1 = new Book();
            //book1.printDetails();

            //var book2 = new Book("Nazmus Sakib",1);
            //book2.printDetails();

            //FullTimeEmployee fte = new FullTimeEmployee();
            //fte.Firstname = "Nazmus";
            //fte.Lastname = "Sakib";
            //fte.printFullName();

            //var fte1 = new FullTimeEmployee();
            //fte1.Firstname = null;
            //fte1.printFullName();
            //Console.WriteLine(fte1.Lastname);

            //PartTimeEmployee pte = new PartTimeEmployee();
            //pte.Firstname = "Rafid";
            //pte.Lastname = "Hossain";
            //pte.printFullName();


            // structure 
            //Customer c1 = new Customer(102,"Nazmus Sakib");
            //c1.printDetails();
            //Customer c2 = new Customer();
            //c2.Id = 103;
            //c2.Name = "Samir";
            //c2.printDetails();

            // interface

            //ICustomer2 cust = new Customer1();
            //cust.Print1();
            //cust.Print2();

            // explicit interface
            //Program p = new Program();
            //((I1)p).interfaceMethod();
            //((I2)p).interfaceMethod();

            // abstruct

            AbstructTest test = new AbstructTest();
            test.Print();



        }
    }
}
