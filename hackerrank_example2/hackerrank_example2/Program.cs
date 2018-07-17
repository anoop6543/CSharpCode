using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrank_example2
{
    class Solution
    {
        static void Main(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            string input_length = Console.ReadLine();
            int in_length = Convert.ToInt16(input_length);
            string input = Console.ReadLine();
            char[] char_array = input.ToCharArray();
            int count_C = 0;
            int count_G = 0;
            int count_T = 0;
            int count_A = 0;
            bool C_count = false;
            bool G_count = false;
            bool T_count = false;
            bool A_count = false;
            bool stable = false;

            for (int i = 0; i < in_length; i++)
            {
                if (char_array[i] == 'C')
                { count_C++; }
                else if (char_array[i] == 'G')
                { count_G++; }
                else if (char_array[i] == 'T')
                { count_T++; }
                else if (char_array[i] == 'A')
                { count_A++; }
            }

            if (count_C == (in_length/4))
                { C_count = true; }
            if (count_G == (in_length/4))
                { G_count = true; }
            if (count_T == (in_length/4))
                { T_count = true; }
            if (count_A == (in_length/4))
                { A_count = true; }

            Console.WriteLine("{0},{1}", C_count, count_C);
            Console.WriteLine("{0},{1}", G_count, count_T);
            Console.WriteLine("{0},{1}", T_count, count_T);
            Console.WriteLine("{0},{1}", A_count, count_A);

            if (C_count && G_count && T_count && A_count)
                {
                    stable = true;
                    Console.WriteLine("0");
                    Console.ReadKey();
                }
            else
                {
                    stable = false;
                    Console.ReadKey();
                }

            if (stable != true)
                {
                    Console.WriteLine("1");
                    Console.ReadKey();
                }
        }
    }
}
