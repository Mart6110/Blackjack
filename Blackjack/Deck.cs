using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    internal class Deck
    {
        // Creates a list for the playersCards and for the computersCards
        public List<Cards> playerCards = new List<Cards>();
        public List<Cards> computerCards = new List<Cards>();

        // Creates some variables for playerSum, computerSum, CardSymbol, and cardRank
        private int playerSum = 0;
        private int computerSum = 0;
        string cardSymbol = "";
        int cardRank = 0;

        // Crates a two dimentional int array that has every cardnumber in it
        int[,] cards = new int[,]
        {
                { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13},
                { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13},
                { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13},
                { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13},
        };

        // Creates a random generater for the pickup method
        Random rng = new Random();

        // Makes it so you can get the playerSum in the Main Method
        public int PlayerSum { get { return playerSum; } }
        public int ComputerSum { get { return computerSum; } }

        // Makes a method called PickUp, that picks up cards
        public void PickUp(bool turn)
        {
            // A bool to check if its the player or computer turn to pickup cards
            bool player = turn;

            // Checks that bool
            if (player == true)
            {
                // Get a random int for the symbol from 0 to 3
                // and a random int from 0 to 12
                int symbol = rng.Next(0, cards.GetLength(0));
                int number = rng.Next(0, cards.GetLength(1));

                // Sets cardNumber to the random cards number
                int cardNumber = cards[symbol, number];

                // Checks if its a picture card, if it is then it sets the cardRank to 10
                if (cardNumber > 10)
                {
                    cardRank = 10;
                }
                else
                {
                    // If its not a picture card then it sets the cardRank to the cardNumber
                    cardRank = cardNumber;
                }

                // Changes the ínt called symbol to a string with the symbol the int represents
                switch (symbol)
                {
                    case 0:
                        cardSymbol = "Hearts";
                        break;
                    case 1:
                        cardSymbol = "Spades";
                        break;
                    case 2:
                        cardSymbol = "Clubs";
                        break;
                    case 3:
                        cardSymbol = "Diamond";
                        break;
                    default:
                        break;
                }
                // Creates a objekt called card with the strukt called Cards
                Cards card = new Cards(cardSymbol, cardRank, cardNumber);

                // Adds the card to the playersCards list
                playerCards.Add(card);

                // Adds the cardrank to the playerSum
                playerSum += cardRank;
            }
            else
            {
                // Get a random int for the symbol from 0 to 3
                // and a random int from 0 to 12
                int symbol = rng.Next(0, cards.GetLength(0));
                int number = rng.Next(0, cards.GetLength(1));

                // Sets cardNumber to the random cards number
                int cardNumber = cards[symbol, number];

                // Checks if its a picture card, if it is then it sets the cardRank to 10
                if (cardNumber > 10)
                {
                    cardRank = 10;
                }
                else
                {
                    // If its not a picture card then it sets the cardRank to the cardNumber
                    cardRank = cardNumber;
                }

                // Changes the ínt called symbol to a string with the symbol the int represents
                switch (symbol)
                {
                    case 0:
                        cardSymbol = "Hearts";
                        break;
                    case 1:
                        cardSymbol = "Spades";
                        break;
                    case 2:
                        cardSymbol = "Clubs";
                        break;
                    case 3:
                        cardSymbol = "Diamond";
                        break;
                    default:
                        break;
                }
                // Creates a objekt called card with the strukt called Cards
                Cards card = new Cards(cardSymbol, cardRank, cardNumber);

                // Adds the card to the computersCards list
                computerCards.Add(card);

                // Adds the cardRank to computerSum
                computerSum += cardRank;
            }

        }
        public void showTablePlayersTurn()
        {
            // Clears the console window
            Console.Clear();
            Console.WriteLine("Players cards: Sum: " + playerSum);

            // Writes out each card in the playerCards list
            foreach (Cards c in playerCards)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine("");
            Console.WriteLine("Computers cards:");

            // Writes out one of the computers cards
            Console.WriteLine(computerCards[0]);
        }
        public void showTable()
        {
            // Clears the console window
            Console.Clear();
            Console.WriteLine("Players cards: Sum: " + playerSum);

            // Writes out every card in the playerCards list
            foreach (Cards c in playerCards)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine("");
            Console.WriteLine("Computers cards: Sum: " + computerSum);

            // Writes out all the cards in the computerCards list
            foreach (Cards c in computerCards)
            {
                Console.WriteLine(c);
            }
        }
    }
}