using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_10E
{
    interface IAC
    {
        void ACOn();
        void ACOff();
    }
     public class ACInterImp
    {
        public void ACOn()
        {
            Console.WriteLine("AC is on");
        }
        public void ACOff()
        {
            Console.WriteLine("AC is off");
        }   
    }
}
