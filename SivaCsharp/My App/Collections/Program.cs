using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {// Arraylist
            ArrayList list = new ArrayList(50);
            list.Add("World");
            list.Add("Hello");
            Console.WriteLine("Count: {0}", list.Count); //count of the items consisting in the array
            Console.WriteLine("Capacity: {0}", list.Capacity);// capacity of the array 
            list.Sort();
            PrintCollection(list);
            Console.WriteLine("list[0]={0}", list[0]);
            Console.WriteLine("list[1]={0}", list[1]);
            Console.WriteLine("Contains Hello: {0}", list.Contains("Hello"));// gives true or false about the string 
            Console.WriteLine("Contains Siva: {0}", list.Contains("Siva"));//gives true or false about the string.
            list.BinarySearch("Hello");
            Console.WriteLine("press Enter to continue");
            Console.ReadLine();

            //hashtable 
            Hashtable table = new Hashtable();
            table["Siva"] = 24;
            table["Jagan"] = 22;
            table["Gayatri"] = 29;
            Console.WriteLine("Siva is {0} years old", table["Siva"] );
            Console.WriteLine("Jagana is {0} years old", table["Jagan"]);
            Console.WriteLine("Gayatri is {0} years old", table["Gayatri"]);
            Console.WriteLine("press Enter to continue");

            Console.ReadLine();
            PrintCollection(table.Keys);
            PrintCollection(table.Values);
            //checking values using Contains key
            Console.WriteLine("Containskey Anoo? {0}", table.ContainsKey("Anoo"));
            Console.WriteLine("Containskey Gayatri? {0}", table.ContainsKey("Gayatri"));
            Console.WriteLine("press Enter to continue");

            Console.ReadLine();

            //sorted list
            SortedList table1 = new SortedList();
            table1["Anoo"] = 23;
            table1["Dhana"] = 29;
            table1["Sai"] = 22;
            table1["kiran"] = 30;
            Console.WriteLine("Anoo is at index {0}", table1.IndexOfKey("Anoo"));
            Console.WriteLine("Dhana is at index {0}", table1.IndexOfKey("Dhana"));
            Console.WriteLine("Sai is at index {0}", table1.IndexOfKey("Sai"));
            Console.WriteLine("kiran is at index {0}", table1.IndexOfKey("kiran"));
            Console.WriteLine("press Enter to continue");

            //table1.RemoveAt(2); //will remove 2nd index
            //table1.GetByIndex(2);//
            Console.ReadLine();

            //stacks and queues 
            Stack stack = new Stack();
           
            stack.Push("Every");
            stack.Push("body");
            stack.Push("Is");
            stack.Push("Doing");
            stack.Push("Good");
                      
            Console.WriteLine("peek returns {0}", stack.Peek());
            
            while(stack.Count>0)
                Console.WriteLine(stack.Pop());
            Console.ReadLine();

            //working with queue
            Queue queue = new Queue();
            queue.Enqueue("Every");
            queue.Enqueue("body");
            queue.Enqueue("Is");
            queue.Enqueue("Doing");
            queue.Enqueue("Good");
            Console.WriteLine("peek returns {0}", queue.Peek());
            while(queue.Count>0)
                Console.WriteLine(queue.Dequeue());
            Console.WriteLine("press Enter to continue");

            Console.ReadLine();

        }
        private static void PrintCollection(IEnumerable collection)
        {
            foreach(object obj in collection)
                Console.WriteLine(obj);
        }
    }
}
