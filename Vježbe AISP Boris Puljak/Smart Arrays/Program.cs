using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SmartArray
{
    class Program
    {
        static void Main(string[] args)
        {
            SmartArray smarty = new SmartArray(4);
            for (int i = 0; i < 8; i++)
            {
                smarty.Add(i);
            }
            for (int i = 0; i < smarty.Length; i++)
                Console.Write(smarty[i] + " ");
            Console.WriteLine();
            IEnumerator enumerator = smarty.GetEnumerator();
            while (enumerator.MoveNext())
            {
                int i = (int)enumerator.Current;
                Console.Write(i + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("Removing " + i);
                smarty.Remove(i);
                foreach (var s in smarty)
                {
                    Console.Write(s + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
