using System;
using System.Collections.Generic;
using System.Linq;

namespace StringRearrangement
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] inputArray = { "zzzzab", "zzzzbb", "zzzzaa" };          
            Console.WriteLine(stringsRearrangement(inputArray));
        }

        static bool stringsRearrangement(string[] inputArray)
        {
            List<string> array = new List<string>();
            foreach (var item in inputArray) array.Add(item);

            Transposition(new List<string>(), array);
            foreach (var item in resultTransposition)
            {
                bool result = checkString(item);
                //if (temp != 1) return false;
            }
            return true;
        }

        static bool checkString(List<string> arr)
        {
            for (int i = 0; i < arr.Count - 1; i++)
            {
                int count = 0;
                string a = arr[i];
                string b = arr[i + 1];
                for (int j = 0; j < arr[0].Length; j++)
                {
                    if (a[j]!=b[j])
                        count++;
                }
                if (count != 1)
                    return false;
            }

            return true;
        }
        static List<List<string>> resultTransposition = new List<List<string>>();
        static void Transposition(List<string> newArr, List<string> oldArr)
        {
            if (oldArr.Count == 0)
            {
                resultTransposition.Add(newArr);
                return;
            }
            foreach (var item in oldArr)
            {
                List<string> newList = new List<string>(newArr);
                List<string> oldList = new List<string>(oldArr);
                newList.Add(item);
                oldList.Remove(item);
                Transposition(newList, oldList);
            }
        }

    }
}