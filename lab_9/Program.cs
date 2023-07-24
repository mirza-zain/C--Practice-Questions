using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_14
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = new string[3];
            int[] integerArray = new int[3];
            double[] doubleArray = new double[3];

            Console.WriteLine("Enter three strings:");
            for (int i = 0; i < 3; i++)
            {
                stringArray[i] = Console.ReadLine();
            }

            Console.WriteLine("Enter three integers:");
            for (int i = 0; i < 3; i++)
            {
                integerArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter three doubles:");
            for (int i = 0; i < 3; i++)
            {
                doubleArray[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("You entered the following strings:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(stringArray[i]);
            }

            Console.WriteLine("You entered the following integers:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(integerArray[i]);
            }

            Console.WriteLine("You entered the following doubles:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(doubleArray[i]);
            }
            Console.ReadKey();
        }
    }

}
