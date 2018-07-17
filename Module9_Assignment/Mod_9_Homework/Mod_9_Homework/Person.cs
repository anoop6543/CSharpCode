using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_9_Homework
{ 
    class Person
    {
        private string First_Name;
        private string Last_Name;
        private DateTime DOB;
        private string Country;
        private string City;

        public string first_Name
        {
            get
            {
                return First_Name;
            }

            set
            {
                First_Name = value;
            }
        }

        public string last_Name
        {
            get
            {
                return Last_Name;
            }

            set
            {
                Last_Name = value;
            }
        }

        public string dob
        {
            get
            {
                return Convert.ToString(DOB);
            }

            set
            {
                DOB = Convert.ToDateTime(value);
            }
        }

        public string country
        {
            get
            {
                return Country;
            }

            set
            {
                Country = value;
            }
        }

        public string city
        {
            get
            {
                return City;
            }

            set
            {
                City = value;
            }
        }
    }
}
