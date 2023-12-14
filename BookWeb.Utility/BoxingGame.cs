using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWeb.Utility
{
    using System;

    class BoxingGame
    {
        static void Main(string[] args)
        {
            // Create the player and computer characters
            Player player = new Player();
            Computer computer = new Computer();

            // Set the player's health to 100
            player.health = 100;

            // Start the game loop
            bool gameOver = false;
            while (!gameOver)
            {
                // Display the current health of both characters
                Console.WriteLine("Player health: {0}", player.health);
                Console.WriteLine("Computer health: {0}", computer.health);

                // Get the player's move
                char playerMove = GetPlayerMove();

                // Get the computer's move
                char computerMove = computer.GetMove();

                // Simulate the fight
                bool playerHit = SimulatePunch(playerMove, computerMove);
                bool computerHit = SimulatePunch(computerMove, playerMove);

                // Update the characters' health based on the hits
                if (playerHit)
                {
                    player.health--;
                }
                if (computerHit)
                {
                    computer.health--;
                }

                // Check if either character is out of health
                if (player.health <= 0)
                {
                    Console.WriteLine("Game over! Computer wins.");
                    gameOver = true;
                }
                else if (computer.health <= 0)
                {
                    Console.WriteLine("Game over! Player wins.");
                    gameOver = true;
                }

                // Wait for a key press before continuing
                Console.ReadKey();
            }
        }

        private static char GetPlayerMove()
        {
            Console.WriteLine("Enter your move (j, c, or k):");
            string input = Console.ReadLine();

            // Check if the input is valid
            if (input.Length != 1 || !input.Equals("j") && !input.Equals("c") && !input.Equals("k"))
            {
                Console.WriteLine("Invalid move. Please enter a valid move.");
                return GetPlayerMove();
            }

            return input[0];
        }

        private static bool SimulatePunch(char playerMove, char computerMove)
        {
            // Jab beats crook
            if (playerMove == 'j' && computerMove == 'k')
            {
                return true;
            }

            // Cross beats jab
            if (playerMove == 'c' && computerMove == 'j')
            {
                return true;
            }

            // Crook beats cross
            if (playerMove == 'k' && computerMove == 'c')
            {
                return true;
            }

            // In all other cases, no one is hit
            return false;
        }
    }

    class Player
    {
        public int health;
    }

    class Computer
    {
        public int health;

        public char GetMove()
        {
            // Choose a random move from the set {'j', 'c', 'k'}
            int randomIndex = new Random().Next(3);
            char move = (char)('a' + randomIndex);

            return move;
        }
    }

}
