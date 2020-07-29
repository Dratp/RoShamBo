using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome player 1 what is your name: ");
            string name = Console.ReadLine();
            Human player1 = new Human(name);
            int winner = 0;
            bool validPlayer2 = false;
            string input = "";

            int randyWin = 0;
            int randyGames = 0;
            int brockWin = 0;
            int brockGames = 0;
            int humanWin = 0;
            int humanGames = 0;

            while (!validPlayer2)
            {
                Console.WriteLine("Would you like to play against Randy or Brock?: ");
                input = Console.ReadLine();
                if (input.ToLower() == "brock" || input.ToLower() == "b")
                {
                    Brock player2 = new Brock();
                    Roshambo p1 = player1.GenerateRoShamBo();
                    Roshambo p2 = player2.GenerateRoShamBo();
                    humanGames++;
                    brockGames++;
                    winner = player.Compare(p1, p2);
                    Console.WriteLine(String.Format("Game {0,4}\t{1,10}\t{2,-10}winner = {3,4}", humanGames, p1, p2, winner));
                    if (winner == 2)
                    {
                        brockWin++;
                    }
                    else if (winner == 1)
                    {
                        humanWin++;
                    }
                    validPlayer2 = true;
                }
                else if (input.ToLower() == "randy" || input.ToLower() == "r")
                {
                    Randy player2 = new Randy();
                    Roshambo p1 = player1.GenerateRoShamBo();
                    Roshambo p2 = player2.GenerateRoShamBo();
                    humanGames++;
                    randyGames++;
                    winner = player.Compare(p1, p2);
                    Console.WriteLine(String.Format("Game {0,4}\t{1,10}\t{2,-10}winner = {3,4}", humanGames, p1, p2, winner));
                    if (winner == 2)
                    {
                        randyWin++;
                    }
                    else if (winner == 1)
                    {
                        humanWin++;
                    }
                    validPlayer2 = true;
                }
                else
                {
                    Console.WriteLine("That was not valid");
                }
            }



            
            

        }
    }
}
