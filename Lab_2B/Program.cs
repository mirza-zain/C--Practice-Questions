using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter Your Age");
            a = Int32.Parse(Console.ReadLine());
            if(a >= 45)
            {
                Console.WriteLine("You are old stay at Home and wait for the call");
            }
            else if(a <= 35 && a >= 25)
            {
                Console.WriteLine("Hey! Man, Enjoy your life with your kids");
            }
            else
            {
                Console.WriteLine("Enjoy your life while you are Young");
            }
            Console.ReadKey();
        }
    }
}
