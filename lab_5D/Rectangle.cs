using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5D
{
    internal class Rectangle
    {
        int width;
        int length;
        
        public void inputdetails()
        {
            Console.WriteLine("Enter Width");
            this.width = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Length");
            this.length = Int32.Parse(Console.ReadLine());
        }
        
        public void perimeter()
        {
            int perimeter;
            perimeter = (length + width) * 2;
            Console.WriteLine("Perimeter of Rectangle is {0}", perimeter);
        }

        public void area()
        {
            int area;
            area = length * width;
            Console.WriteLine("Area of Rectangle is {0}", area);
        }

        public void square()
        {
            if(width == length)
            {
                Console.WriteLine("It's Square");
            }
            else
            {
                Console.WriteLine("It's Not Square");
            }

        }
    }
}
