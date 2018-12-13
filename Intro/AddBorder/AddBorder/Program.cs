using System;

namespace CodeSignal
{
    class Program
    {
        //Given a rectangular matrix of characters, add a border of asterisks(*) to it.
        // Example  picture: ["abc","ded"]

      //  the output should be  addBorder(picture) = ["*****", "*abc*", "*ded*", "*****"]


        static void Main(string[] args)
        {
            string[] arr = new[] { "abcde", "fghij", "klmno", "pqrst", "uvwxy" };
            foreach (var item in addBorder(arr))
            {
                Console.WriteLine(item);
            }
        }

        static string[] addBorder(string[] picture)
        {
            int length = picture.Length + 2;
            string[] newPicture = new string[length];

            for (int i = 0; i < picture.Length; i++)
                newPicture[i + 1] = new string($"*{picture[i]}*");

            newPicture[0] = new string('*', picture[0].Length + 2);
            newPicture[length - 1] = new string('*', picture[0].Length + 2);

            return newPicture;

        }
    }
}
