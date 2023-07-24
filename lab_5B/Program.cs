using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student obj1 = new Student();
            obj1.inputdetails();
            obj1.CalculateTotalMarks();
            obj1.CalculatePercentage();

            Console.ReadKey();
        }
    }
}
