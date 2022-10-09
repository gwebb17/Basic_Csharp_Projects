using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//using ClassesAndObjects265.ClassesAndObjectsLibrary265;
//using ClassesAndObjectsLibrary265;

namespace ClassesAndObjects265
{
    public class Program
    {
        static void Main(string[] args)
        {
            
           
            

            Console.WriteLine("Welcome to the Completely Fictional Hotel and Casino, please enter your name: ");
            string playerName = Console.ReadLine();

            bool validAnswer = false;   //set so we can execute a while loop on it
            int bank = 0; //set default value
            while (!validAnswer)  //which is false above so will execute
            {
                Console.WriteLine("And how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank); //TryParse searches (Console.ReadLine() so answer from line27 for int. sends out bank to be used in line 24
                //validAnswer will equal TRUE if TryParse can find int values in the answer of line27 and send that int to bank line24
                if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals."); //if validAnswer equals FALSE enter a message 
            }

            Console.WriteLine("Hello {0}. Would you like to play a game?", playerName);
            string answer = Console.ReadLine().ToLower(); //convert answer to lowercase makes it easier to check response below

            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")  //if they want to play we create player from them and new game
            {
                Player player = new Player(playerName, bank); //create new player with name and bank props
                player.Id = Guid.NewGuid();
                using StreamWriter file = new StreamWriter(@"C:\\Users\\Machine\\Documents\\practice_file.txt", true))
                {
                    file.WriteLine(player.Id);
                }
                Game game = new TwentyOneGame();  //create new game
                game += player; //Add player to the newly created game

                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)  //loop that executes when player is playing and has balance > 0
                {
                    try //try catches are written in order top to bottom of what computer will try. 
                    {
                        game.Play(); //Play defined in TwentyOneGame
                    }
                    catch (FraudException)
                    {
                        Console.WriteLine("Security Kick this person out.");
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("An error occured please contact sytem administrator");
                        Console.ReadLine();
                        return;
                    }
                    
                }
                game -= player; //if player isn't playing remove player from game
                Console.WriteLine("Thanks for playing"); //triggers after player stops playing and is removed from game
            }
            
            Console.WriteLine("Feel free to look around the casino bye bye");


            Console.ReadLine();
        }
    }
}
