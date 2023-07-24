using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5C
{
    internal class Vowel
    {
        String name;
        public void input()
        {
            Console.WriteLine("Enter Your Name");
            name = Console.ReadLine();
        }

        public int CountVowels()
        {
            int count = 0;
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == 'a' || name[i] == 'e' || name[i] == 'i' || name[i] == 'o' || name[i] == 'u')
                {
                    count++;
                }
            }
            return count;
        }
    }
}
