using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6B
{
    internal class Factorial
    {
        public static void factorial()
        {
            Console.WriteLine("Enter Any Number");
            int number = int.Parse(Console.ReadLine());
            int fact = 1;

            for (int i = 1; i <= number; i++)
            {
                fact *= i;
            }

            Console.WriteLine("The factorial of {0} is {1}", number, fact);
        }
    }
}
