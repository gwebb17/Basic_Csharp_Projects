using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchChallenge226
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Guess a #");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 12; //this returns true or false (does number ==12? if yes then TRUE


            do
            {
                switch (number)
                {
                    case 62:
                        Console.WriteLine("you guessed 62");
                        Console.WriteLine("Guess a #");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 29:
                        Console.WriteLine("you guessed 29");
                        Console.WriteLine("Guess a #");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 55:
                        Console.WriteLine("you guessed 55");
                        Console.WriteLine("Guess a #");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 12:
                        Console.WriteLine("guessed 12 yay");
                        isGuessed = true; //set isGuessed to true when correct # guessed
                        break;
                    default:
                        Console.WriteLine("you are wrong");
                        Console.WriteLine("Guess a #");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isGuessed); //this says while isGuessed is Not True. once its true the do statement exits
            
            Console.ReadLine();
                
            
           
        }
    }
}
