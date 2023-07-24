using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_7A
{
    internal class Marksheet
    {
        protected float English;
        protected float OOPs;
        protected float Software;
        protected float total;
        protected float sum;
        protected float percentage;
        protected float average;

        public class ComputerScience : Marksheet
        {
            public ComputerScience()
            {
                Console.WriteLine("WELCOME TO COMPUTER SCIENCE DEPARTMENT");
                Console.WriteLine("Enter Your English Marks");
                English = Single.Parse(Console.ReadLine());
                Console.WriteLine("Enter Your OOPs Marks");
                OOPs = Single.Parse(Console.ReadLine());
                Console.WriteLine("Enter Your Software Marks");
                Software = Single.Parse(Console.ReadLine());
                total = 300;
                sum = English + OOPs + Software;
                Console.WriteLine("You Got {0} out of {1}", sum, total);
            }
            public void Result()
            {
                percentage = (sum * 100) / total;
                Console.WriteLine("Percentage : {0:0.00}", percentage);
            }

            public void Average()
            {
                average = sum / 3;
                Console.WriteLine("Average : {0:0.00}", average);
            }
        }
        public class Pre_Medical : Marksheet
        {
            public Pre_Medical()
            {
                Console.WriteLine("WELCOME TO COMPUTER SCIENCE DEPARTMENT");
                Console.WriteLine("Enter Your English Marks");
                English = Single.Parse(Console.ReadLine());
                Console.WriteLine("Enter Your Zology Marks");
                OOPs = Single.Parse(Console.ReadLine());
                Console.WriteLine("Enter Your Chemistry Marks");
                Software = Single.Parse(Console.ReadLine());
                total = 300;
                sum = English + OOPs + Software;
                Console.WriteLine("You Got {0} out of {1}", sum, total);
            }
            public void Result()
            {
                percentage = (sum * 100) / total;
                Console.WriteLine("Percentage : {0:0.00}", percentage);
            }

            public void Average()
            {
                average = sum / 3;
                Console.WriteLine("Average : {0:0.00}", average);
            }
        }
        public class Pre_Engineering : Marksheet
        {
            public Pre_Engineering()
            {
                Console.WriteLine("WELCOME TO COMPUTER SCIENCE DEPARTMENT");
                Console.WriteLine("Enter Your English Marks");
                English = Single.Parse(Console.ReadLine());
                Console.WriteLine("Enter Your Maths Marks");
                OOPs = Single.Parse(Console.ReadLine());
                Console.WriteLine("Enter Your Chemistry Marks");
                Software = Single.Parse(Console.ReadLine());
                total = 300;
                sum = English + OOPs + Software;
                Console.WriteLine("You Got {0} out of {1}", sum, total);
            }
            public void Result()
            {
                percentage = (sum * 100) / total;
                Console.WriteLine("Percentage : {0:0.00}", percentage);
            }

            public void Average()
            {
                average = sum / 3;
                Console.WriteLine("Average : {0:0.00}", average);
            }
        }
    }
}
