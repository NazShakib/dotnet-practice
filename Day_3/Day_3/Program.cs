using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{

    class Program
    {
        static void Main(string[] args)
        {
            ////////// Multiple class inheritance using interface
            MultipleClass mcc = new MultipleClass();
            mcc.methodA();
            mcc.methodB();


            ////////// delegates 
            DelegateClass dele = new DelegateClass();
            addnum dele1 = new addnum(dele.sum);
            subnum dele2 = new subnum(dele.substruct);
            dele1(10, 15);
            dele2(21, 20);

            Employee employee = new Employee();
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee() { ID = 101, Name = "Sakib", Salary = 5000, Experience = 2 });
            empList.Add(new Employee() { ID = 102, Name = "Rafid", Salary = 100000, Experience = 5 });
            empList.Add(new Employee() { ID = 103, Name = "Arnob", Salary = 50000, Experience = 3 });
            empList.Add(new Employee() { ID = 104, Name = "Samir", Salary = 500000, Experience = 10 });
            empList.Add(new Employee() { ID = 105, Name = "Nakib", Salary = 250000, Experience = 7 });

            IsPromotble promo = new IsPromotble(dele.promot);
            ////////// delegate expression
            employee.promotEmployee(empList, promo);
            //////// lamda expression
            employee.promotEmployee(empList, emp => emp.Experience > 5);


            ///////// multicast delegate

            SampleMulticast sample1, sample2, sample3, sample4;

            ///////// one way
            sample1 = new SampleMulticast(dele.sampleMethodOne);
            sample2 = new SampleMulticast(dele.sampleMethodTwo);
            sample3 = new SampleMulticast(dele.sampleMethodThree);
            sample4 = sample1 + sample2 + sample3 - sample2;
            sample4();

            ///////// another way

            sample1 = new SampleMulticast(dele.sampleMethodOne);
            sample1 += dele.sampleMethodTwo;
            sample1 += dele.sampleMethodThree;
            sample1 -= dele.sampleMethodTwo;

            sample1();


            /////// exception handaling

            ExceptionHandle exceptionHandle = new ExceptionHandle();
            string result = exceptionHandle.fileRead(@"D:\dot net\testing.txt");
            Console.WriteLine(result);

            exceptionHandle.caculation(@"D:\dot net\log.txt");

            /////// custom exception
            

            try
            {
                throw new UserAlreayLoggedIn("This is custom exception");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }


            ///////// enum

            Person[] person = new Person[3];

            person[0] = new Person { name = "Sakib", gender = Gender.Male };
            person[1] = new Person { name = "Rafi", gender = Gender.Female };
            person[2] = new Person { name = "abcds", gender = Gender.Unknown };

            foreach (Person per in person)
            {
                Console.WriteLine("Person name is {0} and gender is {1}", per.name, per.getGender(per.gender));
            }


            //// access modifier

            AccessModifier ac = new AccessModifier();
            ac.inheritantName("Nazmus Sakib");

            

        }
    }
}
