using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubblesort
{
   

    class BubbleSortOptimized
    {
        static void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
                for (int j = 0; j < arr.Length - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]); // Swap using tuple assignment
        }

        static void Main()
        {
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
            BubbleSort(arr);
            Console.WriteLine(string.Join(" ", arr));
            Console.ReadLine();
        }
    }

}
