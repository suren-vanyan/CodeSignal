﻿using System;
using System.Linq;

namespace absoluteValuesSumMinimization
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 8, 6, 3, 10 };
            Console.WriteLine(absoluteValuesSumMinimization(a));
        }

        static int absoluteValuesSumMinimization(int[] a)
        {
            int smallPoss = int.MaxValue;
            int minValue = 0, temp = 0;

            foreach (int n in a)
            {
                temp = a.Select(i => Math.Abs(n - i)).Sum();
                if (smallPoss > temp)
                {
                    smallPoss = temp;
                    minValue = n;
                }

            }

            return minValue;
        }
    }
}