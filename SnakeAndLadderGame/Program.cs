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
               
                int diceValue = random.Next(1, 7);
                diceRolls++;


                int option = random.Next(0, 3);
                string optionText = "";

                if (option == 0)
                {
                
                    optionText = "No Play";
                }
                else if (option == 1)
                {
                
                    optionText = "Ladder";
                    position += diceValue;
                }
                else
                {
                
                    optionText = "Snake";
                    position -= diceValue;
                }

                
                if (position == 4)
                    position = 14; 
                else if (position == 9)
                    position = 31; 
                else if (position == 17)
                    position = 7; 
                else if (position == 20)
                    position = 38;
                else if (position == 28)
                    position = 84;
                else if (position == 40)
                    position = 59;
                else if (position == 51)
                    position = 67;
                else if (position == 54)
                    position = 34;
                else if (position == 62)
                    position = 19;
                else if (position == 63)
                    position = 81;
                else if (position == 64)
                    position = 60;
                else if (position == 71)
                    position = 91;
                else if (position == 87)
                    position = 24;
                else if (position == 93)
                    position = 73;
                else if (position == 95)
                    position = 75;
                else if (position == 99)
                    position = 78;

                
                if (position > 100)
                    position -= diceValue;

                Console.WriteLine("You rolled a {0}. Your current position is {1}. Option: {2}", diceValue, position, optionText);
            }
            Console.WriteLine("Congratulations! You reached 100 in {0} dice rolls.", diceRolls);
            Console.ReadLine();
        }
    }
}
