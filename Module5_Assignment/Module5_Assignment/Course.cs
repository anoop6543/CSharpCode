using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5_Assignment
{

    class Course
    {
        //Properties of the Course
        private String CourseName { get; set; }
        private String CourseCode { get; set; }
        private String CourseDescription { get; set; }

        public Student[] Students = new Student[3] ;
        Teacher[] Teachers = new Teacher[3];
        

        //Constructor for Course
        public Course(string CourseName, string CourseCode, string CourseDescription, Student[] students, Teacher[] Teachers )
        {
            this.CourseName = CourseName;
            this.CourseCode = CourseCode;
            this.CourseDescription = CourseDescription;
            this.Students = students;
            this.Teachers = Teachers;
        }

        
    }
}
