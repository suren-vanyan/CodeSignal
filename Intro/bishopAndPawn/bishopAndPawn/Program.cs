using System;

namespace bishopAndPawn
{
    //Given the positions of a white bishop and a black pawn on the standard chess board,
    //determine whether the bishop can capture the pawn in one move.
    //The bishop has no restrictions in distance for each move, 
    //but is limited to diagonal movement. Check out the example below to see how it can move:

    class Program
    {
        static void Main(string[] args)
        {
            string bishop = "a5"; string pawn = "c3";
            Console.WriteLine(bishopAndPawn(bishop, pawn));
        }

        static bool bishopAndPawn(string bishop, string pawn)
        {

            double subFirstCoord = bishop[0] > pawn[0] ? bishop[0] - pawn[0] : pawn[0] - bishop[0];
            double subSecondCoord = char.GetNumericValue(bishop[1]) - char.GetNumericValue(pawn[1]);
            if (subSecondCoord < 0)
                subSecondCoord *= -1;
            if (subFirstCoord == subSecondCoord)
                return true;
            return false;

        }
    }
}
