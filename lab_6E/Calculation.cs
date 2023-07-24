using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6E
{
    internal class Calculation
    {
        private int num1;
        private int num2;

        public void inputvalue()
        {
            Console.WriteLine("Enter 1st Number");
            this.num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number");
            this.num2 = Int32.Parse(Console.ReadLine());
        }

        public void Add()
        {
            int sum;
            sum = this.num1 + this.num2;
            Console.WriteLine("Addition of Two Number Is {0}", sum);
        }

        public void Sub()
        {
            int subtract;
            subtract = this.num1 - this.num2;
            Console.WriteLine("Addition of Two Number Is {0}", subtract);
        }
    }
}
