using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Vehicle("Dodge", "Dodge Challenger", 2011);
            Vehicle truck = new Vehicle("Ford", "F-150", 2022);
            Vehicle motorcycle = new Vehicle("Harley-Davidson", "Sportster", 2021);

            car.Print();
            truck.Print();
            motorcycle.Print();

            Console.ReadKey();
        }
    }
}
