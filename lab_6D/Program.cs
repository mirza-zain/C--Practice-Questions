using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee user1 = new Employee();
            Console.WriteLine("Enter Your Name");
            user1.Name = Console.ReadLine();
            Console.WriteLine("Enter Your Department");
            user1.Department = Console.ReadLine();
            Console.WriteLine("Enter Your Designation");
            user1.Design = Console.ReadLine();
            user1.PrintInfo();

            Console.ReadKey();
        }
    }
}
