using System;
using System.Collections.Generic;
using System.Linq;

namespace isBeautifulString
{
     // A string is said to be beautiful if b occurs in it 
    //no more times than a; c occurs in it no more times than b; etc.
    //Given a string, check whether it is beautiful.
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = "aabbb";
            Console.WriteLine(isBeautifulString(inputString));
        }

        static bool isBeautifulString(string inputString)
        {

            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            List<int> occurs = new List<int>();
            int temp = 0;
            foreach (var item in alphabet)
            {
                temp = inputString.Count(i => i == item);
                occurs.Add(temp);
            }

            List<int> occursByDecending = new List<int>();
            occursByDecending = occurs.OrderByDescending(i => i).ToList();
            for (int i = 0; i < occurs.Count; i++)
            {
                if (occurs[i] != occursByDecending[i])
                    return false;
            }

            return true;

        }
    }
}
