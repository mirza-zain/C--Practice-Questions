﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            printfuc p = new printfuc();
            p.CheckEvOdd(5);
            p.CheckEvOdd(6);

            Console.ReadKey();
        }
    }
    public class printfuc
    {
        public void CheckEvOdd(int a)
        {
            if(a % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
    }
}
