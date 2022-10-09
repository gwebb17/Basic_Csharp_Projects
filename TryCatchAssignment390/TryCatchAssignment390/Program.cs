using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TryCatchAssignment390
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter your age:");
                int age = Convert.ToInt32(Console.ReadLine()); //save answer as var age
                int currentYear = 2022; 
                int currentAge = currentYear - age; //subtract age from current year to display

                int isZero = currentYear / age; //in order to raise exception DivideByZero, we must attempt division on a var by 0
                //by trying to divide currentYear (or any # really) by age we have ability to see if age = 0. and if so raise exception
                Console.WriteLine("Testing to make sure answer != 0: " + isZero); //way to watch what is being saved

                uint isNegative = Convert.ToUInt32(age);  //by using a uint value and trying to assign age to it we can raise an exception if
                //user has entered negative value. Uint can't be negative number so this is how we test it
                Console.WriteLine("uint value currently = " + isNegative); //way to watch what is being saved
               
                Console.WriteLine("Year born: " + currentAge); //display year born
                Console.ReadLine();
            }
            catch (DivideByZeroException) //this exception is what is triggered when someone attempts to divide by 0 line21
            {
           
                Console.WriteLine("Age must be > 0"); 
                Console.ReadLine();
            }
            catch (OverflowException) //this exception is what is triggered when someone attempts to enter a negative number
            {
                Console.WriteLine("Can't enter negative numbers");
                Console.ReadLine();
            }
            finally //default exception if something goes wrong and doesn't match above cases
            {
                Console.WriteLine("System error please contact administrator");
            }

            


            
        }
    }
}
