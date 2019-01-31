using System;
using System.Collections.Generic;
using System.Linq;

namespace deleteDigit
{
    class Program
    {
        //Given some integer, find the maximal number you can obtain by deleting exactly
        //one digit of the given number.
        //For n = 152, the output should be
        //deleteDigit(n) = 52; For 222219=>22229
        static void Main(string[] args)
        {
            int n = 10;
            Console.WriteLine(deleteDigit(n));

        }

        static int deleteDigit(int n)
        {
            int m = 0;
            bool everyoneIsEqual = true;
            List<int> list = new List<int>();
            int counter = 0;
            while (n > 0)
            {
                m = n % 10;
                if (counter > 0 && everyoneIsEqual)
                    if (list.Last() != m)
                        everyoneIsEqual = false;
                list.Add(m);
                counter++;
                n /= 10;
            }

            string returnValue = string.Empty;
            if (everyoneIsEqual)
            {
                list.Remove(m);
                list.ForEach(x => returnValue += x.ToString());
                return int.Parse(returnValue);
            }

            list.Reverse();
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] < list[i + 1])
                {
                    list.Remove(list[i]);
                    break;
                }
                else if (i == list.Count - 2)
                    list.Remove(list[i + 1]);


            }
            list.ForEach(x => returnValue += x.ToString());

            return int.Parse(returnValue);

        }

    }
}
