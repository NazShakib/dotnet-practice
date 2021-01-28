using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    class GenericCollections
    {
        
        public void DictonaryExample(Dictionary<int, Customer> dict)
        {
            var result = dict[10];
            Customer cust;
            if (dict.TryGetValue(25, out cust))
            {
                Console.WriteLine("ID: {0}, Name: {1}, Salary: {2}", cust.id, cust.name, cust.salary);
            }
            else
            {
                Console.WriteLine("Not found");
            }
            Console.WriteLine("Total Item: {0}", dict.Count(keyVal => keyVal.Value.salary >= 6000));
            foreach (KeyValuePair<int, Customer> customerDict in dict)
            {
                result = customerDict.Value;
                Console.WriteLine("ID: {0}, Name: {1}, Salary: {2}", result.id, result.name, result.salary);
            }

            //dict.Remove(10);
            //dict.Clear();
        }
        public void ListExample(List<Customer> cust)
        {
            foreach (var customerList in cust)
            {
                Console.WriteLine("ID: {0}, Name: {1}, Salary: {2}", customerList.id, customerList.name, customerList.salary);
            }
        }

        public void ArrayToDictonary(Customer[] customers)
        {
            Dictionary<int, Customer> arrayCustomer = customers.ToDictionary(cust => cust.id, cust => cust);

            foreach (KeyValuePair<int, Customer> customerDict in arrayCustomer)
            {
                var result = customerDict.Value;
                Console.WriteLine("ID: {0}, Name: {1}, Salary: {2}", result.id, result.name, result.salary);
            }
        }
        public void QueueExample(Queue<Customer> customers)
        {
            Console.WriteLine("ID: {0}, Name: {1}, Salary: {2}", customers.Peek().id, customers.Peek().name, customers.Peek().salary);

            while (customers.Count > 0)
            {
                var custom = customers.Dequeue();
                Console.WriteLine("ID: {0}, Name: {1}, Salary: {2}", custom.id, custom.name, custom.salary);
            }
        }
        public void StackExample(Stack<Customer> customers)
        {
            while (customers.Count > 0)
            {
                var custom = customers.Pop();
                Console.WriteLine("ID: {0}, Name: {1}, Salary: {2}", custom.id, custom.name, custom.salary);
            }
        }

        public HashSet<int> HashSetExample()
        {
            HashSet<int> hash = new HashSet<int>();
            hash.Add(1);
            hash.Add(2);
            hash.Add(2);
            hash.Add(3);
            hash.Add(4);
            return hash;
        }

        public void LinkedListExample(LinkedList<Customer> list) 
        {
            list.AddLast(new Customer() { id=30,name="Jak", salary=6000});
            var node = list.First;
            while (node!=null)
            {
                Console.WriteLine("ID: {0}, name: {1}, Salary: {2}",node.Value.id, node.Value.name, node.Value.salary);
                node = node.Next;
            }
        }

    }
}
