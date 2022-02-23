using System;
using System.Collections.Generic;
using System.Text;

namespace ASD_LAB1
{
    class Sort
    {
        public static int BubbleSort(int[]arr, out int swaps)
        {
            int compares = 0;
            swaps = 0;
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 1; j < arr.Length - i; j++)
                {
                    compares++;
                    if (arr[j-1] > arr[j])
                    {
                        swaps++;
                        temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return compares;
        }

        public static int CombSort(int[]arr, out int swaps)
        {
            int compares = 0;
            swaps = 0;
            double factor = 1.3;
            int step = arr.Length - 1;
            while (step > 1)
            {
                step = (int)(step / factor);
                if (step < 1)
                    step = 1;
                for (int i = 0; i + step < arr.Length; i++)
                {
                    compares++;
                    if (arr[i] > arr[i+step])
                    {
                        swaps++;
                        int temp = arr[i + step];
                        arr[i + step] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            return compares;
        }
    }
}
