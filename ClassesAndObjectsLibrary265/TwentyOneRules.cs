using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjectsLibrary265.ClassesAndObjects265
{
    public class TwentyOneRules
    {
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>() //private means it is only being used in this class
        {
            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] = 9,
            [Face.Ten] = 10,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
            [Face.Ace] = 1   //can't assign multiple values here so choosing 1 for now and will apply logic somewhere else to provide 11 option
        };

        private static int[] GetAllPossibleHandValues(List<Card> Hand) //returns int[] array of integers
        {
            int aceCount = Hand.Count(x => x.Face == Face.Ace); //using lambda we say get Count each Face of each card in Hand where that Face == ace:
            int[] result = new int[aceCount + 1]; //aceCount + 1 is the three possible values for having 2 aces, (ace1 =1 ace2= 1, ace1=11 ace2=1, ace1=11 ace2==11)
            int value = Hand.Sum(x => _cardValues[x.Face]);
            result[0] = value;
            if (result.Length == 1) return result;
            {
                return result;
            }
            for (int i = 1; i < result.Length; i++)
            {
                value = value + (i * 10);
                result[i] = value;
                return result;
            }
        }

        public static bool CheckForBlackjack(List<Card> Hand)
        {
            int[] possibleValues = GetAllPossibleHandValues(Hand);
            int value = possibleValues.Max();
            if (value == 21) return true;  //shorthand for if statement if player has blackjack return true
            else return false;
        }

        public static bool IsBusted(List<Card> Hand)
        {
            int value = GetAllPossibleHandValues(Hand).Min();
            if (value > 21) return true;
            else return false;
        }

        public static bool ShouldDealerStay(List<Card> Hand)
        {
            int[] possibleHandValues = GetAllPossibleHandValues(Hand);
            foreach (int value in possibleHandValues)
            {
                if (value > 16 && value < 22)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool? CompareHands(List<Card> PlayerHand, List<Card> DealerHand) //bool? is the data return type that allows for possible null values
        {
            int[] playerResults = GetAllPossibleHandValues(PlayerHand);
            int[] dealerResults = GetAllPossibleHandValues(DealerHand);

            int playerScore = playerResults.Where(x => x < 22).Max();
            int dealerScore = dealerResults.Where(x => x < 22).Max();

            if (playerScore > dealerScore) return true;  //if player Wins
            if (playerScore < dealerScore) return false; //if Dealer Wins
            else return null; //Tie
        }
    }
}
