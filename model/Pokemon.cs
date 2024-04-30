using System.Transactions;

namespace ipo2_pokedex
{


    public class Pokemon
    {


        public string id { get; set; }
        public string name { get; set; }
        public string abilities { get; set; }
        public string specie { get; set; }
        public string type { get; set; }
        public string height { get; set; }
        public string weight { get; set; }
        public string evolution { get; set; }
        public bool starter { get; set; }
        public bool legendary { get; set; }
        public bool mythical { get; set; }
        public bool mega { get; set; }
        public bool ultraBeast { get; set; }
        public int generation { get; set; }
        public string image { get; set; }
        public string description { get; set; }
        public bool combat { get; set; }
        public bool captured { get; set; }
        public int level { get; set; }
        public int health { get; set; }
        public int experience { get; set; }

        public Pokemon(string id, string name, string abilities, string specie, string type, string height,
                       string weight, string evolution, bool starter, bool legendary, bool mythical,
                       bool mega, bool ultraBeast, int generation, string image, string description,
                       bool combat, bool captured, int level, int health, int experience)
        {
            this.id = id;
            this.name = name;
            this.abilities = abilities;
            this.specie = specie;
            this.type = type;
            this.height = height;
            this.weight = weight;
            this.evolution = evolution;
            this.starter = starter;
            this.legendary = legendary;
            this.mythical = mythical;
            this.mega = mega;
            this.ultraBeast = ultraBeast;
            this.generation = generation;
            this.image = image;
            this.description = description;
            this.combat = combat;
            this.captured = captured;
            this.level = level;
            this.health = health;
            this.experience = experience;
        }

        public Pokemon()
        {
          
        }
    }
}
