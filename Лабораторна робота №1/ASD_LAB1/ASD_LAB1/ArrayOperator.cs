using System;
using System.Collections.Generic;
using System.Text;

namespace ASD_LAB1
{
    class ArrayOperator
    {
        public static int[] GenerateRandomArray(int size)
        {
            int[] array = new int[size];
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = rand.Next(-size, size);
            }
            return array;
        }

        public static int[] GenerateSequenceArray(int size)
        {
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = i + 1;
            }
            return array;
        }

        public static int[] GenerateReversedSequenceArray(int size)
        {
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = size - i;
            }
            return array;
        }

        public static void DisplayArray(int[] arr)
        {
            Console.Write($"How much elements you want to display? (Max is {arr.Length}): ");
            int number;
            while (true)
            {
                string input = Console.ReadLine();
                number = Convert.ToInt32(input);
                if (number > 0 && number <= arr.Length)
                {
                    break;
                }
                Console.Write("Wrong number. Enter a right one: ");
            }
            for (int i = 0; i < number; i++)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine();
        }
    }
}
