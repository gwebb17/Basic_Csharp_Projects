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

        public Deck Shuffle(Deck deck, int times = 1) //when u assign default value on times (1) thats how you create optional param
                                                             //this param times does not need to be used but can be if placed in above line 15 deck = Shuffle(deck, # of times);
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();  //create empty temp list to store results
                Random random = new Random();    //using built in class Random we create var random and instantiate method Random();

                while (deck.Cards.Count > 0)  //will run on each card in deck until we have no more cards left to run
                {
                    int randomIndex = random.Next(0, deck.Cards.Count); //create int var called randomIndex between 0 and 52 (deck.Cards.Count)
                    TempList.Add(deck.Cards[randomIndex]);   //take randomIndex and add it to TempList(deck is overall object Cards is prop list)
                    deck.Cards.RemoveAt(randomIndex);  //now remove randomIndex from the parent list deck.Cards until no cards left
                }
                deck.Cards = TempList;  //now deck.Cards is empty so we assign tempList values to it
            }
            return deck; //now deck is redfined after being shuffled so we can return it

        }
    }
}
