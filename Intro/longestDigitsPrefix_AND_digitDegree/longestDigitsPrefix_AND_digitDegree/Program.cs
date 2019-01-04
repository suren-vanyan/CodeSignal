using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace longestDigitsPrefix_AND_digitDegree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 91;
            Console.WriteLine(digitDegree(n));

            string inputString = "12abc34";
            Console.WriteLine(longestDigitsPrefix(inputString));
        }

        static int digitDegree(int n)
        {
            string temp = n.ToString();
            int i = 0;
            while (n > 9)
            {
                i++;
                n = temp.Select(o => (int)char.GetNumericValue(o)).Sum();
                temp = n.ToString();
            }

            return i;
        }


        static string longestDigitsPrefix(string inputString)
        {
            Match regex = Regex.Match(inputString, @"^(\d)+");
            return regex.ToString();

        }
    }
}
