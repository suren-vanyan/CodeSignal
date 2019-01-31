using System;

namespace chessKnight
{
    class Program
    {
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
