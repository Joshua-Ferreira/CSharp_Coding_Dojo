using System;
using System.Collections.Generic;

namespace Basic_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            ShiftValues(numbers);
        }


        //Print 1-255
        public static void PrintNumbers()
        {
            // Print all of the integers from 1 to 255.
            for (int i = 1; i <= 255; i++)
            {
                System.Console.WriteLine(i);
            }
        }

        //Print odd numbers between 1-255
        public static void PrintOdds()
        {
            // Print all of the odd integers from 1 to 255.
            for (int i = 1; i <= 255; i++)
            {
                if (i % 2 == 1)
                {
                    System.Console.WriteLine(i);
                }
            }
        }

        //Print Sum
        public static void PrintSum()
        {
            int sum = 0;
            for (int i = 0; i <= 255; i++)
            {
                sum += i;
                System.Console.WriteLine($"New number:{i} Sum:{sum}");
            }
            // Print all of the numbers from 0 to 255, 
            // but this time, also print the sum as you go. 
            // For example, your output should be something like this:

            // New number: 0 Sum: 0
            // New number: 1 Sum: 1
            // New Number: 2 Sum: 3
        }

        //Iterating through an Array
        int[] array1 = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        public static void LoopArray(int[] array1)//(int[] numbers)
        {
            foreach (var index in array1)
            {
                System.Console.WriteLine(array1[index]);
            }
            // Write a function that would iterate through each item of the given integer array and 
            // print each value to the console. 
        }

        //Find Max
        public static void FindMax(int[] numbers)
        {
            // Write a function that takes an integer array and prints and returns the maximum value in the array. 
            // Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), 
            // or even a mix of positive numbers, negative numbers and zero.
            int max = numbers[0];
            foreach (var index in numbers)
            {
                if (max < index)
                {
                    max = index;
                }
            }
            System.Console.WriteLine($"Max value in array is {max} ");
        }

        //Get Average
        public static void GetAverage(int[] numbers)
        {
            int ave = 0;
            // Write a function that takes an integer array and prints the AVERAGE of the values in the array.
            // For example, with an array [2, 10, 3], your program should write 5 to the console.
            foreach (var index in numbers)
            {
                ave += index;
            }
            System.Console.WriteLine(ave);
            System.Console.WriteLine(ave / numbers.Length);
        }

        //Array with Odd Numbers
        public static void OddArray()
        {
            int[] odd = new int[256];
            for (int i = 0; i <= 255; i++)
            {
                if (i % 2 == 1)
                {
                    odd[i] = i;
                }
            }
            System.Console.WriteLine(odd);
        }
        // Write a function that creates, and then returns, an array that contains all the odd numbers between 1 to 255. 
        // When the program is done, this array should have the values of [1, 3, 5, 7, ... 255].


        //Greater than Y
        public static void GreaterThanY(int[] numbers, int y)
        {
            // Write a function that takes an integer array, and a integer "y" and returns the number of array values 
            // That are greater than the "y" value. 
            // For example, if array = [1, 3, 5, 7] and y = 3. Your function should return 2 
            // (since there are two values in the array that are greater than 3).
            int count = 0;
            foreach (var index in numbers)
            {
                if (y < index)
                {
                    count++;
                }
            }
            System.Console.WriteLine(count);
        }

        //Square the Values
        public static void SquareArrayValues(int[] numbers)
        {
            // Write a function that takes an integer array "numbers", and then multiplies each value by itself.
            // For example, [1,5,10,-10] should become [1,25,100,100]
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = numbers[i] * numbers[i];
                System.Console.WriteLine(numbers[i]);
            }

        }

        //Eliminate Negative Numbers
        public static void EliminateNegatives(int[] numbers)
        {
            // Given an integer array "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0. 
            // When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers[i] = 0;
                }
            }
        }

        //Min, Max, and Average
        public static void MinMaxAverage(int[] numbers)
        {
            // Given an integer array, say [1, 5, 10, -2], create a function that prints the maximum number in the array, 
            // the minimum value in the array, and the average of the values in the array.
            int max = numbers[0];
            int min = numbers[0];
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                    sum += numbers[i];
                }
                else if (numbers[i] > max)
                {
                    max = numbers[i];
                    sum += numbers[i];
                }
                else
                {
                    sum += numbers[i];
                }
            }
            int ave = sum / numbers.Length;
            System.Console.WriteLine(min);
            System.Console.WriteLine(max);
            System.Console.WriteLine(ave);
        }

        //Shifting the values in an array
        public static void ShiftValues(int[] numbers)
        {
            // Given an integer array, say [1, 5, 10, 7, -2], 
            // Write a function that shifts each number by one to the front and adds '0' to the end. 
            // For example, when the program is done, if the array [1, 5, 10, 7, -2] is passed to the function, 
            // it should become [5, 10, 7, -2, 0].
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i != numbers.Length - 1)
                {
                    numbers[i] = numbers[i + 1];
                }
                else
                {
                    numbers[i] = 0;
                }
                System.Console.WriteLine(numbers[i]);
            }
        }

        //Number to String
        public static void NumToString(int[] numbers)
        {
            // Write a function that takes an integer array and returns an object array 
            // that replaces any negative number with the string 'Dojo'.
            // For example, if array "numbers" is initially [-1, -3, 2] 
            // your function should return an array with values ['Dojo', 'Dojo', 2].
            object[] result = new object[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    result[i] = "Dojo";
                }
                else
                {
                    result[i] = numbers[i];
                }
                System.Console.WriteLine(result[i]);
            }
        }
    }
}

