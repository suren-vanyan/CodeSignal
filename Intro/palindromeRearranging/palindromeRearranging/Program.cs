using System;
using System.Linq;

namespace palindromeRearranging
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "abbcabb";
            Console.WriteLine(str.Distinct().Any(c => str.Count(x => x == c) % 2 != 0));
            Console.WriteLine(palindromeRearranging(str));
        }

        static bool palindromeRearranging(string inputString)
        {
            if (inputString.Length % 2 == 0 && inputString.Distinct().Any(c => inputString.Count(x => x == c) % 2 != 0))
                return false;
            if (inputString.Length % 2 == 1)
            {
                int count = 0;
                foreach (var c in inputString.Distinct())
                {
                    if (inputString.Count(x => x == c) % 2 != 0)
                        count++;
                    if (count > 1)
                        return false;
                }
            }
            return true;
        }

    }
}
