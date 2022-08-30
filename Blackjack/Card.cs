using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public struct Card
    {
        public string CardSymbol { get; }
        public int CardNumber { get; }
        public int CardRank { get; }

        public Card(int cardNumber, string cardSymbol, int cardRank)
        {
            CardNumber = cardNumber;
            CardSymbol = cardSymbol;
            CardRank = cardRank;
        }

        // Making a override ToString
        public override string ToString()
        {
            // Here I say if the card number is 11 or higher we look at the number and return knight, queen or king instead of a number
            if(CardNumber >= 11)
            {
                string cardKQK = "";
                switch (CardNumber)
                {
                    case 11:
                        cardKQK = "Knight";
                        break;
                    case 12:
                        cardKQK = "Queen";
                        break;
                    case 13:
                        cardKQK = "King";
                        break;
                    default:
                        break;
                }

                return CardSymbol + ": " + cardKQK;
            }
            else
            {
                return CardSymbol + ": " + CardNumber;
            }
        }

    }
}
