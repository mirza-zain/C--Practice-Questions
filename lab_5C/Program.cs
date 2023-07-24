using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vowel obj1 = new Vowel();
            obj1.input();
            obj1.CountVowels();

            Console.WriteLine("There are {0} vowels", obj1.CountVowels());

            Console.ReadKey();

        }
    }
}
