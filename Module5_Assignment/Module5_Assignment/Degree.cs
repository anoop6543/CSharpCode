using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5_Assignment
{
    class Degree
    {
        //CourseList
        public List<Course> Course_list { get; set; }

        public Degree(List<Course> CourseList)
        {
            this.Course_list = CourseList;
        }
    }
}
