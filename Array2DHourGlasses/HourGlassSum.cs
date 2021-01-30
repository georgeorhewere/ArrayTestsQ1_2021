using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayTestsQ1_2021.Array2DHourGlasses
{
    public class HourGlassSum
    {
        int[,] baseArray = {
                            {-9, -9, -9, 1, 1, 1},
                            {0, -9, 0, 4, 3, 2},
                            {-9, -9, -9, 1, 2, 3},
                            {0, 0, 8, 6, 6, 0},
                            {0, 0, 0, -2, 0, 0},
                            {0, 0, 1, 2, 4, 0}
                          };
        List<int> hourGlassSums = new List<int>();

        int rowLength;
        int colLength;
        public HourGlassSum()
        {
            rowLength = baseArray.GetLength(0);
            colLength = baseArray.GetLength(1);

        }
        public void getSum()
        {

            Console.WriteLine("Get Hour Glasses");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Hour Glasses in Row " + (i + 1));             
                getHourGlass(i);
                Console.WriteLine();
            }
            Console.WriteLine("Max Sum" + hourGlassSums.Max());
        }

        public void getHourGlass(int row)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.WriteLine(" " + baseArray[row, j] + " " + baseArray[row, j + 1] + " " + baseArray[row, j + 2]);
                var topSum = baseArray[row, j] + baseArray[row, j + 1] + baseArray[row, j + 2];
                var mid = getHourGlassMid(row + 1, j + 1);
                var bottomSum = getHourGlassBottom(row + 2, j);
                var totalSum = topSum + mid + bottomSum;
                Console.WriteLine("Sum " + totalSum);
                hourGlassSums.Add(totalSum);

                Console.WriteLine();
            }
        }
        public int getHourGlassMid(int row, int colIndex)
        {
            Console.WriteLine("   " + baseArray[row, colIndex]);
            return baseArray[row, colIndex];
        }

        public int getHourGlassBottom(int row, int j)
        {           
            Console.WriteLine(" " + baseArray[row, j] + " " + baseArray[row, j + 1] + " " + baseArray[row, j + 2]);
            return baseArray[row, j] + baseArray[row, j + 1] + baseArray[row, j + 2];
        }





    }
}
