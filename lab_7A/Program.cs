using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_7A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.inputdetails();
            student.Output();

            Console.ReadKey();
        }
    }
}
