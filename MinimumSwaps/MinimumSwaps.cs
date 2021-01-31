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
            numberOfSwaps = 0;
        }


        public void BubbleSort()
        {
            int[] bubbleSortArray = new int [sortArray.Length];
            sortArray.CopyTo(bubbleSortArray,0);

            int size = bubbleSortArray.Length;

            int i, j, temp;
            for (i = 0; i < (size - 1); i++)
            {
                for (j = 0; j < size - i - 1; j++)
                {
                    if (more(bubbleSortArray[j], bubbleSortArray[j + 1]))
                    {
                        /* Swapping */
                        temp = bubbleSortArray[j];
                        bubbleSortArray[j] = bubbleSortArray[j + 1];
                        bubbleSortArray[j + 1] = temp;
                        numberOfSwaps++;
                    }
                }
            }

            bubbleSortArray.ToList().ForEach(x => Console.Write(x + " "));
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
