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
            int count = deck.Cards.Count(x => x.Face == Face.Ace);

            List<Card> newList = deck.Cards.Where(y => y.Face == Face.King).ToList();

            List<int> numberList = new List<int>() { 1, 2, 3, 555, 12 };
            int sum = numberList.Sum();

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
