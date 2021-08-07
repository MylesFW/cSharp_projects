using System;

namespace wizard_ninja_samurai
{
    public class Samurai : Human
    {
    public Samurai(string name) : base(name)
    {
        FullName = name;
        Strength = 3;
        Intelligence = 3;
        Dexterity = 3;
        Health = 200;

        PrintStats();
    }
    public int Attack(Human target)
    {
        int damage = Strength*3;
        if (target.Health < 50)
        {
            target.Health = 0;
        }
        return target.TakeDamage(damage);
    }
    public int Meditate(Human Samurai)
    {
        int fullHealth = 200;
        Health = fullHealth;
        return fullHealth;
    }
    }
}