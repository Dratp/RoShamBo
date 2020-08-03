using System;
using System.Runtime.InteropServices.ComTypes;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome player 1 what is your name: ");
            string name = Console.ReadLine();
            Human player1 = new Human(name);
            Brock rockMan = new Brock();
            Randy randomGuy = new Randy();
            int winner = 0;
            bool validPlayer2 = false;
            string input = "";
            string cont = "y";

            while(cont == "y")
            {
                validPlayer2 = false;
                while (!validPlayer2)
                {
                    Console.WriteLine("Would you like to play against Randy or Brock?: ");
                    input = Console.ReadLine();
                    if (input.ToLower() == "brock" || input.ToLower() == "b")
                    {
                        winner = PlayRPS(player1, rockMan);
                        if (winner == 2)
                        {
                            rockMan.Victory();
                        }
                        else if (winner == 1)
                        {
                            player1.Victory();
                        }
                        else
                        {
                            Console.WriteLine("Draw!!!!");
                        }
                        validPlayer2 = true;
                    }
                    else if (input.ToLower() == "randy" || input.ToLower() == "r")
                    {
                        winner = PlayRPS(player1, randomGuy);
                        if (winner == 2)
                        {
                            randomGuy.Victory();
                        }
                        else if (winner == 1)
                        {
                            player1.Victory();
                        }
                        else
                        {
                            Console.WriteLine("Draw!!!!");
                        }
                        validPlayer2 = true;
                    }
                    else
                    {
                        Console.WriteLine("That was not a valid choice");
                    }
                }
                STATS(player1, rockMan, randomGuy);
                Console.WriteLine("\nWould you like to play again? (y/n): ");
                cont = Console.ReadLine().ToLower();
            }
        }

        static void STATS(player human, player rock, player rand)
        {
            Console.WriteLine($"{human.Name} has played {human.Games} winning {human.Wins} of them making a {(human.Wins/human.Games)*100}% win rate");
            if(rock.Games > 0)
            {
                Console.WriteLine($"{rock.Name} has played {rock.Games} winning {rock.Wins} of them making a {(rock.Wins / rock.Games)*100}% win rate");
            }
            if (rand.Games > 0)
            {
                Console.WriteLine($"{rand.Name} has played {rand.Games} winning {rand.Wins} of them making a {(rand.Wins / rand.Games)*100}% win rate");
            }
        }

        static int PlayRPS(player player1, player player2)
        {
            player1.Games++;
            player2.Games++;
            Roshambo p1 = player1.GenerateRoShamBo();
            Roshambo p2 = player2.GenerateRoShamBo();
            int winner = player.Compare(p1, p2);
            Console.WriteLine($"This is Game {player1.Games}\n1...\n2...\n3...\n{player1.Name} throws {p1}, while {player2.Name} thows {p2} \n");
            return winner;
        }

    }
}
