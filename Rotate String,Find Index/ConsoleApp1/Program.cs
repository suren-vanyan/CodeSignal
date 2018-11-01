using System;

namespace ConsoleApp1
{
    class Program
    {
        static string Rotate(string inputstring, int index)
        {

            string firstString = inputstring.Substring(index + 1);
            string secondString = inputstring.Substring(0, index);


            char[] firstChar = secondString.ToCharArray();
            char[] secondChar = firstString.ToCharArray();
            char[] inputArray = inputstring.ToCharArray();
            Array.Reverse(firstChar);
            Array.Reverse(secondChar);

            var first = new string(firstChar);
            var secnd = new string(secondChar);
            var result = first + inputArray[index].ToString() + secnd;
            return result;

          // return new string( MergeArrayWithInt(firstChar, inputArray[index], secondChar));
         
        }


        static char[] MergeArrayWithInt(char[] source1, char indexElement, char [] source2)
        {
            var newString = new char[source1.Length + source2.Length + 1];
            Array.Copy(source1, 0, newString, 0, source1.Length);
            newString[source1.Length] = indexElement;
            Array.Copy(source2, 0, newString, source1.Length + 1, source2.Length);
            return newString;
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();
            string inputString = Console.ReadLine();//"ABCDEFJHIGKLMNOP";
            int index = rnd.Next(2, 6);
            Console.WriteLine($"index={index}");
      
            Console.WriteLine(Rotate(inputString, index));
        }
    }
}
