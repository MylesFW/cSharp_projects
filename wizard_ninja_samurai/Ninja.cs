using System;

namespace wizard_ninja_samurai
{
    public class Ninja : Human
    {
    public Ninja(string name) : base(name)
    {
        FullName = name;
        Strength = 3;
        Intelligence = 3;
        Dexterity = 175;
        Health = 100;

        PrintStats();
    }
    public int Attack(Human target)
    {
        int damage = 5 * target.Dexterity;

        Random rand = new Random();
        if (rand.Next(1, 11) < 3)
        {
            damage += 10;
        }
        return target.TakeDamage(damage);
    }
    public int Steal(Human target)
    {
        int damage = 5;
        Health += damage;
        return target.TakeDamage(damage);
    }
    }
}