using System;

namespace Classes
{

    public class Cards
    {
        public int? Id { get; set; }
        public string? Name { get; set; }   
        public int? Power { get; set; }
        public int? Health { get; set; }
        public string? Cost { get; set; }   
        public string? Tribe { get; set; }

        public void Introduction()
    {
        System.Console.WriteLine("You got the {0}. The {0} has {1} Power and {2} Health. Cost: {3}", Name, Power, Health, Cost);
    }
    }
   
}