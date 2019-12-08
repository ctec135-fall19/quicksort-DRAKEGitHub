/*
 * 
 * Author: Allison Drake
 * CTEC 135: C# Programming Fall 2019
 * Program Quicksort
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    public class Program
    {
        private static int Partition(int[] arr, int lo, int hi)
        {
            int pivot = arr[(lo + hi) /2];
            int i = lo - 1;
            int j = hi + 1;
            
            while(true)
            {
                do
                {
                    i++;
                } while (arr[i] < pivot);

                do
                {
                    j--;
                } while (arr[j] > pivot);

                if (i >= j) return j;

                //swap values
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
        
        private static void quickSort(int[] arr, int lo, int hi)
        {
            if (lo < hi)
            {
                int pivot = Partition(arr, lo, hi);

                quickSort(arr, lo, pivot);
                quickSort(arr, pivot + 1, hi);
            }
        }

        
        static void Main(string[] args)
        {
            int[] arr = new int[] { 9, 4, 5, 0, 12, -33, 19, 6, 3, -12, 8, 1, 89, 16 };

            Console.WriteLine("Array before sorting: ");
            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();

            quickSort(arr, 0, arr.Length - 1);

            Console.WriteLine();
            Console.WriteLine("Quick sorted array: ");

            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();

            

        }
    }
}
