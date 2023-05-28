using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Game!");

            int position = 0;
            int diceRolls = 0;
            Random random = new Random();

            while (position < 100)
            {
                Console.WriteLine("Press any key to roll the dice...");
                Console.ReadKey();

                // Roll the dice
                int diceValue = random.Next(1, 7); // Generate a random number between 1 and 6
                diceRolls++;

                // Move the player
                position += diceValue;

                // Check if the position is a snake, ladder, or beyond 100
                if (position == 4)
                    position = 14; // Snake
                else if (position == 9)
                    position = 31; // Ladder
                else if (position == 17)
                    position = 7; // Snake
                else if (position == 20)
                    position = 38; // Ladder
                else if (position == 28)
                    position = 84; // Ladder
                else if (position == 40)
                    position = 59; // Ladder
                else if (position == 51)
                    position = 67; // Ladder
                else if (position == 54)
                    position = 34; // Snake
                else if (position == 62)
                    position = 19; // Snake
                else if (position == 63)
                    position = 81; // Ladder
                else if (position == 64)
                    position = 60; // Snake
                else if (position == 71)
                    position = 91; // Ladder
                else if (position == 87)
                    position = 24; // Snake
                else if (position == 93)
                    position = 73; // Snake
                else if (position == 95)
                    position = 75; // Snake
                else if (position == 99)
                    position = 78; // Snake

                // Make sure the position doesn't go beyond 100
                if (position > 100)
                    position -= diceValue;

                Console.WriteLine("You rolled a {0}. Your current position is {1}.", diceValue, position);
            }

            Console.WriteLine("Congratulations! You reached 100 in {0} dice rolls.", diceRolls);
            Console.ReadLine();
        }
    }


}
