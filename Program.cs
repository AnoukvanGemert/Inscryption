
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
                    foreach (Classes.Cards card in cards)
                    {
                        Classes.Cards newCards = new Classes.Cards()
                        {
                            Id = card.Id,
                            Name = card.Name,
                            Power = card.Power,
                            Health = card.Health,
                            Cost = card.Cost,
                            Tribe = card.Tribe,
                        };
                        newCards.Introduction();
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
