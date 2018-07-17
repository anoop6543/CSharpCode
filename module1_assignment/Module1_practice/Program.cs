using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            String First_Name;
            String Last_Name;
            String Birthdate;
            String AddressLine1;
            String AddressLine2;
            String City;
            String State_Province;
            long Zip_Postal;
            String Country;

            Console.WriteLine("First Name is :");
            First_Name = Console.ReadLine();
            Console.WriteLine("Last Name is :");
            Last_Name = Console.ReadLine();
            Console.WriteLine("BirthDate is :");
            //Birthdate = Convert.ToDateTime(Console.ReadLine());
            Birthdate = Console.ReadLine();
            Console.WriteLine("AddressLine1 is :");
            AddressLine1 = Console.ReadLine();
            Console.WriteLine("AddressLine2 is :");
            AddressLine2 = Console.ReadLine();
            Console.WriteLine("City is :");
            City = Console.ReadLine();
            Console.WriteLine("State/Province is :");
            State_Province = Console.ReadLine();
            Console.WriteLine("Zip/Postal is :");
            Zip_Postal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Country is :");
            Country = Console.ReadLine();
            Console.ReadKey();
            Console.WriteLine("Details of Student are \n First Name : {0} \n Last Name : {1} \n BirthDate : {2} \n Address Line1 : {3} \n Address Line2 : {4} \n City : {5} \n State/Province : {6} \n Zipcode: {7} \n Country : {8}", First_Name, Last_Name, Birthdate , AddressLine1, AddressLine2 , City , State_Province , Zip_Postal , Country);
            Console.ReadKey();
            Console.ReadKey(); 
        }

    }
}
