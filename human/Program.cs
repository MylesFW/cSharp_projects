using System;
using System.Collections.Generic;

namespace FirstCSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human("Myles", 1, 5, 2, 10);
            Human human2 = new Human("Josh");
            Console.WriteLine($"Name: {human1.Name}, Strength: {human1.Str}, Intelligence: {human1.Intel}, Dexterity: {human1.Dex}, Health: {human1.Health}");
            Console.WriteLine($"Name: {human2.Name}, Strength: {human2.Str}, Intelligence: {human2.Intel}, Dexterity: {human2.Dex}, Health: {human2.Health}");
            human1.Attack(human2);
            Console.WriteLine($"Name: {human2.Name}, Strength: {human2.Str}, Intelligence: {human2.Intel}, Dexterity: {human2.Dex}, Health: {human2.Health}");
        }
    }
}