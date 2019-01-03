using System;

namespace firstDigit
{
    class Program
    {
        //Find the leftmost digit that occurs in a given string.
        static void Main(string[] args)
        {
            string inputString = "var_1__Int";
            Console.WriteLine(firstDigit(inputString));
        }

        static char firstDigit(string inputString)
        {
            var isDigit = false;
            foreach (char s in inputString)
            {

                isDigit = int.TryParse(s.ToString(), out int digit);

                if (isDigit)
                    return s;
            }
            return default(char);
        }

    }
}
