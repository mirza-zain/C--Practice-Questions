using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lab_6D
{
    internal class Employee
    {
        private String name;
        private String department;
        private String design;

        public String Name
        {
            set
            {
                this.name =  value;
            }
            get
            {
                return name;
            }
        }

        public String Department
        {
            set
            {
                this.department = value;
            }
            get
            {
                return department;
            }
        }

        public String Design
        {
            set
            {
                this.design = value;
            }
            get
            {
                return design;
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine("Your Name is = {0} \nYour Department = {1} \nYour Designation = {2}", name, department,
                design);
        }
    }
}
