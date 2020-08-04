using System;
using System.Collections.Generic;
namespace BoxUnbox
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> list1 = new List<object> { 7, 28, -1, true, "chair" };
            int sum = 0;

            foreach (object item in list1)
            {
                System.Console.WriteLine(item);
                if (item is int)
                {
                    sum += (int)item;
                }
            }
            System.Console.WriteLine(sum);
        }
    }
}
