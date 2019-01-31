using System;

namespace isDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = 'a';
            Console.WriteLine(isDigit(symbol));
        }

        static bool isDigit(char symbol)
        {
           bool result= char.IsDigit(symbol);
            return result;
            //double digit = char.GetNumericValue(symbol);
            //if (digit != -1.0)
            //    return true;
            //return false;
        }
    }
}
