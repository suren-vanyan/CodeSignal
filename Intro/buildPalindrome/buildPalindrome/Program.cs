using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buildPalindrome
{
    //Given a string, find the
    //shortest possible string which
    //can be achieved by adding characters
    //to the end of initial string to make it a palindrome.

    class Program
    {
        static void Main(string[] args)
        {
            string str = "abcdc";

            Console.WriteLine(buildPalindrome(str));

        }

        static string buildPalindrome(string st)
        {
            string strReverse = string.Join("", st.Reverse());
            if (strReverse == st)
                return st;

            int index = 0;
            string temp = string.Empty;
            for (int i = 0; i < strReverse.Length; i++)
            {
                temp += strReverse[i].ToString();
                if (!st.Contains(temp))
                {
                    index = i;
                    break;
                }
            }

            temp = strReverse.Substring(index, st.Length - index);

            return st += temp;
        }

    }
}
