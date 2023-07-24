using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_8
{
    internal class Vehicle
    {
        String model;
        String color;
        String engine;
        int doors;

        public Vehicle()
        {
            Console.WriteLine("Write Model Name");
            model = Console.ReadLine();
            Console.WriteLine("Write Color");
            color = Console.ReadLine();
            Console.WriteLine("Write Engine");
            engine = Console.ReadLine();
            Console.WriteLine("Write Doors");
            doors = Int32.Parse(Console.ReadLine());
        }
        public Vehicle(String model, String color, String engine, int doors)
        {
            this.model = model;
            this.color = color;
            this.engine = engine;
            this.doors = doors;
        }
        public void Start()
        {
            Console.WriteLine("Starting...");
        }   
        public void Stop()
        {
            Console.WriteLine("Stopping...");
        }   
        public void Run()
        {
            Console.WriteLine("Driving...");
        }
        public virtual void CalculateSpeed()
        {
            Console.WriteLine("Speed: 100 km/h");
        }
        public void PrintInfo()
        {
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Color: " + color);
            Console.WriteLine("Engine: " + engine);
            Console.WriteLine("Doors: " + doors);
        }
        public class Car : Vehicle
        {
            public override void CalculateSpeed()
            {
                Console.WriteLine("Speed: 200 km/h");
            }
            public Car(String model, String color, String engine, int doors) : base(model, color, engine, doors)
            {

            }

            public Car()
            {
                Start();
                Run();
                Stop();
            }
        }
        public class Bike : Vehicle
        {
            public override void CalculateSpeed()
            {
                Console.WriteLine("Speed: 50 km/h");
            }
            public Bike(String model, String color, String engine, int doors) : base(model, color, engine, doors)
            {
                model = Console.ReadLine();
                color = Console.ReadLine();
                engine = Console.ReadLine();
                doors = Int32.Parse(Console.ReadLine());
            }
            public Bike()
            {
                Start();
                Run();
                Stop();
            }
        }
    }
}
