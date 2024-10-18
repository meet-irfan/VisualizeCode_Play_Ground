using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selectionsort
{


    class SelectionSortOptimized
    {
        static void SelectionSort(int[] arr)
        {
            for (int i = 0, min; i < arr.Length - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < arr.Length; j++)
                    if (arr[j] < arr[min]) min = j;
                (arr[i], arr[min]) = (arr[min], arr[i]);
            }
        }

        static void Main()
        {
            int[] arr = { 64, 25, 12, 22, 11 };
            SelectionSort(arr);
            Console.WriteLine(string.Join(" ", arr));
            Console.ReadLine();
        }
    }




}
