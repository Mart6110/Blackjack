using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Blackjack
{
    // I did not finish this assignment,
    // becuase i ran out of time.
    // I spent most of the time trying to figure out how to make this assignment.

    class Program
    {
        static void Main(string[] args)
        {
            string cardSymbol = "";
            int cardRank = 0;
            string yesNo;

            List<Card> playerCards = new List<Card>();
            List<Card> computerCards = new List<Card>();

            int[,] cards = new int[,]
            {
                { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13},
                { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13},
                { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13},
                { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13},
            };

            Random rnd = new Random();



            Console.WriteLine("Vil du spille? (y/n)");
            yesNo = Console.ReadLine().ToLower();

            if(yesNo == "y")
            {
                Console.WriteLine("Shuffling the cards");
                Thread.Sleep(2000);

                Console.WriteLine("Dealing cards");
                Thread.Sleep(2000);

                Console.WriteLine("Player Cards:");
                // Making a for loop, so i so im dealt two cards
                for (int i = 0; i < 2; i++)
                {
                    int symbol = rnd.Next(0, cards.GetLength(0));
                    int number = rnd.Next(0, cards.GetLength(1));

                    int cardNumber = cards[symbol, number];
                    cardRank = cardNumber;

                    // When the cards that have a higher card number the 10 we set the value of them to 10
                    if(cardRank >= 11)
                    {
                        cardRank = 10;
                    }

                    // Making so we can see what card symbol we have on our card.
                    switch (symbol)
                    {
                        case 0:
                            cardSymbol = "Diamond";
                            break;
                        case 1:
                            cardSymbol = "Clubs";
                            break;
                        case 2:
                            cardSymbol = "Hearts";
                            break;
                        case 3:
                            cardSymbol = "Spades";
                            break;
                        default:
                            break;
                    }
                    

                    Card card = new Card(cardNumber, cardSymbol, cardRank);
                    // Adding the card to the list
                    playerCards.Add(card);
                }
                // Displaying the players hand
                foreach (Card u in playerCards)
                {
                    Console.WriteLine(u);
                }

                Console.WriteLine("Computer Cards:");
                for (int i = 0; i < 2; i++)
                {
                    int symbol = rnd.Next(0, cards.GetLength(0));
                    int number = rnd.Next(0, cards.GetLength(1));

                    int cardNumber = cards[symbol, number];
                    cardRank = cardNumber;

                    if (cardRank >= 11)
                    {
                        cardRank = 10;
                    }

                    switch (symbol)
                    {
                        case 0:
                            cardSymbol = "Diamond";
                            break;
                        case 1:
                            cardSymbol = "Clubs";
                            break;
                        case 2:
                            cardSymbol = "Hearts";
                            break;
                        case 3:
                            cardSymbol = "Spades";
                            break;
                        default:
                            break;
                    }

                    Card card = new Card(cardNumber, cardSymbol, cardRank);
                    computerCards.Add(card);
                }
                foreach (Card u in computerCards)
                {
                    Console.WriteLine(u);
                }

            } else
            {
                Environment.Exit(1);
            }

            Console.ReadLine();
        }
    }
}