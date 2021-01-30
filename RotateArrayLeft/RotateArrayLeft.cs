using System;
using System.Collections.Generic;
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

            for(int r=0; r < numberOfRotations; r++)
            {
                int currentStartVal = preRotateArray[0];
                for(int s= 0; s < length; s++)
                {
                    int rotateValue = preRotateArray[s + 1];
                    preRotateArray.SetValue(rotateValue, s);
                }
                preRotateArray[length] = currentStartVal;
            }
            return preRotateArray;
        }




    }
}
