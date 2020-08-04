using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Tohn = new Human("Tohn", str: 10);
            Human Init = new Human();

            Console.WriteLine(Init.Health);
            System.Console.WriteLine(Init.Strength);

            Tohn.Attack(Init);
        }
    }
}
