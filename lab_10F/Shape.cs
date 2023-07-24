using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_10F
{
    interface IShape
    {
        void SName();
        void SArea();
    }
    public class Shape : IShape
    {
        String name;
        public void SName()
        {
            this.name = Console.ReadLine();
        }
        public void SArea()
        {
            Console.WriteLine("Enter Length");
            int length = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Width");
            int width = Int32.Parse(Console.ReadLine());
            if(length == width)
            {
                Console.WriteLine("It's Square");
            }
            else
            {
                Console.WriteLine("It's Rectangular");
            }
        }

    }
}
