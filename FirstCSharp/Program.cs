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
            Console.WriteLine($"Name: {human1._Name}, Strength: {human1._Str}, Intelligence: {human1._Intel}, Dexterity: {human1._Dex}, Health: {human1._Health}");
            Console.WriteLine($"Name: {human2._Name}, Strength: {human2._Str}, Intelligence: {human2._Intel}, Dexterity: {human2._Dex}, Health: {human2._Health}");
            human1.Attack(human2);
            Console.WriteLine($"Name: {human2._Name}, Strength: {human2._Str}, Intelligence: {human2._Intel}, Dexterity: {human2._Dex}, Health: {human2._Health}");
        }
    }
}