using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeSignal
{
    //Correct variable names consist only of English letters,
    //digits and underscores and they can't start with a digit.
    //Check if the given string is a correct variable name.
    class Program
    {
        static void Main(string[] args)
        {

            string name = "var_1__Int";
            name = Console.ReadLine();
            Console.WriteLine(variableName(name));

        }

        static bool variableName(string name)
        {

            string pattern = @"^\d";
            var regex = Regex.Match(name, pattern);
            if (regex.Success)
                return false;
            else
                return name.All(c => (char.IsLetterOrDigit(c)) || c == '_');
        }

    }
}
