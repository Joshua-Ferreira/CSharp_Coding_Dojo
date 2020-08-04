using System;
using System.Collections.Generic;

namespace Collections_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Three Basic Arrays
            int[] array1 = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string[] array2 = new string[] { "Tim", "Martin", "Nikki", "Sara" };
            bool[] array3 = new bool[] { true, false, true, false, true, false, true, false, true, false };

            //List of Flavors
            List<object> iceCreamFlavors = new List<object> { "Cookies N' Cream", "Birthday Cake", "Vanilla", "Mint Chocolate Chip", "Chocolate" };
            System.Console.WriteLine(iceCreamFlavors.Count);
            System.Console.WriteLine(iceCreamFlavors[3]);
            iceCreamFlavors.RemoveAt(3);
            System.Console.WriteLine(iceCreamFlavors.Count);

            // User Info Dictionary
            Random rand = new Random();
            Dictionary<string, string> dic1 = new Dictionary<string, string>();
            foreach (var index in array2)
            {
                dic1.Add(index, (string)iceCreamFlavors[rand.Next(0, 4)]);
            }

            foreach (var entry in dic1)
            {
                System.Console.WriteLine(entry.Key + " - " + entry.Value);
            }
        }
    }
}
