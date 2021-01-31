using ArrayTestsQ1_2021.Array2DHourGlasses;
using System;

namespace ArrayTestsQ1_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array Algorithms!");
            TestMinimumSwaps();
            
            Console.ReadKey();
        }

        public static void TestHourGlassSum()
        {
            HourGlassSum sumManager = new HourGlassSum();
            sumManager.getSum();

        }

        public static void TestRotateArray()
        {
            int rotations = 3;
            int[] inputArray = new int[] { 1, 2, 3, 4, 5 };

            RotateArrayLeft.RotateArrayLeft manager = new RotateArrayLeft.RotateArrayLeft(rotations, inputArray);
            var rotList = manager.getRotatedArray();
            for (int x = 0; x < rotList.Length; x++)
            {
                Console.Write(rotList[x] + " ");
            }
        }


        public static void TestMinimumSwaps()
        {
            int[] inputArray = new int[] { 7,1,3 ,2,4,5, 6};
            MinimumSwaps swapManager = new MinimumSwaps(inputArray);
            swapManager.BubbleSort();
            Console.WriteLine($"Minimum swaps with bubble sort {swapManager.Swaps}");

        }


    }
}
