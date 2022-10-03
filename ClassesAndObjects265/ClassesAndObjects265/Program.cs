using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects265
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new TwentyOneGame();
            game.Players = new List<Player>();
            Player player = new Player();
            player.Name = "Jesse";    
            game = game + player;   //can also say game += player for shorthand

          

            Deck deck = new Deck();   //Deck should create 52 card objects based on deck.cs file
            //deck = Shuffle(deck);  //reassign value of deck as a shuffled deck (call method Shuffle on (deck);
            deck.Shuffle(deck, 3);

                foreach (Card card in deck.Cards)    //loop to display every card using our list Cards defined in Deck file
                {
                    Console.WriteLine(card.Face + " of " + card.Suit);  
                }

            Console.WriteLine(deck.Cards.Count);   //display the amount of Cards in deck
            Console.ReadLine();
        }
    }
}
