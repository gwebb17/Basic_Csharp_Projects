using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace DateTimeAssignment370
{
    class Program
    {
        public static void Main(string[] args)
        {
            DateTime currentDate = DateTime.Now;  //set new var of object type DateTime to current time/date
            Console.WriteLine(currentDate); //display this new var

            Console.WriteLine("Please enter a number");
            DateTime x = Convert.ToDateTime(Console.ReadLine());

            TimeSpan futureDateDifference = currentDate - x; //gets difference between time entered and current time
            DateTime answer = currentDate.Add(futureDateDifference); //adds difference to current time
            Console.WriteLine(answer); //can successfully print the result of the difference in times, however the user must enter time exactly 
            //as it is formatted in line 16 that displays in console. Unsure how to further specify to use int values .


            Console.ReadLine();
        }
    }
} 
