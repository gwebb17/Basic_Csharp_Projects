using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassesAndObjects265
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card);
            //below is cleaning up uneeded memory when not used (USING STATEMENT)
            using (StreamWriter file = new StreamWriter(@"C:\\Users\\Documents\\Machine\\practice_file.txt", true)) //the true corresponds to a required bool value when using this, means we DO want to append the text
            {
                file.WriteLine(card); //says we want to write whats in () to the file. (card)
            }
                Deck.Cards.RemoveAt(0);
        }
    }
}
