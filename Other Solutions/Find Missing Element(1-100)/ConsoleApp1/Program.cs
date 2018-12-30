using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        
            static void Main(string[] args)
            {
                int[] myArray = { 1, 2, 3, 4, 0, 6, 7, 8 ,9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21 };
                Console.WriteLine(GetMissingNumber(myArray, 8));
            }

            public static int GetArraySum(int[] inputArray)
            {
                int sum = 0;
                for (int i = 0; i < inputArray.Length; i++)
                {
                    sum += inputArray[i];
                }
                return sum;
            }

            public static int GetMissingNumber(int[] inputArray, int manxValue)
            {
                return manxValue * (manxValue + 1) / 2 - GetArraySum(inputArray);
            }
        
    }
}
