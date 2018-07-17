using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7_Assignment
{
    class Degree
    {
        //CourseList
        private List<Course> course_list { get; set; }

        public Degree(List<Course> CourseList)
        {
            this.course_list = CourseList;
        }

        internal List<Course> Course_list
        {
            get
            {
                return course_list;
            }

            set
            {
                course_list = value;
            }
        }
    }
}
