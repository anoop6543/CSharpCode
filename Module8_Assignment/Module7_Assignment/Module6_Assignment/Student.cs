using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7_Assignment
{
    class Student : Person
    {
        public void TakeTest()
        {
            Console.WriteLine("Taking Test");
        }

        public Stack<int> Grades = new Stack<int>();
        public SortedSet<int> Grades_1 = new SortedSet<int>();


        public Student(string First_Name, string Last_Name, DateTime dateTime, string Country)
        {
            this.first_Name = First_Name;
            this.last_Name = Last_Name;
            this.dob = Convert.ToString(dateTime);
            this.country = Country;
        }

    }
}
