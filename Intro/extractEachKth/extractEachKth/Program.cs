using System;
using System.Collections.Generic;

namespace extractEachKth
{
    class Program
    {
        //Given array of integers, remove each kth element from it.
        static void Main(string[] args)
        {
            int[] inputArray = { 1, 2, 1, 2, 1, 2 };
            foreach (var item in extractEachKth(inputArray, 2))
            {
                Console.WriteLine(item);
            }
        }

        static int[] extractEachKth(int[] inputArray, int k)
        {

            List<int> newArray = new List<int>();
            for (int i = 0, temp = 0; i < inputArray.Length; i++)
            {
                if (temp + 1 != k)
                {
                    newArray.Add(inputArray[i]);
                    temp++;
                }
                else
                    temp = 0;

            }

            return newArray.ToArray();
        }
    }
}
