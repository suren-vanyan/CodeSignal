using System;

namespace arrayChange
{
    class Program
    {
        //You are given an array of integers.
        // On each move you are allowed to increase exactly one 
        //  of its element by one.Find the minimal 
        //  number of moves required to obtain a strictly 
        // increasing sequence from the input
        static void Main(string[] args)
        {
            int[] array = new int[] { 2, 3, 3, 5, 5, 5, 4, 12, 12, 10, 15 };

            Console.WriteLine(arrayChange(array));

        }

        static int arrayChange(int[] inputArray)
        {
            int temp = inputArray[0];
            int counter = 0;
            for (int i = 1; i < inputArray.Length; i++)
            {
                while (temp >= inputArray[i])
                {
                    inputArray[i]++;
                    counter++;
                }
                if (temp < inputArray[i])
                    temp = inputArray[i];

            }
            return counter;
        }

    }
}
