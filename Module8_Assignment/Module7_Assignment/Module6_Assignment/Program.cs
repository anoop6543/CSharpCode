using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Module7_Assignment
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
            Student Student3 = new Student("Anoop", "Viswa", new DateTime(1992, 08, 08), "Italy");

            //Pushing the grades into student1 
            Student1.Grades.Push(90);
            Student1.Grades.Push(80);
            Student1.Grades.Push(85);
            Student1.Grades.Push(82);
            Student1.Grades.Push(79);
            //Pushing the grades into student2
            Student2.Grades.Push(78);
            Student2.Grades.Push(95);
            Student2.Grades.Push(83);
            Student2.Grades.Push(91);
            Student2.Grades.Push(90);
            //Pushing the grades into student3 
            Student3.Grades.Push(90);
            Student3.Grades.Push(80);
            Student3.Grades.Push(90);
            Student3.Grades.Push(80);
            Student3.Grades.Push(75);

            //Initiated Teachers
            Teacher Teacher1 = new Teacher("Maria", "Ryan", new DateTime(1983, 04, 23), "Switzerland");

            //Initiated Students and Teachers Array
            var Teachers = new Teacher[] { Teacher1 };
            var students = new Student[] { Student1, Student2, Student3 };

            //Description of Course in a string
            string CourseDescription = "Welcome to Computer Programming with C#";

            //Instantiating new Course object
            var Course1 = new Course("Computer Programming with c#", "Code111", CourseDescription, Teachers);
            Courses.Add(Course1);

            //Adding the Students to ArrayList in Course1 object
            Course1.Students.Add(Student1);
            Course1.Students.Add(Student2);
            Course1.Students.Add(Student3);
            
            //Printing the Array List
            Course1.ListStudents(Course1.Students);

            //IComparer myComparer = new myCompareClass();
            //try
            //{
            //    ////Sorted
            //    Course1.Students.Sort(myComparer);
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine("The exception message is {0}", e.Message);
            //}
            ////Printing the sorted ArrayList
            //Course1.ListStudents(Course1.Students);

            Console.WriteLine("Before popping the fist element is {0}", Student1.Grades.First());
            Student1.Grades.Pop();//removes the top item(last entered item)
            Course1.Replace_last_grade(Student1, 65);

            Student1.Grades.Push(65);//Replaces the top item in grades of student1
            Console.WriteLine("After pushing new item the first element is {0}", Student1.Grades.First());

            Course1.Student_Details(Course1.Students);

            Course1.Replace_third_element(Student2);
            
        }
         

        


        public class myCompareClass : IComparer
        {

            // Calls CaseInsensitiveComparer.Compare with the parameters reversed.
            int IComparer.Compare(Object x, Object y)
            {
                return ((new CaseInsensitiveComparer()).Compare(y, x));
            }

        }

        

    }
}