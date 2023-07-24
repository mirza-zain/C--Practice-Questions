using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace lab_7B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account user = new Account();
            Account.Saving_Accounts extra = new Account.Saving_Accounts();
            Account.Checking_Account deduct = new Account.Checking_Account();
            user.Option();
            extra.InterestRate();
            deduct.Checking();

            Console.ReadKey();
        }
    }
}
