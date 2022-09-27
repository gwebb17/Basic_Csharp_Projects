using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSubmissionAssignment229
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Name the largest country in the Middle East by area");
            string guess = Console.ReadLine();
            bool correctAnswer = guess == "Saudi Arabia"; //returns true or false if guess == correct country

            do
            {
                switch (guess)
                {
                    case "Iraq":
                        Console.WriteLine("Sorry wrong guess. Try again.");
                        Console.WriteLine("Name the largest country in the Middle East by area");
                        guess = Console.ReadLine(); //don't need to specify data type when redefining guess subsequent times
                        break;
                    case "Iran":
                        Console.WriteLine("Sorry wrong guess. Try again.");
                        Console.WriteLine("Name the largest country in the Middle East by area");
                        guess = Console.ReadLine();
                        break;
                    case "India":
                        Console.WriteLine("That one's in Asian. Try Again.");
                        Console.WriteLine("Name the largest country in the Middle East by area");
                        guess = Console.ReadLine();
                        break;
                    case "Saudi Arabia":
                        Console.WriteLine("You are correct.");
                        correctAnswer = true; //set bool to true if correct in order to exit loop 
                        break;
                    default:
                        Console.WriteLine("Here's a hint; there are two words in the country name");
                        Console.WriteLine("Name the largest country in the Middle East by area");
                        guess = Console.ReadLine();
                        break;

                }
            }

            while (!correctAnswer); //this says do the above switch statement only while correctAnswer is NOT TRUE
            


            Console.WriteLine("Enter an even number:");
            int number = Convert.ToInt32(Console.ReadLine());

            while (number % 2 != 0)
            {
                Console.WriteLine("You entered an odd number, try again");
                Console.WriteLine("Enter an even number:");
                number = Convert.ToInt32(Console.ReadLine());
                break;


            }
            if (number % 2 == 0)
            {
                Console.WriteLine("You did it");
            }
            Console.ReadLine();



        }
    }
}
