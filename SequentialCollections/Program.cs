using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SequentialCollections
{
    class Program
    {
        static void Main(string[] args)
        {
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
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                }
                catch(Exception e)
                {
                    Console.WriteLine("An error occured.");
                    Console.WriteLine(e.Message);
                }
                
            }
            

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
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine("An error occured.");
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
