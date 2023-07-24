using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_10C
{
    interface IAnimal
    {
        void AName();
    }   
    public class Pet : IAnimal
    {
        public void AName()
        {
            Console.WriteLine("My name is Sister Miinie");
        }
        public Pet()
        {
            Console.WriteLine("I'm a Pet");
            AName();
        }
    }
}
