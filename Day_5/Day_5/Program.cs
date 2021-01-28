using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Buffer for generics

            //// double buffer
            var demo = new BufferDemo<double>(capacity: 3);
            demo.write(2.1);
            demo.write(3.1);
            demo.write(3.4);
            var sum = 0.0;
            while (!demo.IsEmpty())
            {
                sum += demo.read();
            }
            Console.WriteLine("Sum {0}", sum);

            //// string buffer
            var stringDemo = new BufferDemo<string>(capacity: 3);
            stringDemo.write("abc");
            stringDemo.write("def");
            stringDemo.write("ghj");

            while (!stringDemo.IsEmpty())
            {
                Console.WriteLine("string {0}", stringDemo.read());
            }


            /// genric class
            /// 
            BufferDemo2<string> bufferDemo2 = new BufferDemo2<string>();
            bufferDemo2.write("abc");
            bufferDemo2.write("zyz");
            bufferDemo2.write("npm");
            while (!bufferDemo2.IsEmpty())
            {
                var result = bufferDemo2.read();
                Console.WriteLine("Buffer Generic Class's Value: {0}", result);
            }




            Customer customer1 = new Customer()
            {
                id = 10,
                name = "Rabid",
                salary = 5000
            };
            Customer customer2 = new Customer()
            {
                id = 15,
                name = "Nabid",
                salary = 6000
            };
            Customer customer3 = new Customer()
            {
                id = 20,
                name = "Kabid",
                salary = 7000
            };

            //// Dictonary
            Dictionary<int, Customer> dict = new Dictionary<int, Customer>();
            dict.Add(customer1.id, customer1);
            dict.Add(customer2.id, customer2);
            dict.Add(customer3.id, customer3);

            GenericCollections genericCollections = new GenericCollections();
            genericCollections.DictonaryExample(dict);


            ///// List to dictonary
            List<Customer> customers = new List<Customer>();
            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);
            genericCollections.ListExample(customers);


            /// Array to dictonary
            Customer[] customer = new Customer[3];
            customer[0] = customer1;
            customer[1] = customer2;
            customer[2] = customer3;
            genericCollections.ArrayToDictonary(customer);


            Dictionary<int, Customer> listCustomers = customer.ToDictionary(cust => cust.id, cust => cust);

            /// Queue
            
            Queue < Customer > customerQueue = new Queue<Customer>();
            customerQueue.Enqueue(customer1);
            customerQueue.Enqueue(customer2);
            customerQueue.Enqueue(customer3);

            genericCollections.QueueExample(customerQueue);


            //// Stack
            Stack<Customer> customersStack = new Stack<Customer>();
            customersStack.Push(customer1);
            customersStack.Push(customer2);
            customersStack.Push(customer3);

            genericCollections.StackExample(customersStack);

            /// HashSet -> insert only unique value 

            var set1 = genericCollections.HashSetExample();
            HashSet<int> set2 = new HashSet<int>() { 2, 3, 5, 6 };

            set1.IntersectWith(set2);

            foreach (var item in set1)
            {
                Console.WriteLine(item);
            }

            LinkedList<Customer> listCustomer = new LinkedList<Customer>();
            listCustomer.AddFirst(customer1);
            var first = listCustomer.First;
            listCustomer.AddAfter(first, customer2);
            listCustomer.AddLast(customer3);
            genericCollections.LinkedListExample(listCustomer);


            //// comparing type

            var depratment = new Dictionary<string, List<Employee>>();
            depratment.Add("engineering", new List<Employee>());
            depratment.Add("sales", new List<Employee>());

            depratment["engineering"].Add(new Employee{ name="Ab", department_id=1});
            depratment["engineering"].Add(new Employee{ name = "Cd", department_id = 2 });
            depratment["engineering"].Add(new Employee{ name = "Ef", department_id = 3 });
            depratment["engineering"].Add(new Employee{ name = "Gh", department_id = 4 });

            depratment["sales"].Add(new Employee{ name = "Xy", department_id = 5 });
            depratment["sales"].Add(new Employee{ name = "Yz", department_id = 6 });

            foreach (var dept in depratment)
            {
                Console.WriteLine(dept.Key);
                foreach (var eName in dept.Value)
                {
                    Console.WriteLine("\t"+eName.name+"\t"+eName.department_id);
                }
            }


        }
    }
}
