using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    enum Roshambo
    {
        Rock,
        Paper,
        Scissors
    } 
    abstract class player
    {
        public string Name { get; set; }
        public Roshambo RPS { get; set; }

        public abstract Roshambo GenerateRoShamBo();

        public override string ToString()
        {
            return $"{RPS}";
        }

        public static int Compare(Roshambo p1, Roshambo p2)
        {
            int winner = 0;
            if (p1 == p2)
            {
                winner = 0;
            }
            else if (p1 == Roshambo.Rock)
            {
                if (p2 == Roshambo.Paper)
                {
                    winner = 2;
                }
                else winner = 1;
            }
            else if (p1 == Roshambo.Paper)
            {
                if (p2 == Roshambo.Rock)
                {
                    winner = 1;
                }
                else
                {
                    winner = 2;
                }
            }
            else
            {
                if (p2 == Roshambo.Rock)
                {
                    winner = 2;
                }
                else
                {
                    winner = 1;
                }
            }
            return winner;
        }

    }

    class Brock : player
    {
        public Brock()
        {
            Name = "Brock";
        }
        
        public override Roshambo GenerateRoShamBo()
        {
            Roshambo Rock = Roshambo.Rock;
            return Rock;
        }
    }

    class Randy : player
    {
        static Random rand = new Random();

        public Randy()
        {
            Name = "Randy";
        }

        public override Roshambo GenerateRoShamBo()
        {
            int RPSnum = rand.Next(3);
            Roshambo randomRPS = (Roshambo)RPSnum;

            return randomRPS;
        }
    }

    class Human : player
    {
        public Human(string aName)
        {
            Name = aName;
        }

        public override Roshambo GenerateRoShamBo()
        {
            Roshambo PRS = Roshambo.Scissors;
            bool isValid = false;
            while (!isValid)
            {
                Console.Write("Rock, Paper or Scissors: ");
                string input = Console.ReadLine();                
                if (input.ToLower() == "rock" || input.ToLower() == "r")
                {
                    PRS = Roshambo.Rock;
                    isValid = true;
                }
                else if(input.ToLower() == "paper" || input.ToLower() == "p")
                {
                    PRS = Roshambo.Paper;
                    isValid = true;
                }
                else if (input.ToLower() == "scissors" || input.ToLower() == "s")
                {
                    PRS = Roshambo.Scissors;
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("That was not a valid choice");
                }
            }
            return PRS;
        }

    }

}
