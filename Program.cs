
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

                if (cards != null)
                {

                    Random random = new Random();
                    List<Cards> selectedCards = cards.OrderBy(x => random.Next()).Take(4).ToList();
                    int damageW = 0;
                    int damageL = 0;
                    int damageTotal = 0;

                    foreach (Cards card in selectedCards)
                    {
                        card.Introduction();
                        damageTotal += card.Power;

                        if (card.Power >= 1)
                        {
                            damageW++;
                        }
                        else
                        {
                            damageL++;
                        }

                    }
                    Random rnd = new Random();
                    int enemy = rnd.Next(1, 10);
                    System.Console.WriteLine($"You got {damageTotal} damage points");

                    if (damageTotal > enemy)
                    {
                        System.Console.WriteLine($"The enemy got {enemy} damage points");
                        System.Console.WriteLine("You won this round!");
                    }
                    else if (enemy < damageTotal)
                    {
                        System.Console.WriteLine($"The enemy got {enemy} damage points");
                        System.Console.WriteLine("You lost this round you loser");
                    }
                    else 
                    {
                        System.Console.WriteLine($"The enemy got {enemy} damage points");
                        System.Console.WriteLine("It's a draw");
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
