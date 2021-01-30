using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayTestsQ1_2021.RotateArrayLeft
{
    public class RotateArrayLeft
    {

        private int[] preRotateArray;
        private int numberOfRotations;
        public RotateArrayLeft(int rotations, int[] inputArray)
        {
            preRotateArray = inputArray;
            numberOfRotations = rotations;

        }

        public  int[] getRotatedArray()
        {
            int length = preRotateArray.Length - 1 ;
            // implementation with span
            Span<int> rotateSpan = new Span<int>(preRotateArray, 0, numberOfRotations);
            Span<int> newStartItems = new Span<int>(preRotateArray, numberOfRotations, preRotateArray.Length - numberOfRotations);

            Console.WriteLine("Span content");
            //for (int i = 0; i < rotateSpan.Length; i++)
            //{
            //    Console.Write($"{rotateSpan[i]} ");
            //}
            //Console.WriteLine();
            //for (int i = 0; i < newStartItems.Length; i++)
            //{
            //    Console.Write($"{newStartItems[i]} ");
            //}
            //Console.WriteLine();


            //int currentStartVal = preRotateArray[0];
            //for(int s= 0; s < length; s++)
            //{
            //    int rotateValue = preRotateArray[s + 1];
            //    preRotateArray.SetValue(rotateValue, s);
            //}
            //preRotateArray[length] = currentStartVal;

            return  newStartItems.ToArray().Concat(rotateSpan.ToArray()).ToArray();
        }




    }
}
