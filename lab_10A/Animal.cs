using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_9A
{
    interface IPet1
    {
        void Cat();
    }
    interface IPet2
    {
        void Dog();
    }
    internal class Animal
    {
        public void Cat()
        {
            Console.WriteLine("I'm a Cat and I get sad so easily");
        }
        public void Dog()
        {
            Console.WriteLine("I'm a Dog and I love human");
        }
    }
}
