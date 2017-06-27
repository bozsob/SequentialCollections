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



            
        }
    }
}
