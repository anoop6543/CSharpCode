using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5_Assignment
{
    class Teacher
    {

        private String T_First { get; set; }
        private String T_Last { get; set; }
        private DateTime T_birthday { get; set; }

        //Teacher Constructor
        public Teacher(string First_Name, string Last_Name, DateTime Birthday)
        {
            this.T_First = First_Name;
            this.T_Last = Last_Name;
            this.T_birthday = Birthday;
        }
    }
}
