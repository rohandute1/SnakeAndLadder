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

            int positionPlayer1 = 0;
            int positionPlayer2 = 0;
            int diceRollsPlayer1 = 0;
            int diceRollsPlayer2 = 0;
            Random random = new Random();
            int currentPlayer = 1;

            while (positionPlayer1 < 100 && positionPlayer2 < 100)
            {
                Console.WriteLine("Press any key to roll the dice for Player {0}...", currentPlayer);
                Console.ReadKey();

                
                int diceValue = random.Next(1, 7); 

               
                if (currentPlayer == 1)
                {
                    positionPlayer1 += diceValue;
                    diceRollsPlayer1++;
                }
                else
                {
                    positionPlayer2 += diceValue;
                    diceRollsPlayer2++;
                }

               
                if (currentPlayer == 1)
                {
                    if (positionPlayer1 == 4)
                        positionPlayer1 = 14;
                    else if (positionPlayer1 == 9)
                        positionPlayer1 = 31;
                    else if (positionPlayer1 == 17)
                        positionPlayer1 = 7; 
                    else if (positionPlayer1 == 20)
                        positionPlayer1 = 38; 
                    else if (positionPlayer1 == 28)
                        positionPlayer1 = 84; 
                    else if (positionPlayer1 == 40)
                        positionPlayer1 = 59; 
                    else if (positionPlayer1 == 51)
                        positionPlayer1 = 67; 
                    else if (positionPlayer1 == 54)
                        positionPlayer1 = 34; 
                    else if (positionPlayer1 == 62)
                        positionPlayer1 = 19;
                    else if (positionPlayer1 == 63)
                        positionPlayer1 = 81;
                    else if (positionPlayer1 == 64)
                        positionPlayer1 = 60;
                    else if (positionPlayer1 == 71)
                        positionPlayer1 = 91;
                    else if (positionPlayer1 == 87)
                        positionPlayer1 = 24;
                    else if (positionPlayer1 == 93)
                        positionPlayer1 = 73;
                    else if (positionPlayer1 == 95)
                        positionPlayer1 = 75;
                    else if (positionPlayer1 == 99)
                        positionPlayer1 = 78;
                }
                else
                {
                    if (positionPlayer2 == 4)
                        positionPlayer2 = 14;
                    else if (positionPlayer2 == 9)
                        positionPlayer2 = 31;
                    else if (positionPlayer2 == 17)
                        positionPlayer2 = 7; 
                    else if (positionPlayer2 == 20)
                        positionPlayer2 = 38;
                    else if (positionPlayer2 == 28)
                        positionPlayer2 = 84;
                    else if (positionPlayer2 == 40)
                        positionPlayer2 = 59;
                    else if (positionPlayer2 == 51)
                        positionPlayer2 = 67;
                    else if (positionPlayer2 == 54)
                        positionPlayer2 = 34;
                    else if (positionPlayer2 == 62)
                        positionPlayer2 = 19;
                    else if (positionPlayer2 == 63)
                        positionPlayer2 = 81;
                    else if (positionPlayer2 == 64)
                        positionPlayer2 = 60;
                    else if (positionPlayer2 == 71)
                        positionPlayer2 = 91;
                    else if (positionPlayer2 == 87)
                        positionPlayer2 = 24;
                    else if (positionPlayer2 == 93)
                        positionPlayer2 = 73;
                    else if (positionPlayer2 == 95)
                        positionPlayer2 = 75;
                    else if (positionPlayer2 == 99)
                        positionPlayer2 = 78;
                }

               
                if (positionPlayer1 < 0)
                    positionPlayer1 = 0;

                if (positionPlayer2 < 0)
                    positionPlayer2 = 0;

                Console.WriteLine("Player {0} rolled a {1}. Their current position is {2}.", currentPlayer, diceValue, currentPlayer == 1 ? positionPlayer1 : positionPlayer2);

               
                if (currentPlayer == 1 && positionPlayer1 == 100)
                {
                    Console.WriteLine("Player 1 won the game in {0} dice rolls!", diceRollsPlayer1);
                    break;
                }
                else if (currentPlayer == 2 && positionPlayer2 == 100)
                {
                    Console.WriteLine("Player 2 won the game in {0} dice rolls!", diceRollsPlayer2);
                    break;
                }
                else if (diceValue == 6)
                {
                    Console.WriteLine("Player {0} got a ladder and plays again!", currentPlayer);
                }

               
                currentPlayer = (currentPlayer == 1) ? 2 : 1;
            }

            Console.ReadLine();
        }
    }




}
