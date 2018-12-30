using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeSignal
{
    //You have deposited a specific amount of money into your bank account.
    //Each year your balance increases at the same growth rate.
    //With the assumption that you don't make any additional deposits, 
    //find out how long it would take for your balance to pass a specific threshold. 
    //Of course you don't want to wait too long, so you know that the answer is not greater than 6.
    class Program
    {
        static void Main(string[] args)
        {
            int deposit = 100;
            int rate = 1;
            int threshold = 101;
            Console.WriteLine(depositProfit(deposit, rate, threshold));

        }
        static int depositProfit(int deposit, int rate, int threshold)
        {
            int year;
            double depositD = deposit;
            for (year = 0; depositD < threshold; year++)
            {
                depositD += depositD * rate / 100;
            }

            return year;
        }
    }
}

