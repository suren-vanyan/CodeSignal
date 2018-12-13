using System;

namespace AreSimilar
{
    class Program
    {
       //Two arrays are called similar if one can be obtained from another by swapping at most one pair of elements in one of the arrays.
       //Given two arrays a and b, check whether they are similar.
        static void Main(string[] args)
        {
            int[] a = new int[] { 1, 2, 3, 5 };
            int[] b = new int[] { 1, 3, 2, 4 };
            Console.WriteLine(areSimilar(a, b));
        }

        static bool areSimilar(int[] a, int[] b)
        {
            int count = 0;
            int index1 = 0, index2 = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                {
                    count++;
                    if (count == 1)
                        index1 = i;
                    else if (count == 2)
                        index2 = i;
                    if (count > 2)
                        return false;
                }
            }

            if (count == 0)
                return true;
            else if (count == 2)
            {
                if (a[index1] == b[index2] && a[index2] == b[index1])
                    return true;
            }

            return false;
        }

    }
}
