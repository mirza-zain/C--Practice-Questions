using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle obj1 = new Rectangle();
            obj1.inputdetails();
            obj1.perimeter();
            obj1.area();
            obj1.square();

            Console.ReadKey();
        }
    }
}
