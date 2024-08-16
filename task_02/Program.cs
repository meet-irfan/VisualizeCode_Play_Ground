using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_05
{
    using System;

    class BubbleSort
    {
        static void Main()
        {
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
            Console.WriteLine("Original Array:");
            PrintArray(arr);

            BubbleSortAlgorithm(arr);

            Console.WriteLine("\nSorted Array:");
            PrintArray(arr);
        }

        static void BubbleSortAlgorithm(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                // Last i elements are already sorted
                for (int j = 0; j < n - i - 1; j++)
                {
                    // Swap if the element is greater than the next element
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        static void PrintArray(int[] arr)
        {
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.ReadKey();

        }
    }

}
