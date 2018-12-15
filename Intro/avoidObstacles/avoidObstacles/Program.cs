using System;

namespace CodeSignal
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = { 1, 4, 10, 6, 2 };
            Console.WriteLine(avoidObstacles(inputArray));
        }

        static int avoidObstacles(int[] inputArray)
        {
            int jumpLength = 1;
            bool jumping = false;
            while (!jumping)
            {
                jumping = true;
                ++jumpLength;
                foreach (var item in inputArray)
                {
                    if (item % jumpLength == 0)
                    {
                        jumping = false;
                        continue;
                    }
                }
            }

            return jumpLength;
        }
    }
}
