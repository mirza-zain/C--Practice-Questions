using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5E
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAcc user = new BankAcc();
            user.inputdetails();
            user.account();

            Console.ReadKey();
        }
    }
}
