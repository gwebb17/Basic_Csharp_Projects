using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjectsLibrary265
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>();     //create new var Cards thats a list of objects Card
            
            for (int i = 0; i < 13; i++)   //outer for loop runs for 13 times matching number of card values
            {
                for (int j = 0; j < 4; j++)  //inner for loop runs for 4 times matching faces
                {
                    Card card = new Card();
                    card.Face = (Face)j;  //other way of casting, (Face) is data type we are casting to , j is what we're casting
                    card.Suit = (Suit)i;  //casting i to (Suit)
                    Cards.Add(card);

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
