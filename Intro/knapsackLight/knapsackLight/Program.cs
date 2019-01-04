using System;

namespace knapsackLight
{
    //You found two items in a treasure chest! 
    //The first item weighs weight1 and is worth value1, 
    //and the second item weighs weight2 and is worth value2.
    //What is the total maximum value of the items you can take with you,
    //assuming that your max weight capacity is maxW and you can't come back for the items later?

    class Program
    {
        static void Main(string[] args)
        {
            int value1 = 10, weight1 = 5, value2 = 6, weight2 = 4, maxW = 8;
            Console.WriteLine(knapsackLight(value1, weight1, value2, weight2, maxW));
        }

        static int knapsackLight(int value1, int weight1, int value2, int weight2, int maxW)
        {
            if (weight1 > maxW && weight2 > maxW)
                return 0;
            return weight1 + weight2 <= maxW ? value1 + value2 : value1 < value2 && weight2 <= maxW ? value2 : maxW >= weight1 ? value1 : 0;
        }
    }
}
