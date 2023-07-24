using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_7A
{
    internal class Student
    {
        String name;
        String Reg;

        public void inputdetails()
        {
            Console.WriteLine("Enter Your Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter Your Roll No");
            Reg = Console.ReadLine();
        }
        public void Output()
        {
            Console.WriteLine("\nChoose One Department");
            Console.WriteLine("\n1 Computer Science \n2 Pre Medical \n3 Pre Engineering");
            int option;
            option = Int32.Parse(Console.ReadLine());
            if (option == 1)
            {
                Marksheet.ComputerScience computer = new Marksheet.ComputerScience();
                computer.Result();
                computer.Average();
            }
            else if (option == 2)
            {
                Marksheet.Pre_Medical medical = new Marksheet.Pre_Medical();
                medical.Result();
                medical.Average();
            }
            else if(option == 3)
            {
                Marksheet.Pre_Engineering engineering = new Marksheet.Pre_Engineering();
                engineering.Result();
                engineering.Average();
            }
            else
            {
                Console.Write("Invalid Number");
            }
        }
    }
}
