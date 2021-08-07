using System;
using System.Collections.Generic;

namespace Puzzles
{
    public class Program
    {
        static void Main(string[] args)
        {
            Functions funct = new Functions();
            int num = 10;

            funct.RandomArray();
            funct.TossCoin();
            funct.TossMultipleCoins(num);
            funct.Names();
        }
    }
}