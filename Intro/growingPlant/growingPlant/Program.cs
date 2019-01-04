using System;

namespace growingPlant
{
    class Program
    {
        // Each day a plant is growing by upSpeed meters.
        //Each night that plant's height decreases by downSpeed 
        //meters due to the lack of sun heat. Initially, plant is 0 meters tall.
        //We plant the seed at the beginning of a day. We want to know when the 
        //height of the plant will reach a certain level.

        static void Main(string[] args)
        {
            int upSpeed = 100; int downSpeed = 10;
            int desiredHeight = 910;
            Console.WriteLine(growingPlant(upSpeed, downSpeed, desiredHeight));
        }

        static int growingPlant(int upSpeed, int downSpeed, int desiredHeight)
        {
            int reachLevel = 0;
            int i = 0;
            while (true)
            {
                reachLevel += upSpeed;
                i++;
                if (reachLevel >= desiredHeight)
                    return i;
                reachLevel -= downSpeed;

            }

        }
    }
}
