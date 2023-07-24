using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintFuc p = new PrintFuc();
            String a = p.input();
            Console.WriteLine("Your Input is {0}", a);
        }
    }
    public class PrintFuc
    {
        public String input()
        {
            String a;
            a = Console.ReadLine();
            return a;
        }
    }
}
