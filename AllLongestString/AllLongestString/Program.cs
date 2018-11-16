using System;

class Program
{
    //Given an array of strings, return another array containing all of its longest strings

    public static string[] allLongestStrings(string[] inputArray)
    {
        string max = inputArray[0];
        int length = 0;
        for (int i = 1; i < inputArray.Length; i++)
        {
            if (max.Length < inputArray[i].Length)
            {
                max = inputArray[i];
                length = 0;
            }
            else if (max.Length == inputArray[i].Length)
                length++;
        }

        string[] str = new string[length + 1];
        for (int i = 0, j = -1; i < inputArray.Length; i++)
        {
            if (max.Length == inputArray[i].Length)
            {
                j++;
                str[j] = inputArray[i];


            }
        }

        return str;

    }

    static void Main()
    {
        string[] inputArray = { "aba", "abag", "aa", "ad", "ghtj", "vcd", "aba" };
        foreach (var item in allLongestStrings(inputArray))
        {
            Console.WriteLine(item);
        }
    }
}
