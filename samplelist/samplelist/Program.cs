using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace samplelist
{
    class Program
    {
        static void Main(string[] args)
        {
            List<test_datatype> list1 = new List<test_datatype>();

            for(int i = 0; i < 10; i++)
            {
                test_datatype test = new test_datatype();
                test.ID = 1;
                test.location = "a1";
                test.PlotBID = "P12w344";
                list1.Add(test);
                Console.WriteLine("list1[{0}] ID - {1} , Location - {2} , PlotBID - {3}", i, list1[i].ID, list1[i].location, list1[i].PlotBID);
            }
            Console.ReadKey();
        }
    }

    class test_datatype
    {
        public int ID { get; set; }
        public string PlotBID { get; set; }
        public string location { get; set; } 
    }
}
