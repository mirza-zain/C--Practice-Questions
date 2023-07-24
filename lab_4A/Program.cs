using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintFuc p = new PrintFuc();
            p.display();

            Console.ReadKey();
        }
    }
    public class PrintFuc
    {
        public void display()
        {
            Console.WriteLine("Hello World");
        }
    }
}
