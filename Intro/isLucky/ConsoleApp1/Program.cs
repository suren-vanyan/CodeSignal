using System;

namespace ConsoleApp1
{
    //Ticket numbers usually consist of an even number of digits.A ticket number is considered 
   //lucky if the sum of the first half of the digits is equal to the sum of the second half.
  //Given a ticket number n, determine if it's lucky or not.
    class Program
    {
        static bool isLucky(int n)
        {
            int m = n, counter = 0, k = 0;
            while (m > 0)
            {
                k += m % 10;
                m = m / 10;
                counter++;
                if (m == 0)
                {
                    counter = counter / 2;
                    while (counter > 0)
                    {
                        counter--;
                        m += n % 10;
                        n = n / 10;
                    }
                    if ((k - m) == m)
                        return true;
                }
            }
            return false;
        }

        static void Main(string[] args)
        {
            int x = 12300235;
            Console.WriteLine(isLucky(x));
        }
    }
}
