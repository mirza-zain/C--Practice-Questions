using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, sum;
            sum = 0;
            
            for(i = 2;i <= 100;i += 3)
            {
                sum += i;
            }
            Console.WriteLine("Total Sum {0}", sum);

            Console.ReadKey();
        }
    }
}
