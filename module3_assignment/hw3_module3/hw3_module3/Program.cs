using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw3_module3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Students Details
                String First;
                String Last;
                DateTime birthday;
                String Hometown;
                String FathersName;
                GetStudentInformation(out First, out Last, out birthday, out Hometown, out FathersName);
                //GetInfo(out First, out Last, out birthday, out Hometown, out FathersName);
                PrintStudentDetails(First, Last, birthday, Hometown, FathersName);
                Console.ReadKey();

                //Teachers Details
                String T_First;
                String T_Last;
                DateTime T_birthday;
                //string T_Hometown;
                String T_Course;
                GetTeachersInformation(out T_First, out T_Last, out T_birthday, out T_Course);
                //GetInfo(out T_First, out T_Last, out T_birthday, out T_Hometown, out T_Course);
                PrintTeacherDetails(T_First, T_Last, T_birthday, T_Course);

                Console.ReadKey();


                //Course Details
                String CourseName;
                String CourseCode;
                String CourseDescription;
                GetCourseInformation(out CourseName, out CourseCode, out CourseDescription);
                PrintCourseDetails(CourseName, CourseCode, CourseDescription);
                Console.ReadKey();

                //Degree Details
                String DegreeName;
                String DepartmentsList;
                String Misc_Info;
                GetDegreeInformation(out DegreeName, out DepartmentsList, out Misc_Info);
                PrintDegreeDetails(DegreeName, DepartmentsList, Misc_Info);
                Console.ReadKey();
               
                //Validate StudentDOB case
                //try
                //{
                ValidateStudentDOB(birthday);
                //}

                //catch (NotImplementedException notImp)
                //{
                //Console.WriteLine(notImp.Message);
                //}
            }
            catch (FormatException)
            {
                Console.WriteLine("Format Exception");
                Console.ReadKey();
            }
        }

        static void GetStudentInformation(out string FirstName, out string LastName, out DateTime DOB, out string Hometown, out string FathersName )
        {
            Console.WriteLine("Enter the student's First Name:");
            FirstName = Console.ReadLine();
            Console.WriteLine("Enter the student's Last Name:");
            LastName = Console.ReadLine();
            Console.WriteLine("Enter the student's Date of Birth:");
            DOB = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter the student's Hometown:");
            Hometown = Console.ReadLine();
            Console.WriteLine("Enter the student's Father's Name:");
            FathersName = Console.ReadLine();
        }

        /*static void GetInfo(out string FirstName, out string LastName, out DateTime birthday, out string Hometown, out string FathersName)
        {
            Console.WriteLine("Enter First Name:");
            FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name:");
            LastName = Console.ReadLine();
            Console.WriteLine("Enter Date of Birth:");
            birthday = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter Hometown:");
            Hometown = Console.ReadLine();
            Console.WriteLine("Enter Father's Name:");
            FathersName = Console.ReadLine();
        }*/

        static void GetTeachersInformation(out string T_FirstName, out string T_LastName, out DateTime T_DOB, out string T_Course)
        {
            Console.WriteLine("Enter the Teacher's First Name:");
            T_FirstName = Console.ReadLine();
            Console.WriteLine("Enter the Teacher's Last Name:");
            T_LastName = Console.ReadLine();
            Console.WriteLine("Enter the Teacher's Date of Birth:");
            T_DOB = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter the Teacher's Course:");
            T_Course = Console.ReadLine();
        }
        
        static void GetCourseInformation(out string CourseName, out string CourseCode, out string CourseDescription)
        {
            Console.WriteLine("Enter the Course Name:");
            CourseName = Console.ReadLine();
            Console.WriteLine("Enter the Course Code:");
            CourseCode = Console.ReadLine();
            Console.WriteLine("Enter the COurse brief description:");
            CourseDescription = Console.ReadLine();
        }

        static void GetDegreeInformation(out string DegreeName, out string DepartmentsList, out string Misc_Details)
        {
            Console.WriteLine("Enter the Degree Name:");
            DegreeName = Console.ReadLine();
            Console.WriteLine("Enter various Departments");
            DepartmentsList = Console.ReadLine();
            Console.WriteLine("Miscellaneous details");
            Misc_Details = Console.ReadLine();
        }

        static void PrintStudentDetails(string FirstName, string LastName, DateTime DOB, string Hometown, string FathersName)
        {
            Console.WriteLine("{0} {1} was born on: {2} at {3} and his Fathers Name is {4}", FirstName, LastName, DOB.ToString("d"), Hometown, FathersName);
        }

        static void PrintTeacherDetails(string T_FirstName, string T_LastName, DateTime T_DOB, string T_Course)
        {
            Console.WriteLine("{0} {1} was born on: {2} and teaches {3}", T_FirstName, T_LastName, T_DOB.ToString("d"), T_Course);
        }

        static void PrintCourseDetails(string CourseName, string CourseCode, string Course_Description)
        {
            Console.WriteLine("Course name is {0} and code is {1}. Course Description is {2}",CourseName, CourseCode, Course_Description);
        }

        static void PrintDegreeDetails(string Degree_Name, string Departments, string Misc_Info)
        {
            Console.WriteLine("Degree is {0} and various departments offering this Degree are {1}", Degree_Name, Departments);
            Console.WriteLine("Misscelaneous Information of Degree is {0}", Misc_Info);
        }

        static void ValidateStudentDOB(DateTime DOB)
        {
            //throw new NotImplementedException();
        }
    }
}
