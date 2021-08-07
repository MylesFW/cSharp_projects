using System;

namespace FirstCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 0; a <= 255; a++) 
            {
                Console.WriteLine(a);
            }

            for (int b = 0; b <= 100; b++)
            {
                if ( b % 3 == 0 || b % 5 == 0 )
                {
                    Console.WriteLine(b);
                }
            }

            for (int c = 0; c <= 100; c++)
            {
                if ( c % 3 == 0 && c % 5 == 0 )
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if ( c % 3 == 0 )
                {
                    Console.WriteLine("Fizz");
                } 
                else if (c % 5 == 0 )
                {
                    Console.WriteLine("Buzz");
                }
            }

        }
    }
}
