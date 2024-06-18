using System;

namespace Classes
{

    public class Cards
    {
        public string? Name { get; set; }
        public int Power { get; set; }
        public int? Health { get; set; }
        public string? Cost { get; set; }

        public void IntroductionPlayer()
        {
            System.Console.WriteLine("You got the {0}. The {0} has {1} Power and {2} Health. Cost: {3}", Name, Power, Health, Cost);
        }
        public void IntroductionCPU()
        {
            System.Console.WriteLine("The CPU got the {0}. The {0} has {1} Power and {2} Health. Cost: {3}", Name, Power, Health, Cost);
        }
    }

    public class GamesResults
    {
        public void GameResult(int gamesWon, int gameLost)
        {
            if (gamesWon > gameLost)
            {
                System.Console.WriteLine("You won this game");
            } else if (gamesWon < gameLost)
            {
                System.Console.WriteLine("You lost this game");
            } else 
            {
                System.Console.WriteLine("It's a draw");
            }
        }
    }
}