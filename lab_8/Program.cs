using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Details");
            Vehicle.Car obj1 = new Vehicle.Car();
            obj1.PrintInfo();
            obj1.CalculateSpeed();
            Console.WriteLine("Bike Details");
            Vehicle.Bike obj2 = new Vehicle.Bike();
            obj2.PrintInfo();
            obj2.CalculateSpeed();

            Console.ReadKey();

        }
    }
}
