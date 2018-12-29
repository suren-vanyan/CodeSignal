using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeSignal
{
    //Given two cells on the standard chess board, 
    //determine whether they have the same color or not.
    class Program
    {
        static void Main(string[] args)
        {
            string cell1 = "A2";
            string cell2 = "B6";
            Console.WriteLine(chessBoardCellColor(cell1, cell2));

        }

        static bool chessBoardCellColor(string cell1, string cell2)
        {
            var cell1Number = int.Parse(cell1[1].ToString());
            var cell2Number = int.Parse(cell2[1].ToString());

            char[] LetterGroup1 = { 'A', 'C', 'E', 'G' };
            char[] LetterGroup2 = { 'B', 'D', 'F', 'H' };

            if (LetterGroup1.Contains(cell1[0]) && LetterGroup1.Contains(cell2[0]))
            {
                return cell1Number % 2 == cell2Number % 2;
            }
            else if (LetterGroup2.Contains(cell1[0]) && LetterGroup2.Contains(cell2[0]))
            {
                return cell1Number % 2 == cell2Number % 2;
            }
            else
            {
                return cell1Number % 2 != cell2Number % 2;
            }
        }

    }
}
