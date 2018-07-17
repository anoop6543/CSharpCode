using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5_Assignment
{
    class UProgram
    {
        public string UProgramName { get; set; }
        public List<Degree> Degrees = new List<Degree>();

        //UProgram Constructor
        public UProgram( string Uprogram_Name)
        {
            this.UProgramName = Uprogram_Name;

        }
    }
}
