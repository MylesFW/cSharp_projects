using System;
using System.Collections.Generic;

namespace Puzzles
{
    public class Functions
    {
        public void RandomArray()
        {
            int[] array = new int[10];
            Random rnd = new Random();

            int min = 0;
            int max = 0;
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(5, 26);

                sum += array[i];

                if (array[i] < min)
                {
                    min = array[i];
                }
                else if (array[i] > max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine(sum);
        }

        public string TossCoin()
        {
            // Console.WriteLine("Tossing a coin!");

            int flip = 1;
            Random rnd = new Random();

                flip = rnd.Next(1, 11);

                string singleResult = "";

                if (flip < 5)
                {
                  singleResult = "heads";
                  Console.WriteLine("You flipped HEADS");
                }
                else
                {
                  singleResult = "tails";
                  Console.WriteLine("You flipped TAILS");
                }
              return singleResult;
        }

        public double TossMultipleCoins(int num)
        {
            List<string> flipResults = new List<string>();
                int remainingFlips = num;
                int heads = 0;
                int tails = 0;

            while(remainingFlips > 0)
            {
                flipResults.Add(TossCoin());
                remainingFlips--;
            }
            Console.WriteLine(flipResults.Count);

            foreach (string result in flipResults)
            {
                if (result == "heads")
                {
                    heads++;
                }
                else
                {
                    tails++;
                }
            }
            Console.WriteLine(heads);
            Console.WriteLine(num);
            double finalResults = ((double) heads)/((double) num);
            Console.WriteLine(finalResults);
            return finalResults;
        }

        public List<string> Names()
        {
          List<string> nameList = new List<string>()
          {
            "Todd", "Tiffany", "Charlie", "Geneva", "Sydney"
          };
          Random rnd = new Random();

          for (var i = 0; i < nameList.Count/2; i++)
          {
            int rndIndex = rnd.Next(nameList.Count);
            string tempName = nameList[rndIndex];
            nameList[rndIndex] = nameList[i];
            nameList[i] = tempName;
          }

          foreach (var name in nameList)
          {
              Console.WriteLine("Shuffled List: " + name);
          }

          for (var i = 0; i < nameList.Count; i++)
          {
              if ( nameList[i].Length <= 5)
              {
                nameList.RemoveAt(i);
              }
                Console.WriteLine("Names Longer Than 5 chars: " + nameList[i]);
          }
          return nameList;
        }
    }
}