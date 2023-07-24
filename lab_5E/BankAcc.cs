using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab_5E
{
    internal class BankAcc
    {

        String name;
        int balance;
        int withdrew;
        int deposit;
        int interest;

        public void inputdetails()
        {
            Console.WriteLine("Welcome To Mirza Bank");
            Console.WriteLine("\n\nEnter Your Name");
            name = Console.ReadLine();
            balance = 50000;
        }

        public void BalanceMoney()
        {
            Console.WriteLine("\nYour Balance is {0}", balance);
        }
        public void DepositMoney()
        {
            Console.WriteLine("Enter the amount you want to deposit");
            deposit = Int32.Parse(Console.ReadLine());
            balance = deposit + balance;
            Console.WriteLine("\nYou have successfully deposited {0} \n Your Balance Now Is {1}", deposit, balance);
        }
        
        public void WithdrewMoney()
        {
            write: Console.WriteLine("How much you want to Withdrew");
            withdrew = Int32.Parse(Console.ReadLine());
            if(withdrew <= balance)
            { 
                interest = 50;
                balance = balance - withdrew - interest;
            }
            else
            {
                Console.WriteLine("\nInvalid Amount");
                goto write;
            }
            Console.WriteLine("\nYou have Withdrew {0} \n Your Remaining Balance is {1}", withdrew, balance);
        }

        public void account()
        {
            start: int option;
            Console.WriteLine("\n\nSelect one option\n");
            Console.WriteLine("1 Check Balance \n2 Deposit Money \n3 Withdrew Money \n4 End");
            option = Int32.Parse(Console.ReadLine());

            switch(option)
            {
                case 1:
                    BalanceMoney();
                    goto start;
                case 2:
                    DepositMoney();
                    goto start;
                case 3:
                    WithdrewMoney();
                    goto start;
                case 4:
                    Console.WriteLine("You have Successfully Quitted Program");
                    break;
                default:
                    Console.WriteLine("You Have Writtern Invalid Number");
                    break;
            }
        }
    }
}
