using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Course> Courses = new List<Course>();

            //Initiated Person
            Person person1 = new Person();

            //Initiated Students
            Student Student1 = new Student("Sam", "Paul", new DateTime(1993, 05, 14), "Australia");
            Student Student2 = new Student("Dan", "Brown", new DateTime(1992, 06, 25), "England");
            Student Student3 = new Student("Dan", "Brown", new DateTime(1992, 08, 08), "Italy");

            //Initiated Teachers
            Teacher Teacher1 = new Teacher("Maria", "Ryan", new DateTime(1983, 04, 23), "Switzerland");

            //Initiated Students and Teachers Array
            var Teachers = new Teacher[] { Teacher1 };
            var students = new Student[] { Student1, Student2, Student3 };

            //Description of Course in a string
            string CourseDescription = "Welcome to Computer Programming with C#";

            //Instantiating new Course object
            var Course1 = new Course("Computer Programming with c#", "Code111", CourseDescription, students, Teachers);
            Courses.Add(Course1);

            //Instantiating new Degree
            var Bachelors = new Degree(Courses);

            //Instantiating new UProgram
            var Information_Technology = new UProgram("Information Technology");
            Information_Technology.Degrees.Add(Bachelors);

            //Printing the UProgram details
            WriteProgramInfo(Information_Technology);
            Console.ReadKey();
        }

        private static void WriteProgramInfo(UProgram program)
        {
            try
            {
                var degree = program.Degrees.First();
                Console.WriteLine("The {0} program contains the {1} degree.\n", program.UProgramName, degree);

                var course = degree.Course_list.First();
                Console.WriteLine("The {0} degree contains the course {1}.\n", degree, course);

                Console.WriteLine("The {0} course has {1} student(s).\n", course, course.Students.Length);
            }
            catch (Exception e)
            {
                Console.WriteLine("The exception is {0}", e.Message);
            }
        }
    }
}
