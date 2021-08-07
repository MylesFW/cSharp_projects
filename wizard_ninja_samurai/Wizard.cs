using System;

namespace wizard_ninja_samurai
{
    public class Wizard : Human
    {
    public Wizard(string name) : base(name)
    {
        FullName = name;
        Strength = 3;
        Intelligence = 25;
        Dexterity = 3;
        Health = 50;

        PrintStats();
    }
    public int Attack(Human target) // <- can also be (Human target) as long as all humans could be attacked
    {
        int damage = 5 * target.Intelligence;
        Health += damage;
        return target.TakeDamage(damage);
    }
    public int Heal(Human target)
    {
        int heal = 10 * target.Intelligence;
        Health += heal;
        return target.TakeDamage(heal * -1);
    }
    }
}