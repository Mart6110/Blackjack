using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public struct Cards
    {
        // Creates 3 public variables
        public string CardSymbol { get; }
        public int CardRank { get; }
        public int CardNumber { get; }

        // Construcktor
        public Cards(string cardSymbol, int cardRank, int cardNumber)
        {
            this.CardSymbol = cardSymbol;
            this.CardRank = cardRank;
            this.CardNumber = cardNumber;
        }

        // ToString Override
        public override string ToString()
        {
            if (CardNumber > 10)
            {
                string cardWithPicture = "";

                // Switches the cardNumbers 11,12,13 with the name of thier picture
                switch (CardNumber)
                {
                    case 11:
                        cardWithPicture = "Knight";
                        break;
                    case 12:
                        cardWithPicture = "Queen";
                        break;
                    case 13:
                        cardWithPicture = "King";
                        break;
                    default:
                        break;
                }
                // returns the symbol with the name of the picture card
                return CardSymbol + ":" + cardWithPicture;
            }
            else
            {
                // Returns the symbol with the cards number
                return CardSymbol + ":" + CardNumber;
            }
        }
    }
}
