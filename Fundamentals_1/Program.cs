using System;

namespace Fundamentals_1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 255; i++)
            {
                System.Console.WriteLine(i);
            }

            for (int x = 1; x <= 100; x++)
            {
                if (x % 15 == 0)
                { }
                else if (x % 3 == 0 || x % 5 == 0)
                {
                    System.Console.WriteLine(x);
                }
            }

            for (int j = 1; j < 101; j++)
            {
                if (j % 15 == 0)
                {
                    System.Console.WriteLine("FizzBuzz");
                }
                else if (j % 3 == 0)
                {
                    System.Console.WriteLine("Fizz");
                }
                else if (j % 5 == 0)
                {
                    System.Console.WriteLine("Buzz");
                }
            }

        }
    }
}
