using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, a;
            Console.WriteLine("Enter Any Number to excute pramid");
            a = Int32.Parse(Console.ReadLine());
            for(i = 1; i <= a; i++)
            {
                for(j = 1; j <= i; j++)
                {
                    Console.Write(i);
                } 
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
