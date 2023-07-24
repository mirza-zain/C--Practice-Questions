using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, i, tab;
            Console.WriteLine("Enter Any Number for Generating Table");
            a = Int32.Parse(Console.ReadLine());
            for(i = 1; i <= 10; i++)
            {
                tab = a * i;
                Console.WriteLine("{0} X {1} = {2}", a, i, tab);
            }
            Console.ReadKey();
        }
    }
}
