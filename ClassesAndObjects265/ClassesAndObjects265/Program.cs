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
            deck = Shuffle(deck);  //reassign value of deck as a shuffled deck (call method Shuffle on (deck);

                foreach (Card card in deck.Cards)    //loop to display every card using our list Cards defined in Deck file
                {
                    Console.WriteLine(card.Face + " of " + card.Suit);  
                }

            Console.WriteLine(deck.Cards.Count);   //display the amount of Cards in deck
            Console.ReadLine();
        }

        public static Deck Shuffle(Deck deck) 
        {
            List<Card> TempList = new List<Card>();  //create empty temp list to store results
            Random random = new Random();    //using built in object Random we create var random and instantiate method Random();

            while (deck.Cards.Count > 0)  //will run on each card in deck until we have no more cards left to run
            {
                int randomIndex = random.Next(0, deck.Cards.Count); //create int var called randomIndex between 0 and 52 (deck.Cards.Count)
                TempList.Add(deck.Cards[randomIndex]);   //take randomIndex and add it to TempList(deck is overall object Cards is empty list)
                deck.Cards.RemoveAt(randomIndex);  //now remove randomIndex from the parent list deck.Cards until no cards left
            }
            deck.Cards = TempList;  //now deck.Cards is empty so we assign tempList values to it
            return deck; //now deck is redfined after being shuffled so we can return it

        }
    }
}
