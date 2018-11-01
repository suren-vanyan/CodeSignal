using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int index = 5;

            Console.WriteLine(string.Join("", Rotate(myArray, index)));
            Console.ReadLine();

        }

        static int[] Rotate(int[] array, int index)
        {
            var first = GetSubArray(array, 0, index);
            var second = GetSubArray(array, index + 1, array.Length - index - 1);

            Array.Reverse(first);
            Array.Reverse(second);

            return MergeArrayWithInt(first, array[index], second);
        }

        static int[] GetSubArray(int[] source, int startingIndex, int length)
        {
            var newArray = new int[length];
            Array.Copy(source, startingIndex, newArray, 0, length);
            return newArray;
        }


        static int[] MergeArrayWithInt(int[] source1, int indexElement, int[] source2)
        {
            var newArray = new int[source1.Length + source2.Length + 1];
            Array.Copy(source1, 0, newArray, 0, source1.Length);
            newArray[source1.Length] = indexElement;
            Array.Copy(source2, 0, newArray, source1.Length + 1, source2.Length);
            return newArray;
        }

    }
}
