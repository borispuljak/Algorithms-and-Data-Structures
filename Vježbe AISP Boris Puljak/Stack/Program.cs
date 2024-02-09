using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();

            try
            {
                stack.Push("Ivo");
                stack.Push("Ana");
                stack.Push("Bob");
                stack.Push("Iva");
                stack.Push("Kim");

                Console.WriteLine("Elementi u stogu:");
                stack.Display();

                while (!stack.IsEmpty())
                {
                    Console.WriteLine("\nStog nakon izbacivanja:");
                    stack.Pop();
                    stack.Display();
                }

                Console.WriteLine("\nStog je prazan");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}