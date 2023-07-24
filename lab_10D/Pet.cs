using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_10D
{
    public interface IAnimal
    {
        void AName(string name);
    }

    public class Pet : IAnimal
    {
        public void AName(string name)
        {
            Console.WriteLine("I am a cat and my name is: " + name);
        }
    }
}
