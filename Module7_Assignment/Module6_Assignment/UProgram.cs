using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7_Assignment
{
    class UProgram
    {
        private string uProgramName { get; set; }
        private List<Degree> degrees = new List<Degree>();

        public string UProgramName
        {
            get
            {
                return uProgramName;
            }

            set
            {
                uProgramName = value;
            }
        }

        internal List<Degree> Degrees
        {
            get
            {
                return degrees;
            }

            set
            {
                degrees = value;
            }
        }

        //UProgram Constructor
        public UProgram(string Uprogram_Name)
        {
            this.UProgramName = Uprogram_Name;

        }
    }
}
