using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5B
{
    internal class Student
    {
        String name;
        int age;
        float marks_of_english;
        float marks_of_maths;
        float marks_of_science;
        int total_marks;
        float obtained_marks;
        float percentage;

        public void inputdetails()
        {
            Console.WriteLine("Enter Your Name?");
            name = Console.ReadLine();
            Console.WriteLine("Enter Your Age?");
            age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter English Marks");
            marks_of_english = Single.Parse(Console.ReadLine());
            Console.WriteLine("Enter Maths Marks");
            marks_of_maths = Single.Parse(Console.ReadLine());
            Console.WriteLine("Enter Science Marks");
            marks_of_science = Single.Parse(Console.ReadLine());
        }

        public void CalculateTotalMarks()
        {
            total_marks = 300;
            obtained_marks = marks_of_english + marks_of_maths + marks_of_science;
            Console.WriteLine("Your have Gotten {0} out of {1}", obtained_marks, total_marks);
        }
        public void CalculatePercentage()
            {
            percentage = (obtained_marks * 100) / total_marks;
            Console.WriteLine("Your Percentage is {0}", percentage);
        }

    }
}
