using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ArrayTestsQ1_2021
{
    public class MinimumSwaps
    {
        private int[] sortArray;
        private int numberOfSwaps;

        public MinimumSwaps(int [] inputArray)
        {
            sortArray = inputArray;         
        }


        public void BubbleSort()
        {
            numberOfSwaps = 0;
            int[] bubbleSortArray = new int [sortArray.Length];
            sortArray.CopyTo(bubbleSortArray,0);

            int size = bubbleSortArray.Length;

            int i, j, temp;
            bool swapped = true;

            for (i = 0; i < (size - 1) && swapped; i++)
            {
                swapped = false;
                for (j = 0; j < size - i - 1; j++)
                {
                    if (more(bubbleSortArray[j], bubbleSortArray[j + 1]))
                    {
                        /* Swapping */
                        temp = bubbleSortArray[j];
                        bubbleSortArray[j] = bubbleSortArray[j + 1];
                        bubbleSortArray[j + 1] = temp;
                        swapped = true;
                        
                    }
                }
                numberOfSwaps++;
            }

            bubbleSortArray.ToList().ForEach(x => Console.Write(x + " "));
            Console.WriteLine($"Minimum swaps with modified bubble sort {Swaps}");
        }

        public void InsertionSort()
        {
            numberOfSwaps = 0;
            int[] insertionSortArray = new int[sortArray.Length];
            sortArray.CopyTo(insertionSortArray, 0);

            int size = insertionSortArray.Length;
            int temp, j;
            for (int i = 1; i < size; i++)
            {
                temp = insertionSortArray[i];
                for (j = i; j > 0 && more(insertionSortArray[j - 1], temp); j--)
                {
                    insertionSortArray[j] = insertionSortArray[j - 1];
                }
                insertionSortArray[j] = temp;
                numberOfSwaps++;
            }

            insertionSortArray.ToList().ForEach(x => Console.Write(x + " "));
            Console.WriteLine($"Minimum swaps with insertion sort {Swaps}");

        }


        public void SelectionSort()
        {
            numberOfSwaps = 0;
            int[] selectionSortArray = new int[sortArray.Length];
            sortArray.CopyTo(selectionSortArray, 0);

            int size = selectionSortArray.Length;
            int i, j, max, temp;
            for (i = 0; i < size - 1; i++)
            {
                max = 0;
                for (j = 1; j < size - 1 - i; j++)
                {
                    if (selectionSortArray[j] > selectionSortArray[max])
                    {
                        max = j;
                    }
                }
                temp = selectionSortArray[size - 1 - i];
                selectionSortArray[size - 1 - i] = selectionSortArray[max];
                selectionSortArray[max] = temp;
                numberOfSwaps++;
            }
            selectionSortArray.ToList().ForEach(x => Console.Write(x + " "));
            Console.WriteLine($"Minimum swaps with selection sort {Swaps}");


        }


        public void QuickSort()
        {
            numberOfSwaps = 0;
            int[] quickSortArray = new int[sortArray.Length];
            sortArray.CopyTo(quickSortArray, 0);

            int size = quickSortArray.Length;
            QuickSortUtil(quickSortArray, 0, size - 1);
            quickSortArray.ToList().ForEach(x => Console.Write(x + " "));
            Console.WriteLine($"Minimum swaps with quick sort {Swaps}");
        }
        private void swap(int[] arr, int first, int second)
        {
            int temp = arr[first];
            arr[first] = arr[second];
            arr[second] = temp;
            numberOfSwaps++;
        }
        private void QuickSortUtil(int[] arr, int lower, int upper)
        {
            if (upper <= lower)
            {
                return;
            }
            int pivot = arr[lower];
            int start = lower;
            int stop = upper;
            while (lower < upper)
            {
                while (arr[lower] <= pivot && lower < upper)
                {
                    lower++;
                }
                while (arr[upper] > pivot && lower <= upper)
                {
                    upper--;
                }
                if (lower < upper)
                {
                    swap(arr, upper, lower);
                }
            }
            swap(arr, upper, start); //upper is the pivot position
            QuickSortUtil(arr, start, upper - 1); //pivot -1 is the upper for left sub array.
            QuickSortUtil(arr, upper + 1, stop); // pivot + 1 is the lower for right sub array.
        }

        private bool less(int value1, int value2)
        {
            return value1 < value2;
        }
        private bool more(int value1, int value2)
        {
            return value1 > value2;
        }

        public int Swaps { get { return numberOfSwaps; }  }

    }
}
