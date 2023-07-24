using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_10B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Transaction transaction = new Transaction("001", "8/10/2012", 78900.00);
            transaction.showTransaction();

            Console.ReadKey();
        }
    }
}
