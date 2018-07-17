using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_9_Homework
{
    class Student : Person
    {
        public void TakeTest()
        {
            Console.WriteLine("Taking Test");
        }

        public Student(string First_Name, string Last_Name, string City)
        {
            this.first_Name = First_Name;
            this.last_Name = Last_Name;
            this.city = City;
        }
    }
}
