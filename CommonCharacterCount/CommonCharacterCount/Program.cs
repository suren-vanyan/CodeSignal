using System;
using System.Collections.Generic;

namespace CommonCharacterCount
{
    class Program
    {
       public static int commonCharacterCount(string s1, string s2)
        {
           
            int count = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s2.Contains(s1[i]))
                {
                    int deletionIndex = s2.IndexOf(s1[i]);
                   s2= s2.Remove(deletionIndex,1);
                    count++;
                    
                }
                
            }
       

            return count;
        }

        // Given two strings, find the number of common characters between them.
        static void Main(string[] args)
        {
            string s1 = "aabcc";
            string s2 = "adcaa";
            Console.WriteLine(commonCharacterCount(s1,s2));
        }
    }
}
