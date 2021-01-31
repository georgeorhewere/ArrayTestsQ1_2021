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

        public void insertionSort()
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
