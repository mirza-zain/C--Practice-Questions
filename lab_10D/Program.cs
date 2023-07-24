using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_10D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pet pet = new Pet();
            Console.WriteLine("What is your pet's name?");
            String name = Console.ReadLine();
            pet.AName(name);

            Console.ReadKey();
        }
    }
}
