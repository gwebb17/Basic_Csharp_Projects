using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsAssignment325
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                

                Console.WriteLine("Enter the current day of the week: ");
                string answer = Console.ReadLine();  //save input as string var

                //learn to parse answer into type Day
                DaysOfWeek day = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), answer);  //creating new var day and sets it equal to answer but as enum data type
                Console.WriteLine(day);  //now day can be displayed since data types match
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Please enter an actual day of the week");  //if user input doesn't match possible values in enum definition display this message
            }
            



            Console.ReadLine();

        }

    }
}
