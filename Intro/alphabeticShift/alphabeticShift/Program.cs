using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeSignal
{
    //Given a string, replace each its character by the next one in the English alphabet(z would be replaced by a).
    class Program
    {
        static void Main(string[] args)
        {

            string inputString = "aaaab}bbccd";
            Console.WriteLine(alphabeticShift(inputString));

        }

        static string alphabeticShift(string inputString)
        {
            string pattern = @"[a-z]";
            string temp = string.Empty;

            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == 'z')
                    temp += inputString[i];
                else if (Regex.Match(inputString[i].ToString(), pattern).Success)

                    temp += Convert.ToChar(inputString[i] + 1);

            }
            return temp;
        }


    }
}
