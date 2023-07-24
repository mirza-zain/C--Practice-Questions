using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, withdraw;
            withdraw = 10000;
            Console.WriteLine("Welcome To The ATM");
            Console.WriteLine("Enter The Amount to WIthdraw");
            a = Int32.Parse(Console.ReadLine());
            if(a <= 10000 || a == 10000)
            {
                Console.WriteLine("Your amount is being proccessed for withdraw");
                withdraw = withdraw - a;
                Console.WriteLine("Your Left Amount is = {0}", withdraw);
            }
            else
            {
                Console.WriteLine("You don't have enough balance");
            }
            Console.WriteLine("Thank You For Using Our Service");
            Console.ReadKey();
        }
    }
}
