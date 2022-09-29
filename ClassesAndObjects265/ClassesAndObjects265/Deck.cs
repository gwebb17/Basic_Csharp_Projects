using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects265
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>();     //create new var Cards thats a list of objects Card
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" }; //create list Suits and give the values of the list
            List<string> Faces = new List<string>() //create list Faces and give all values of list
            {
                "Two", "Three", "Four", "Five", "Six", "Seven",
                "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };

            foreach (string face in Faces)  //were looping through each possible value of list Faces (defined above)
            {                               //essentially we're doing Suits * Faces (4 values * 13 values = 52) objects created called card
                foreach (string suit in Suits)  //and we're looping through each possible value of list Suits (defined above)
                {
                    Card card = new Card();    //create a new card named card
                    card.Suit = suit;          //plugin our iterator value (suit) as the cards Suit value
                    card.Face = face;          //plugin our iterator value (face) as the cards Face value
                    Cards.Add(card);           //now that props are given values we add this card to the list we made at top called Cards
                }
            }
            
        }
        public List<Card> Cards { get; set; }
    }
}
