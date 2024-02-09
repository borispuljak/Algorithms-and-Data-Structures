using Single_List;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();

            try
            {
                queue.Enqueue("Ivo");
                queue.Enqueue("Ana");
                queue.Enqueue("Bob");
                queue.Enqueue("Iva");
                queue.Enqueue("Leo");

                Console.WriteLine("Elementi u redu:");
                queue.Display();

                while (!queue.IsEmpty())
                {
                    Console.WriteLine("\nRed nakon izbacivanja:");
                    queue.Dequeue();
                    queue.Display();
                }
                Console.WriteLine("\nQueue is empty");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}