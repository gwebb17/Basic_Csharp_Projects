using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ClassesAndObjects265.ClassesAndObjectsLibrary265;
using ClassesAndObjectsLibrary265;

namespace ClassesAndObjectsLibrary265.ClassesAndObjects265
{
    public class TwentyOneGame : Game, IWalkAway
    {
        public TwentyOneDealer Dealer { get; set; }


        public override void Play()
        {
            Dealer = new TwentyOneDealer(); //when play is called create a new dealer
            foreach (Player player in Players)
            {
                player.Hand = new List<Card>();  //reset hand with new list each time deal a hand to each player
                player.Stay = false;  //don't let previous value of Stay carry over to this new hand
            }
            Dealer.Hand = new List<Card>(); //sim to above we reset hand
            Dealer.Stay = false; //sim to above
            Dealer.Deck = new Deck();
            Dealer.Deck.Shuffle();
            Console.WriteLine("Place your bet!");

            foreach (Player player in Players)
            {
                bool validAnswer = false;
                int bet = 0;
                while (!validAnswer)
                {
                    Console.WriteLine("Place your bet");
                    validAnswer = int.TryParse(Console.ReadLine(), out bet);
                    if (!validAnswer) Console.WriteLine("Please enter digits only no decimals");
                }
                if (bet < 0)
                {
                    throw new FraudException();
                }


                bool successfullyBet = player.Bet(bet);  //Bet defined in Player.cs , either outputs true or false. so this new bool will be true or false as well depending on that result
                if (!successfullyBet) //this means if successfullyBet == false; shorthand using != basically
                {
                    return;  //here return means end this method Play if above if statement is False
                }
                Bets[player] = bet; //Bets is dictionary created in Game.cs prop of Game. [player] is the key  and = bet sets it = to above bet var
            }

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dealing...");
                foreach (Player player in Players)
                {
                    Console.Write("{0}: ", player.Name);
                    Dealer.Deal(player.Hand);
                    if (i == 1) //if its the second round of dealing see i above
                    {
                        bool blackJack = TwentyOneRules.CheckForBlackjack(player.Hand);
                        if (blackJack)
                        {
                            Console.WriteLine("Blackjack! {0} wins {1}", player.Name, Bets[player]);
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]);
                            Bets.Remove(player);
                            return;
                        }
                    }
                }
                Console.WriteLine("Dealer: ");
                Dealer.Deal(Dealer.Hand);
                if (i == 1)
                {
                    bool blackJack = TwentyOneRules.CheckForBlackjack(Dealer.Hand);
                    if (blackJack)
                    {
                        Console.WriteLine("Dealer has BlackJack! Everyone loses!");
                        foreach (KeyValuePair<Player, int> entry in Bets)
                        {
                            Dealer.Balance += entry.Value;
                        }
                        return;
                    }
                }
            }
            foreach (Player player in Players)
            {
                while (!player.Stay)
                {
                    Console.WriteLine("Your cards are: ");
                    foreach (Card card in player.Hand)
                    {
                        Console.WriteLine("{0} ", card.ToString());
                    }
                    Console.WriteLine("\n\nHit or stay?");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "stay")
                    {
                        player.Stay = true;
                        break;
                    }
                    else if (answer == "hit")
                    {
                        Dealer.Deal(player.Hand);
                    }
                    bool busted = TwentyOneRules.IsBusted(player.Hand);
                    if (busted)
                    {
                        Dealer.Balance += Bets[player];
                        Console.WriteLine("{0} Busted! you lose your best of {1}. Your balance is now {2}.", player.Name, Bets[player], player.Balance);
                        Console.WriteLine("Do you want to play again?");
                        answer = Console.ReadLine().ToLower();
                        if (answer == "yes" || answer == "yeah")
                        {
                            player.isActivelyPlaying = true;
                            return;
                        }
                        else
                        {
                            player.isActivelyPlaying = false;
                            return;
                        }
                    }
                }
            }
            Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
            Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            while (!Dealer.Stay && !Dealer.isBusted)
            {
                Console.WriteLine("Dealer is hitting...");
                Dealer.Deal(Dealer.Hand);
                Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            }
            if (Dealer.Stay)
            {
                Console.WriteLine("Dealer is staying.");
            }
            if (Dealer.isBusted)
            {
                Console.WriteLine("Dealer is busted");
                foreach (KeyValuePair<Player, int> entry in Bets)
                {
                    Console.WriteLine("{0} won {1}!", entry.Key.Name, entry.Value);
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2);
                    Dealer.Balance -= entry.Value;
                }
                return;
            }
            foreach (Player player in Players)
            {
                bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand);  //? allows bool to have a null value
                if (playerWon == null)
                {
                    Console.WriteLine("Push, Nobody wins.");
                    player.Balance += Bets[player];
                }
                else if (playerWon == true)
                {
                    Console.WriteLine("{0} won {1}", player.Name, Bets[player]);
                    player.Balance += (Bets[player] * 2);
                    Dealer.Balance -= Bets[player];
                }
                else
                {
                    Console.WriteLine("Dealer Wins {0}", Bets[player]);   //Bets[player] is how you access the dictionary in game.cs i think for Bets
                    Dealer.Balance += Bets[player];
                }
                Console.WriteLine("Play again?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes" || answer == "yeah")
                {
                    player.isActivelyPlaying = true;
                }
                else
                {
                    player.isActivelyPlaying = false;
                }
            }
                       
        }

        public override void ListPlayers()
        {
            Console.WriteLine("Welcome to 21, players: ");
            base.ListPlayers();
        }
        public void WalkAway(Player player)   //implemented interface
        {
            throw new NotImplementedException();
        }
    }
}
