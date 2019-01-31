using System;

namespace lineEncoding
{
    class Program
    {
        //Given a string, return its encoding defined as follows:
        // First, the string is divided into the least possible number 
        //of disjoint substrings consisting of identical characters
        //for example, "aabbbc" is divided into["aa", "bbb", "c"]
        //Next, each substring with length greater than one is replaced with a 
        //concatenation of its length and the repeating character
        //for example, substring "bbb" is replaced by "3b"
        //Finally, all the new strings are concatenated together in the same order and a new string is returned
        static void Main(string[] args)
        {
            string s = "ssiiggkooo";
            Console.WriteLine(lineEncoding(s));
        }

        static string lineEncoding(string s)
        {
           

            char temp = s[0];
            string result = string.Empty;
            int counter = 1;
            for (int i = 1; i < s.Length; i++)
            {
                if (temp == s[i])
                    counter++;
                else
                {
                    if (counter > 1)
                        result += counter.ToString() + temp;
                    else
                        result += temp;
                    counter = 1;
                    temp = s[i];
                }
            }

            if (counter > 1) result += counter.ToString() + temp;
            else result += temp;
            return result;

        }
    }
}
