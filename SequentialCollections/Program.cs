using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Specialized;
using System.Globalization;

namespace SequentialCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Working with Queue
            Queue queue = new Queue();
            queue.Enqueue("First");
            queue.Enqueue("Second");
            queue.Enqueue("Third");
            queue.Enqueue("Fourth");

            Console.WriteLine("My queue: ");
            foreach(var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("FIFO (First-in-first-out)");
            while (queue.Count > 0)
            {
                try
                {
                    object obj = queue.Dequeue();
                    Console.WriteLine("From Qeueu: {0}", obj);
                    //Console.WriteLine("Press Enter to continue");
                    //Console.ReadLine();
                }
                catch(Exception e)
                {
                    Console.WriteLine("An error occured.");
                    Console.WriteLine(e.Message);
                }
                
            }
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();

            //Working with Stack
            Console.WriteLine("My stack: ");

            Stack stack = new Stack();
            Console.WriteLine("Push a new item (aaa) into stack.");
            stack.Push("aaa");
            Console.WriteLine("Push a new item (bbb) into stack.");
            stack.Push("bbb");
            Console.WriteLine("Push a new item (ccc) into stack.");
            stack.Push("ccc");
            Console.WriteLine("Push a new item (ddd) into stack.");
            stack.Push("ddd");

            Console.WriteLine("Now the stack looks like: ");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("LIFO (Last-in-first-out)");
            while (stack.Count > 0)
            {
                try
                {
                    object obj = stack.Pop();
                    Console.WriteLine("From Stack: {0}", obj);
                    //Console.WriteLine("Press Enter to continue");
                    //Console.ReadLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine("An error occured.");
                    Console.WriteLine(e.Message);
                }
            }

            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();

            // Working with Hashtable
            Console.WriteLine("Hashtable..");
            Hashtable lookup = new Hashtable();
            lookup["0"] = "Zero";
            lookup["1"] = "One";
            lookup["2"] = "Two";

            lookup.Add("3", "Three");
            lookup.Add("4", "Four");
            lookup.Add("5", "Five");

            lookup["6"] = "Six";
            lookup["7"] = "Seven";
            lookup["8"] = "Eight";
            lookup["9"] = "Nine";

            string ourNumber = "888-555-1212";
            Console.WriteLine("Our number is: " + ourNumber);
            Console.WriteLine("The lookup..");

            foreach (char c in ourNumber)
            {
                string digit = c.ToString();
                if (lookup.ContainsKey(digit))
                {
                    Console.WriteLine(lookup[digit]);
                }
            }
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();

            //Working with ListDictionary
            // Make the dictionary case insensitive 
            ListDictionary list = new ListDictionary
                (new CaseInsensitiveComparer(CultureInfo.InvariantCulture));

            // Add some items
            list["Estados Unidos"] = "United States of America";
            list["Canadá"] = "Canada";
            list["España"] = "Spain";

            // Show the results 
            Console.WriteLine(list["españa"]);
            Console.WriteLine(list["CANADÁ"]);

            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();

            



        }
    }
}
