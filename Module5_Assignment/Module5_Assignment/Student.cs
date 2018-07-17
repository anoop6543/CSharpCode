using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5_Assignment
{
    class Student
    {
        private String First_Name { get; set; }
        private String Last_Name { get; set; }
        private DateTime Birthdate { get; set; }
        private String Country { get; set; }

        //Student Constructor
        public Student(string First_Name, string Last_Name, DateTime dateTime, string Country)
        {
            this.First_Name = First_Name;
            this.Last_Name = Last_Name;
            this.Birthdate = dateTime;
            this.Country = Country;
        }
    }
}
