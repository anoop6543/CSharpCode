using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module2_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j;
            string pin = "";
            for (i = 0; i <= 7; i++)
            {
                for(j=0; j<=3; j++)
                {
                    if((i == 1) || (i == 3) || (i == 5) || (i == 7))
                    {
                        pin = pin + "OX";
                    }
                    else
                    {
                        pin = pin + "XO";
                    }
                }
                Console.WriteLine(pin);
                pin = "";              
            }
            Console.ReadKey();
        }
    }
}