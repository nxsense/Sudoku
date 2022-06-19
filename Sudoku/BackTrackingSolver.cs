using System;

namespace Sudoku
{
    public class BackTrackingSolver
    {
        private int N = 9;
        
        public bool solveSudoku(int[,] board, int n)
        {
            int row = -1;
            int col = -1;
            bool isEmpty = true;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (board[i, j] == 0)
                    {
                        row = i;
                        col = j;
                        
                        isEmpty = false;
                        break;
                    }
                }
                if (!isEmpty)
                {
                    break;
                }
            }
            
            if (isEmpty)
            {
                return true;
            }
            
            for (int num = 1; num <= n; num++)
            {
                if (isSafe(board, row, col, num))
                {
                    board[row, col] = num;
                    if (solveSudoku(board, n))
                    {
                        return true;
                    }
                    else
                    {
                        board[row, col] = 0;
                    }
                }
            }
            return false;
        }

        public bool isSafe(int[,] board, int row, int col, int num)
        {
            for (int d = 0; d < board.GetLength(0); d++)
            {
                if (board[row, d] == num)
                {
                    return false;
                }
            }
            
            for (int r = 0; r < board.GetLength(0); r++)
            {
                if (board[r, col] == num)
                {
                    return false;
                }
            }
            
            int sqrt = (int)Math.Sqrt(board.GetLength(0));
            int boxRowStart = row - row % sqrt;
            int boxColStart = col - col % sqrt;
 
            for (int r = boxRowStart;
                 r < boxRowStart + sqrt; r++)
            {
                for (int d = boxColStart;
                     d < boxColStart + sqrt; d++)
                {
                    if (board[r, d] == num)
                    {
                        return false;
                    }
                }
            }
            return true; 
        }
        public int[,] convertToMatrix(Cell[,] cells)
        {
            int[,] board = new int[N,N];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (cells[i, j].Text != "")
                    {
                        board[i, j] = Convert.ToInt32(cells[i, j].Text);
                    }
                    else board[i, j] = 0;
                }
            }
            return board;
        }

        public Cell[,] convertToCells(Cell[,] cells, int[,] board)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    cells[i, j].Value = board[i, j];
                    cells[i, j].Text = Convert.ToString(board[i, j]);
                }
            }
            return cells;
        }

        
    }
}