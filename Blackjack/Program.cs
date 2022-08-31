using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Blackjack
{

    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables for deciding What is going to happen
            string yesNo;
            bool playerTurn = true;

            // I make a objekt deck using my class called deck 
            Deck deck = new Deck();

            // Asking the user if the are ready to play.
            Console.WriteLine("Klar til at spille (y/n)");
            yesNo = Console.ReadLine().ToLower();

            //Checks if user said yes
            if (yesNo == "y")
            {
                // I clear the console
                Console.Clear();

                // A for loop to pickup 2 cards for the player
                for (int i = 0; i < 2; i++)
                {
                    deck.PickUp(playerTurn);
                }

                // Setting the bool to false So that we indicate that it is the computers turn to pickup cards
                playerTurn = false;

                // A for loop to pickup 2 cards for the computer
                for (int i = 0; i < 2; i++)
                {
                    deck.PickUp(playerTurn);
                }

                // Runs a method to show all the players cards and one of the computers cards
                deck.showTablePlayersTurn();

                // A loop that asks users if they want to pickup another card
                do
                {
                    // Asks the user to hit or not
                    Console.WriteLine("Vil du 'hit' (y/n)");
                    yesNo = Console.ReadLine().ToLower();

                    // Checks choice
                    if (yesNo == "y")
                    {
                        // Sets it to the players turn to pickup cards and picks up one card
                        playerTurn = true;
                        deck.PickUp(playerTurn);
                    }

                    // Shows players cards and one of computers cards
                    deck.showTablePlayersTurn();
                } while (yesNo != "n");

                // A do/while loop for the computer to pickup cards
                do
                {
                    // Checks if the computers cards sum is less then 15, if it is then it picks up a card
                    if (deck.ComputerSum < 15)
                    {
                        yesNo = "y";
                        playerTurn = false;
                        deck.PickUp(playerTurn);
                    }
                    // if not then it says no
                    else
                    {
                        yesNo = "n";
                    }

                    // Shows all players cards and all computers cards
                    deck.showTable();

                } while (yesNo != "n");

                // Waits 3 seconds so it doesn't let the user see what the computer picked up
                Thread.Sleep(3000);

                // Checks whos closer, palyer or computer
                if (21 - deck.PlayerSum < 21 - deck.ComputerSum)
                {
                    Console.Clear();
                    Console.WriteLine("Player WON!!!!");
                }
                else if (deck.PlayerSum == deck.ComputerSum)
                {
                    Console.Clear();
                    Console.WriteLine("Both Win");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Computer Won!!!!!");
                }

            }

            Console.ReadLine();
        }
    }
}