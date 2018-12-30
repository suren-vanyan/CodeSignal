using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_H._4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5, 3, 6, 7, 3, 8, 9 };
            int value = 3;

            Console.WriteLine(string.Join("", Rotate(myArray, value)));
            Console.ReadLine();
        }
        static List<int> Rotate(int[] array, int value)
        {
            int firstInd = 0;
            int lastInd = array.Length - 1;
            int[] second;
            //var newArray = new int[array.Length];
            List<int> newArray = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (value == array[i])
                {
                    second = GetSubArray(array, firstInd, i - firstInd + 1);
                    Array.Reverse(second);
                    newArray.AddRange(second);
                    newArray.Add(value);
                    firstInd = i + 1;
                }
            }
            return newArray;

        }

        static int[] GetSubArray(int[] source, int startingIndex, int length)
        {
            var newArray = new int[length];
            Array.Copy(source, startingIndex, newArray, 0, length);
            return newArray;
        }

    }
}