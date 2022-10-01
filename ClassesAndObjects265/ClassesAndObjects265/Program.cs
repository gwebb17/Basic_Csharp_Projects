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
            Deck deck = new Deck();   //Deck should create 52 card objects based on deck.cs file
            //deck = Shuffle(deck);  //reassign value of deck as a shuffled deck (call method Shuffle on (deck);
            deck = Shuffle(deck, 9);

                foreach (Card card in deck.Cards)    //loop to display every card using our list Cards defined in Deck file
                {
                    Console.WriteLine(card.Face + " of " + card.Suit);  
                }

            Console.WriteLine(deck.Cards.Count);   //display the amount of Cards in deck
            Console.ReadLine();
        }

       

        //public static Deck Shuffle(Deck deck, int times) //times is used below in for loop as a var//times=# of times we want to shuffle
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}
    }
}
