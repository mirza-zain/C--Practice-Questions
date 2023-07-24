using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter Any Number");
            a = Int32.Parse(Console.ReadLine());
            if(a % 2 == 0 )
            {
                Console.WriteLine("The given number is even {0}", a);
            }
            else
            {
                Console.WriteLine("The given number is odd {0}", a);
            }
            Console.ReadKey();
        }
    }
}
