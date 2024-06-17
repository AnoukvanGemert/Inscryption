
using System;
using System.Net.NetworkInformation;
using System.Text.Json;
using System.IO;
using Classes;


namespace showingCards
{
    public class showingCards
    {
        public static void Main()
        {
            try
            {
                string jsonFile = "cards.json";
                string jsonString = File.ReadAllText(jsonFile);
                List<Classes.Cards> cards = JsonSerializer.Deserialize<List<Cards>>(jsonString);

                Console.WriteLine("How many rounds do you want to play?");
                int rounds = int.Parse(Console.ReadLine());

                int gamesWon = 0;
                int gameslost = 0;

                for (int i = 0; i < rounds; i++)
                {
                    if (cards != null)
                    {
                        Random random = new Random();
                        List<Cards> CardsPlayer = cards.OrderBy(x => random.Next()).Take(4).ToList();

                        int damagePlayer = 0;

                        foreach (Cards card in CardsPlayer)
                        {
                            card.IntroductionPlayer();
                            damagePlayer += card.Power;
                        }
                        System.Console.WriteLine("-----------------------------------------");
                        System.Console.WriteLine($"You got {damagePlayer} damage points\n");

                        int damageCPU = 0;
                        List<Cards> CardsCPU = cards.OrderBy(x => random.Next(4)).Take(4).ToList();

                        foreach (Cards card in CardsCPU)
                        {
                            card.IntroductionCPU();
                            damageCPU += card.Power;
                        }
                        System.Console.WriteLine("-----------------------------------------");
                        System.Console.WriteLine($"Cpu got {damageCPU} damage points\n");


                        if (damagePlayer > damageCPU)
                        {
                            int differencePlayer = damagePlayer - damageCPU;
                            System.Console.WriteLine($"You won this round with {differencePlayer} points\n");
                            gamesWon++;
                        }

                        else if (damageCPU > damagePlayer)
                        {
                            int differenceCpu = damageCPU - damagePlayer;
                            System.Console.WriteLine($"You lost this round with {differenceCpu} points\n");
                            gameslost++;
                        }
                        else
                        {
                            System.Console.WriteLine("It's a draw");
                        }
                        
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
