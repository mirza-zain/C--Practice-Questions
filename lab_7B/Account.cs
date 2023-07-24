using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_7B
{
    internal class Account
    {
        protected double balance = 10000;

        public void Deposit()
        {
            Console.WriteLine("Enter The Amount");
            balance = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Your Balance Was Updated");
        }
        public void Withdrew()
        {
            int withdrew;
            Console.WriteLine("Enter The Amount");
            withdrew = Int32.Parse(Console.ReadLine());
            if (withdrew <= balance)
            {
                balance = withdrew - balance;
            }
            else
            {
                Console.WriteLine("Invalid Amount");
            }
        }
        public double GetBalance()
        {
            return balance;
        }
        public void Option()
        {
            Console.WriteLine("Choose One Option");
            Console.WriteLine("1 Deposit Money\n2 Withdrew Money\n3 Check Balance");
            int option;
            option = Int32.Parse(Console.ReadLine());
            if(option == 1)
            {
                Deposit();
            }
            else if(option == 2)
            {
                Withdrew();
            }    
            else if(option == 3)
            {
                Console.WriteLine("Your Balance Is {0}", balance);
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
      
        public class Saving_Accounts : Account
        {
            double interest;

            public void InterestRate()
            {
                interest = balance * 2;
                balance += interest;
                Console.WriteLine("YOU GOT INTEREST WHICH WAS 2X OF YOUR BALANCE");
                Console.WriteLine("Your Remaining Balance Is {0}", interest);
            }
        }
        public class Checking_Account : Account
        {
            public void Checking()
            {
                Double fee;
                fee = balance - 200;
                Console.WriteLine("YOUR TRANSACTION FEES WAS 200");
                Console.WriteLine("Your Remaining Balance Is {0}", fee);
            }
        }
    }
}
