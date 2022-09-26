using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingSubmissionAssignment222
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("What is the package weight?");
            decimal pweight = Convert.ToDecimal(Console.ReadLine()); //saves input and converts to # format

            if (pweight > 50) //if input greater than 50
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");

            }
            else
            {
                Console.WriteLine("What is the package width?");
                decimal pwidth = Convert.ToDecimal(Console.ReadLine()); //saves input from above ? and converts to # format
                Console.WriteLine("What is the package height?");
                decimal pheight = Convert.ToDecimal(Console.ReadLine()); //saves input from above ? and converts to #
                Console.WriteLine("What is the package length?");
                decimal plength = Convert.ToDecimal(Console.ReadLine()); //saves input from above ? and converts to #

                decimal dimensionTotal = pwidth + pheight + plength; //adds up 3 dimensions saves as decimal
                if (dimensionTotal > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express");
                }

                else
                {



                    decimal factorDimension = pwidth * pheight * plength; //saves product of dimensions as decimal
                    decimal finalWeight = pweight * factorDimension; //multiply decimal weight by dimension product
                    decimal quotientDimension = finalWeight / 100; //divides product by 100 saves as decimal
                    Console.WriteLine("Your estimated total for shipping this package is: " + String.Format("{0:C}", quotientDimension) + "\nThank You");
                    //above is the way to format for price and insert that formatted result to console message
                }
            }
            //prints message and divided product in a price aesthetic and thank you message in newline

           
           
            Console.ReadLine(); //keeps screen open until closed
        }
    }
}
