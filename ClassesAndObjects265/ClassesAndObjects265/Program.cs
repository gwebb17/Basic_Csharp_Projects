using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassesAndObjects265
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Welcome to the Completely Fictional Hotel and Casino, please enter your name: ");
            string playerName = Console.ReadLine();
            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello {0}. Would you like to play a game?", playerName);
            string answer = Console.ReadLine().ToLower(); //convert answer to lowercase makes it easier to check response below

            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")  //if they want to play we create player from them and new game
            {
                Player player = new Player(playerName, bank); //create new player with name and bank props
                Game game = new TwentyOneGame();  //create new game
                game += player; //Add player to the newly created game

                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)  //loop that executes when player is playing and has balance > 0
                {
                    game.Play(); //Play defined in TwentyOneGame
                }
                game -= player; //if player isn't playing remove player from game
                Console.WriteLine("Thanks for playing"); //triggers after player stops playing and is removed from game
            }
            
            Console.WriteLine("Feel free to look around the casino bye bye");


            Console.ReadLine();
        }
    }
}
