using System;

namespace CodeSignal
{
   //You are given an array of integers representing coordinates of obstacles situated on a straight line.
   
   //Assume that you are jumping from the point with coordinate 0 to the right.You are allowed only to make jumps of the same length represented by some integer.
   
   //Find the minimal length of the jump enough to avoid all the obstacles
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
