using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6_Assignment
{
    class Course
    {
        //Properties of the Course
        private String CourseName;// { get; set; }
        private String CourseCode; //{ get; set; }
        private String CourseDescription;// { get; set; }

        public Student[] Students = new Student[3];
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


        //Constructor for Course
        public Course(string CourseName, string CourseCode, string CourseDescription, Student[] students, Teacher[] Teachers)
        {
            this.CourseName1 = CourseName;
            this.CourseCode1 = CourseCode;
            this.CourseDescription = CourseDescription;
            this.Students = students;
            this.Teachers = Teachers;
        }


    }
}
