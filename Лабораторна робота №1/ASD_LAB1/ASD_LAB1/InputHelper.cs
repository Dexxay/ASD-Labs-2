using System;
using System.Collections.Generic;
using System.Text;

namespace ASD_LAB1
{
    class InputHelper
    {
        public static int GetSize()
        {
            while (true)
            {
                string input = Console.ReadLine();
                int number = Convert.ToInt32(input);
                if (number > 0)
                {
                    return number;
                }
                Console.Write("Wrong number. Enter a correct one: ");
            }
        }

        public static int[] ChooseGeneration(int size)
        {
            int[] array = new int[size];
            while (true)
            {
                string input = Console.ReadLine();
                switch (input)
                {
                    case "r":
                        array = ArrayOperator.GenerateRandomArray(size);
                        return array;

                    case "b":
                        array = ArrayOperator.GenerateSequenceArray(size);
                        return array;

                    case "w":
                        array = ArrayOperator.GenerateReversedSequenceArray(size);
                        return array;
                    default:
                        Console.Write("Wrong symbol. Enter a correct one: ");
                        break;
                }
            }
        }

        public static int ChooseSort(int[]array, out int swaps)
        {
            int compares = 0;
            while (true)
            {
                string input = Console.ReadLine();
                switch (input)
                {
                    case "b":
                        compares = Sort.BubbleSort(array, out swaps);
                        return compares;

                    case "c":
                        compares = Sort.CombSort(array, out swaps);
                        return compares;

                    default:
                        Console.Write("Wrong symbol. Enter a correct one: ");
                        break;
                }
            }
        }


    }
}
