using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, i, sum = 0;
            Console.WriteLine("It is going to run loop for four times");
            for(i = 1; i <= 4; i++)
            {
                Console.WriteLine("Enter Number {0}", i);
                a = Int32.Parse(Console.ReadLine());
                sum += a;
            }
            Console.WriteLine("\nSum of 4 Number's Is = {0}", sum);

            Console.ReadKey();
        }
    }
}
