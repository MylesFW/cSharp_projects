using System.Collections.Generic;
using System;

namespace FirstCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            //THREE BASIC ARRAYS

            int[] num1 = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            Console.WriteLine(num1[4]); //will print number at index 4

            string[] name1 = {"Tim", "Martin", "Nikki", "Sara"};
            Console.WriteLine(name1[3]); //will print name at index 3

            bool[] trueNfalse1 = {true, false, true, false, true, false, true, false, true, false};
            Console.WriteLine(trueNfalse1[2]); //will print bool at index 2

            //LIST OF FLAVORS

            List<string> iceCream = new List<string>();
                iceCream.Add("vanilla");
                iceCream.Add("chocolate");
                iceCream.Add("honey-glazed ham");
                iceCream.Add("hot garbage");
                iceCream.Add("moutain fresh");

            Console.WriteLine(iceCream.Count);
            
            Console.WriteLine(iceCream[3]);
            iceCream.Remove("hot garbage");

            Console.WriteLine(iceCream.Count);

            //USER INFO DICTIONARY

            Dictionary<string, string> user = new Dictionary<string, string>();
                user.Add(name1[0], iceCream[0]);
                user.Add(name1[1], iceCream[1]);
                user.Add(name1[2], iceCream[2]);

            foreach ( KeyValuePair<string, string> singleUser in user )
            {
                Console.WriteLine("Their name is " + singleUser.Key + ", and their favorite ice cream flavor is " + singleUser.Value);
            }
        }
    }
}
