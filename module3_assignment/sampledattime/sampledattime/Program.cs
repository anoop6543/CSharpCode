using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sampledattime
{
    class Program
    {
        static void Main(string[] args)
        {
            //public DateTime date_now;
            DateTime datenow = DateTime.Now;
            Console.WriteLine(Convert.ToString(datenow));
            string dateonly = datenow.ToString("d");
            Console.WriteLine(dateonly);
            Console.ReadKey();
            
        }
    }
}
