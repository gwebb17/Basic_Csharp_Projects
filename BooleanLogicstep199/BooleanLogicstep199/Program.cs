using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicstep199
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int age1 = Convert.ToInt32(age); //convert above input to # for use in comparison statement below

            Console.WriteLine("Have you ever had a DUI?");
            string dui = Console.ReadLine();
            bool dui1 = (dui == "yes" || dui == "Yes" || dui == "YES"); //if someone types "yes" or "Yes" or "YES" we get a true result and save as such otherwise var is = false

            Console.WriteLine("How many speeding tickets do you have?");
            string tickets = Console.ReadLine();
            int tickets1 = Convert.ToInt32(tickets); //converts input into # for use in comparison statement below

            Console.WriteLine("Qualified?");
            bool qualified = (age1 > 15 && dui1 == false && tickets1 < 4); //given the 3 outlined qualifications, if each qualification is true (passes), 
            Console.WriteLine(qualified);                                  //display result to answer above question "Qualified?" 


            Console.ReadLine(); //keeps screen open until closed
        }
    }
}
