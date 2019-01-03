using System;

namespace arrayMaxConsecutiveSum
{
   // Given array of integers, find the maximal possible sum of some of its k consecutive elements.
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = { 3, 2, 1, 1 };
            int k = 1;
            Console.WriteLine(arrayMaxConsecutiveSum(inputArray, k));
        }

        static int arrayMaxConsecutiveSum(int[] inputArray, int k)
        {
            int maxSum = 0;
            int previoussum = 0;
            int j = 0;
            while (j + 1 <= k && j < inputArray.Length)
            {
                previoussum += inputArray[j++];
            }

            maxSum = previoussum;
            for (int i = 1; i <= inputArray.Length - k; i++)
            {
                int tempSum = previoussum - inputArray[i - 1] + inputArray[i + k - 1];
                if (maxSum < tempSum) maxSum = tempSum;
                previoussum = tempSum;

            }

            return maxSum;
        }


    }
}
