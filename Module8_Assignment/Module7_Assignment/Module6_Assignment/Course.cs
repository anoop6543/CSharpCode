using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7_Assignment
{
    class Course
    {
        //Properties of the Course
        private String CourseName;// { get; set; }
        private String CourseCode; //{ get; set; }
        private String CourseDescription;// { get; set; }

        //public Student[] Students = new Student[3];
        //private ArrayList students = new ArrayList();
        private List<Student> students = new List<Student>();

        Teacher[] Teachers = new Teacher[3];

        public string CourseName1
        {
            get
            {
                return CourseName;
            }

            set
            {
                CourseName = value;
            }
        }

        public string CourseCode1
        {
            get
            {
                return CourseCode;
            }

            set
            {
                CourseCode = value;
            }
        }

        public string CourseDescription1
        {
            get
            {
                return CourseDescription;
            }

            set
            {
                CourseDescription = value;
            }
        }

        public List<Student> Students
        {
            get
            {
                return students;
            }

            set
            {
                students = value;
            }
        }


        //Constructor for Course
        public Course(string CourseName, string CourseCode, string CourseDescription, Teacher[] Teachers)
        {
            this.CourseName1 = CourseName;
            this.CourseCode1 = CourseCode;
            this.CourseDescription = CourseDescription;
            this.Teachers = Teachers;
        }

        //Printign list of students
        public void ListStudents(List<Student> students_1)
        {
            int i = 0;
            foreach (Student student in students_1)
            {
                Student student_11 = (Student)students_1[i];
                Console.WriteLine("First Name : {0} , Last Name : {1}", student_11.first_Name, student_11.last_Name);
                i++;
            }
        }

        //Printing Students details
        public void Student_Details(List<Student> students)
        {
            foreach (Student student in students)
            {
                int[] temp = new int[student.Grades.Count];
                temp = student.Grades.ToArray();
                Console.WriteLine("First Name : {0} , Last Name : {1}, Grades are {2} {3} {4} {5} {6}", student.first_Name, student.last_Name,temp[0], temp[1], temp[2], temp[3], temp[4]);
            }
        }

        //Replacing 3rd element of Grades in any student object
        public void Replace_third_element(Student student_11)
        {
            if (student_11.Grades.Count > 4)
            {
                int[] a1 = new int[student_11.Grades.Count];
                a1 = student_11.Grades.ToArray();
                Console.WriteLine("The grades of student before clearing are {0},{1},{2},{3},{4}", a1[0], a1[1], a1[2], a1[3], a1[4]);
                a1[2] = 55;
                student_11.Grades.Clear();
                student_11.Grades.Push(a1[4]);
                student_11.Grades.Push(a1[3]);
                student_11.Grades.Push(a1[2]);
                student_11.Grades.Push(a1[1]);
                student_11.Grades.Push(a1[0]);
                int[] a2 = new int[student_11.Grades.Count];
                a2 = student_11.Grades.ToArray();
                Console.WriteLine("The grades of student after clearing and replacng with new element at 3rd position are {0},{1},{2},{3},{4}", a2[0], a2[1], a2[2], a2[3], a2[4]);
            }

        }

        public void Replace_last_grade(Student student_11, int new_grade)
        {
            if (student_11.Grades.Count > 4)
            {
                student_11.Grades.Pop();
                student_11.Grades.Push(new_grade);
                int[] a2 = new int[student_11.Grades.Count];
                a2 = student_11.Grades.ToArray();
                Console.WriteLine("The grades of student after clearing and replacng with new element at 3rd position are {0},{1},{2},{3},{4}", a2[0], a2[1], a2[2], a2[3], a2[4]);
            }
        }
    }
}
