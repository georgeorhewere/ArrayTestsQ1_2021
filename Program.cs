using ArrayTestsQ1_2021.Array2DHourGlasses;
using System;

namespace ArrayTestsQ1_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array Algorithms!");
            TestHourGlassSum();
            
            Console.ReadKey();
        }

        public static void TestHourGlassSum()
        {
            HourGlassSum sumManager = new HourGlassSum();
            sumManager.getSum();

        }
    }
}
