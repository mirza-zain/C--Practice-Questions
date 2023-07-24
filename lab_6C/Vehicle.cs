using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6C
{
    internal class Vehicle
    {
        private string make;
        private string model;
        private int year;

        public string Make
        {
            set { make = value; }
            get { return make; }
        }

        public string Model
        {
            set { model = value; }
            get { return model; }
        }

        public int Year
        {
            set { year = value; }
            get { return year; }
        }

        public Vehicle(string make, string model, int year)
        {
            this.make = make;
            this.model = model;
            this.year = year;
        }

        public void Print()
        {
            Console.WriteLine("\n\nMake: {0}", make);
            Console.WriteLine("Model: {0}", model);
            Console.WriteLine("Year: {0}", year);
        }
    }
}
