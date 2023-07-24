using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6E
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculation user = new Calculation();
            user.inputvalue();
            user.Add();
            user.Sub();

            Console.ReadKey();
        }
    }
}
