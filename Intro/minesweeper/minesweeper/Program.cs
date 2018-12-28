using System;

namespace minesweeper
{
    //In the popular Minesweeper game you have a board 
    //with some mines and those cells that don't contain 
    //a mine have a number in it that indicates the total 
    //number of mines in the neighboring cells. 
    //Starting off with some arrangement of mines we
    //want to create a Minesweeper game setup.
    class Program
    {
        static void Main(string[] args)
        {
            bool[][] matrix = {new bool[]{ false,true,false},
                               new bool[] {true,false,true},
                                new bool[]{false,true,false}};

            foreach (var item in minesweeper(matrix))
            {
                foreach (var item2 in item)
                {
                    Console.Write(item2);
                }
                Console.WriteLine();
            }
        }

        static int[][] minesweeper(bool[][] matrix)
        {
            int[][] newMatrix = new int[matrix.Length][];
            for (int i = 0; i < matrix.Length; i++)
            {
                newMatrix[i] = new int[matrix[i].Length];
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    newMatrix[i][j] = GetTotalMines(matrix, i, j);
                }
            }
            return newMatrix;
        }

        static int GetTotalMines(bool[][] matrix,int x,int y)
        {
            int startX = (x - 1 < 0) ? 0 : x - 1;
            int EndX = (x + 1 >= matrix.Length) ? x : x + 1;
            int startY = (y - 1 < 0) ? 0 : y - 1;
            int EndY = (y + 1 >= matrix[x].Length) ? y : y + 1;
            int mines = 0;
            for ( int i=startX ; i<=EndX; i++)
            {
                for (int j = startY; j <= EndY; j++)
                {
                    if (matrix[i][j]&&(x!=i||y!=j))
                    {
                        mines++;
                    }
                }
            }
            return mines;

        }



    }
}
