using System;

namespace wizard_ninja_samurai
{
    class Program
    {
        static void Main(string[] args)
        {
            // Human human1 = new Human("Myles");
            // Human human2 = new Human("Josh");
            // Console.WriteLine("********************************************");
            // human1.Attack(human2);
            
            // Console.WriteLine($"Name: {human1.FullName}");
            // Console.WriteLine($"Str: {human1.Strength}");
            // Console.WriteLine($"Int: {human1.Intelligence}");
            // Console.WriteLine($"Dex: {human1.Dexterity}");
            // Console.WriteLine($"Health: {human1.Health}");

            // Console.WriteLine($"Name: {human2.FullName}");
            // Console.WriteLine($"Str: {human2.Strength}");
            // Console.WriteLine($"Int: {human2.Intelligence}");
            // Console.WriteLine($"Dex: {human2.Dexterity}");
            // Console.WriteLine($"Health: {human2.Health}");


            Wizard wiz_1 = new Wizard("Rory the Great!");
            Ninja nij_1 = new Ninja("Bukuto the Quick");
            Samurai sam_1 = new Samurai("Kensai the Honorable");

            nij_1.Steal(sam_1);
            nij_1.Steal(sam_1);
            nij_1.Steal(sam_1);
            nij_1.Steal(sam_1);
            sam_1.PrintStats();
            nij_1.PrintStats();

            // wiz_1.Heal(sam_1);
            // sam_1.PrintStats();
            // wiz_1.Attack(nij_1);
            // nij_1.PrintStats();
            // nij_1.Attack(wiz_1);
            // wiz_1.PrintStats();
            // sam_1.Attack(wiz_1);
            // wiz_1.PrintStats();
        }
    }
}
