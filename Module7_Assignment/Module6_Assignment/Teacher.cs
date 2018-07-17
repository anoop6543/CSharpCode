using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7_Assignment
{
    class Teacher : Person
    {
        public void GradeTest()
        {
            Console.WriteLine("Grading Test");
        }

        public Teacher(string First_Name, string Last_Name, DateTime Birthday, string Country)
        {
            this.first_Name = First_Name;
            this.last_Name = Last_Name;
            this.dob = Convert.ToString(Birthday);
            this.country = Country;
        }
    }
}
