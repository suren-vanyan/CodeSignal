using System;

namespace boxBlur
{
    class Program
    {
        //Last night you partied a little too hard.Now there's a black and white photo of you that's
        //about to go viral! You can't let this ruin your reputation,
        //so you want to apply the box blur algorithm to the photo to hide its content.

         //The pixels in the input image are represented as integers.
         //The algorithm distorts the input image in the following way:
         //Every pixel x in the output image has a value equal to the average 
         //value of the pixel values from the 3 × 3 square that has its center at x,
         //including x itself.All the pixels on the border of x are then removed.
        static void Main(string[] args)
        {
            int[][] image = {new int[]{7,4,0,1 },
                             new int[] {5,6,2,2 },
                             new int[] {6,10,7,8 },
                             new int[] {1,4,2,0 }};

            foreach (var item in boxBlur(image))
            {
                Console.WriteLine(item);
            }
        }

        static int[][] boxBlur(int[][] image)
        {


            int b = image[0].Length - 2;
            int[][] boxBlured = new int[image.Length - 2][];
            int boxSum = 0;

            for (int i = 0; i < image.Length - 2; i++)
            {
                boxBlured[i] = new int[b];
                for (int j = 0; j < image[i].Length - 2; j++)
                {

                    for (int x = i; x <= i + 2; x++)
                    {
                        for (int y = j; y <= j + 2; y++)
                        {
                            boxSum += image[x][y];
                        }

                    }

                    boxSum = boxSum / 9;
                    boxBlured[i][j] = boxSum;
                    boxSum = 0;
                }

            }

            return boxBlured;
        }


    }
}
