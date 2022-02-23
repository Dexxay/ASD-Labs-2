using System;

namespace ASD_LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello! Enter a number of elements in array: ");
            int size = InputHelper.GetSize();
            Console.Write("Choose generation of array: ('r' - random; 'b' - for already sorted array; 'w' - for array sorted in reverse way): ");
            int[] array = InputHelper.ChooseGeneration(size);
            Console.WriteLine("\nGenerated array: ");
            ArrayOperator.DisplayArray(array);

            Console.Write("\nChoose sort of array ('b' - for bubble sort; 'c' for comb sort) : ");
            int compares = InputHelper.ChooseSort(array, out int swaps);
            Console.WriteLine("\nSorted array: ");
            ArrayOperator.DisplayArray(array);

            Console.WriteLine($"\nNumber of compares is : {compares}\nNumber of swaps is : {swaps}");
            Console.ReadKey();
        }
    }
}
