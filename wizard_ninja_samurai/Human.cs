using System;

namespace wizard_ninja_samurai
{
    public class Human : ICanBeDamaged
    {
        public string FullName; // <- "fields" expect this data
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;
        public int Health
        {
            get { return health; }
            set { health = value; }
        }
    public Human(string name) // <- one "constructor" 
    {
        FullName = name;
        Strength = 2;
        Intelligence = 5;
        Dexterity = 3;
        Health = 100;
    }
    public Human(string name, int str, int intel, int dex, int health) // second "constructor" (what will change)
    {
        FullName = name;
        Strength = str;
        Intelligence = intel;
        Dexterity = dex;
        Health = health;
    }
    public void PrintStats()
    {
        Console.WriteLine("-------------------------------");
        Console.WriteLine($"{FullName}");
        Console.WriteLine($" >> Str: {Strength}");
        Console.WriteLine($" >> Int: {Intelligence}");
        Console.WriteLine($" >> Dex: {Dexterity}");
        Console.WriteLine($" >> Health: {Health}");
    }

    public int TakeDamage(int dmgAmnt) // <- "method" 
    {
        Health -= dmgAmnt;
        return Health;
    }
    }
}