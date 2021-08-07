using System;
using System.Collections.Generic;

namespace FirstCSharp
{
    public class Program
    {
        // ---------------------------------------------------------------------
        // public static string SayHello(string firstName = "el hefe")
        // {
        //     return $"Hello there {firstName}!";
        // }
        // public static void Main()
        // {
        //     string greeting;
        //     greeting = SayHello();
        //     Console.WriteLine(greeting);
        // }
        // ---------------------------------------------------------------------
        public static void PrintNumbers()
        {
            for (int a = 0; a <= 255; a++)
            {
                Console.WriteLine(a);
            }
        }
        public static void PrintOdds()
        {
            for (int b = 0; b <= 255; b++)
            {
                if (b % 2 == 1)
                {
                    Console.WriteLine(b);
                }
            }
        }
        public static void PrintSum()
        {
            int sum = 0;
            for (int c = 0; c <= 255; c++)
            {
                sum += c;
                Console.WriteLine("New Number: " + c + " Sum: " + sum);
            }
        }

        public static void LoopArray(int[] numbers)

        {
            foreach (int singleNumber in numbers)
            {
                Console.WriteLine(singleNumber);
            }
        }

        public static int FindMax(int[] numbers)
        {
            int maxNum = 0;
            foreach (int singleNumber in numbers)
            {
                if (singleNumber > maxNum)
                {
                    maxNum = singleNumber;
                }
            }
            Console.WriteLine(maxNum);
            return maxNum;
        }

        public static void GetAverage(int[] numbers)
        {
            int avg = 0;
            foreach ( int singleNumber in numbers)
            {
                avg += singleNumber;
            }
            int totalAvg = avg/numbers.Length;
            Console.WriteLine(totalAvg);
        }

        public static int[] OddArray()
        {
            int total = 255;
            int totalOdds = 0;
            int[] oddNums = new int[total/2+2]; // +2 
            for (int i = 0; i <= total; i++)
            {
                if ( i % 2 != 0)
                {
                    totalOdds++;
                    oddNums[totalOdds] = i;
                }
            }
            //TEST ARRAY AND VIEW INSIDE OF ARRAY 
            for (int num = 0; num < oddNums.Length; num++)
            {
                Console.WriteLine(oddNums[num]);
            }
            return oddNums;
        }

        public static int GreaterThanY(int[] numbers, int y)
        {
            int yPlus = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > y)
                {
                    yPlus++;
                }
            }
            Console.WriteLine(yPlus);
            return yPlus;
        }

        public static void SquareArrayValues(int[] numbers)
        {
            int sqrValue = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sqrValue = (numbers[i] * numbers[i]);
                Console.WriteLine(sqrValue);
            }
        }

        public static void EliminateNegatives(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers[i] = 0;
                }
                Console.WriteLine(numbers[i]);
            }
        }

        public static void MinMaxAverage(int[] numbers)
        {
            int min = 0;
            int max = 0;
            int avg = 0;
            foreach (int num in numbers)
            {
                avg += num;
                if (num > max)
                {
                    max = num;
                }
                else if (num < min)
                {
                    min = num;
                }
            }
            avg = avg/numbers.Length;
            Console.WriteLine("Maximum: " + max);
            Console.WriteLine("Minimum: " + min);
            Console.WriteLine("Average: " + avg);
        }
    

        public static void ShiftValues(int[] numbers)
        {            
            for (int i = 0; i < numbers.Length; i++)
            {
                if ( i == numbers.Length-1)
                {
                    numbers[i] = 0;
                }
                else
                {
                    numbers[i] = numbers[i + 1];
                }
                Console.WriteLine(numbers[i]);
            }
        }

        public static object[] NumToString(int[] numbers)
        {
            object[] nums = new object[numbers.Length];
            
            for (int i = 0; i < numbers.Length; i++)
            {
                if ( numbers[i] < 0 )
                {
                    nums[i] = "Dojo";
                }
                else
                {
                    nums[i] = numbers[i];
                }
            }
            return nums;
        }


        public static void Main(string[] args)
        {

            int[] testArray = new int[] {-1, -2, -3, -4, 5, 5, 4, 3, 2, 1};
            int[] newTestArray = new int[] {-1, -2, -3, -4, 5, 5, 4, 3, 2, 1};
            int[] testArray3 = new int[] {-1, -2, -3, -4, 5, 5, 4, 3, 2, 1};
            // int y = 2;

            // Console.WriteLine("START of question 1: ******************************************");
            // PrintNumbers();

            // Console.WriteLine("START of question 2: ******************************************");
            // PrintOdds();

            // Console.WriteLine("START of question 3: ******************************************");
            // PrintSum();

            // Console.WriteLine("START of question 4: ******************************************");
            // LoopArray(testArray);

            // Console.WriteLine("START of question 5: ******************************************");
            // FindMax(testArray);

            // Console.WriteLine("START of question 6: ******************************************");
            // GetAverage(testArray);

            // Console.WriteLine("START of question 7: ******************************************");
            // OddArray();

            // Console.WriteLine("START of question 8: ******************************************");
            // GreaterThanY(testArray, y);

            // Console.WriteLine("START of question 9: ******************************************");
            // SquareArrayValues(testArray);

            // Console.WriteLine("START of question 10: ******************************************");
            // EliminateNegatives(testArray);

            // Console.WriteLine("START of question 11: ******************************************");
            // MinMaxAverage(newTestArray);

            // Console.WriteLine("START of question 12: ******************************************");
            // ShiftValues(newTestArray);

            // Console.WriteLine("START of question 13: ******************************************");
            // NumToString(testArray3);

            //question 13 can also be written this way
            // Console.WriteLine(String.Join(", ", NumToString(testArray3))); 

        }
    }
}
