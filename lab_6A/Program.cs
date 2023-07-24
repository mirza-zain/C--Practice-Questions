using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person user = new Person();
            user.Name = "Mirza Zain";
            Console.WriteLine(user.Name);

            Console.ReadKey();
        }
    }
}
