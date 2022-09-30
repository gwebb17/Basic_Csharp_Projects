using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmissionAssignment280
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1Object = new Class1(); //instantiate object 

            Console.WriteLine("Please enter one number");
            int answer1 = Convert.ToInt32(Console.ReadLine()); //save first entered number as int var
            Console.WriteLine("Enter an optional second number");

            try   //if we don't enter a second param we will get errors, so in order to have a solution we use a try/catch
            {
                int answer2 = Convert.ToInt32(Console.ReadLine());   //this trys to run program as if user entered both params
                int mainResult1 = class1Object.Method1(answer1, answer2);
                Console.WriteLine(mainResult1);
            }
            catch  //in the event user doesn't enter 2nd param (y), we will simply run Method1 without 2nd param and display that result 
            {
                int mainResult1 = class1Object.Method1(answer1);
                Console.WriteLine(mainResult1);
                
            }


          




            Console.ReadLine();

        }
    }
}
