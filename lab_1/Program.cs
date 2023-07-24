using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, sum, div, mul, rem, sub;
            Console.WriteLine("Enter First Number");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            b = Int32.Parse(Console.ReadLine());
            sum = a + b;
            div = a / b;
            mul = a * b;
            rem = a % b;
            if(a > b)
            {
                sub = a - b;
            }
            else
            {
                sub = b - a;
            }
            Console.WriteLine("A = {0} \nB = {1} \nSum = {2} \nSubtract = {3} \nDivide = {4} \nMultiplication = {5} \nReminder = {6}", a, b, sum, sub, div, mul, rem);
            Console.ReadKey();
        }
    }
}
