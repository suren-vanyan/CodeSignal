using System;

namespace HomeWork2
{
    class Program
    {
        static void FindIndexer(int[] array,int inputValue)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {

                    if (inputValue == (array[i] + array[j]))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"index {i}__Value{array[i]},index {j}__Value{array[j]}\n"); 
                       
                    }
                }
            }
            Console.WriteLine();
        }
        static void ShowIndexOfArray(int index)
        {

        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] array = new int[20];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 15);
                Console.Write($"{i}={array[i]} ");
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("input some int value=");      
            int inputValue = int.Parse(Console.ReadLine());
            Console.WriteLine();
           
            FindIndexer(array, inputValue);
        }
    }
}
