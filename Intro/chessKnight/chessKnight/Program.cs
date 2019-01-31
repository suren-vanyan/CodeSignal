using System;

namespace chessKnight
{
    class Program
    {
        //Given a position of a knight on the standard chessboard, find the number 
        //of different moves the knight can perform.
        //The knight can move to a square that is two squares horizontally and one square vertically,
        //or two squares vertically and one square horizontally away from it.
        //The complete move therefore looks like the letter L.
        //Check out the image below to see all valid moves for a knight piece that is 
        //placed on one of the central squares.
        static void Main(string[] args)
        {
            string cell = "a1";

            Console.WriteLine(chessKnight(cell));

        }

        static int chessKnight(string cell)
        {
            int moveCount = 0;
            if (cell[0] + 2 <= 'h' && char.GetNumericValue(cell.ToString(), 1) + 1 <= 8)
                moveCount++;
            if (cell[0] + 2 <= 'h' && char.GetNumericValue(cell.ToString(), 1) - 1 >= 1)
                moveCount++;
            if (cell[0] + 1 <= 'h' && char.GetNumericValue(cell.ToString(), 1) - 2 >= 1)
                moveCount++;
            if (cell[0] - 1 >= 'a' && char.GetNumericValue(cell.ToString(), 1) - 2 >= 1)
                moveCount++;
            if (cell[0] - 2 >= 'a' && char.GetNumericValue(cell.ToString(), 1) + 1 <= 8)
                moveCount++;
            if (cell[0] - 2 >= 'a' && char.GetNumericValue(cell.ToString(), 1) - 1 >= 1)
                moveCount++;
            if (cell[0] - 1 >= 'a' && char.GetNumericValue(cell.ToString(), 1) + 2 <= 8)
                moveCount++;
            if (cell[0] + 1 <= 'h' && char.GetNumericValue(cell.ToString(), 1) + 2 <= 8)
                moveCount++;

            return moveCount;
        }
    }
}
