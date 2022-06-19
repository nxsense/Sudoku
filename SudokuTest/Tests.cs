using System;
using NUnit.Framework;
using Sudoku;
using System.Windows.Forms;

namespace SudokuTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestSolver()
        {
            int[,] board =
            {
                {9, 5, 8, 3, 0, 0, 0, 0, 0},
                {0, 0, 7, 0, 0, 8, 1, 9, 0},
                {0, 0, 0, 0, 0, 0, 8, 0, 0},
                {0, 6, 0, 0, 0, 7, 0, 0, 0},
                {0, 1, 0, 6, 0, 9, 5, 0, 7},
                {0, 0, 0, 4, 0, 5, 0, 0, 0},
                {5, 0, 9, 8, 7, 2, 4, 0, 0},
                {0, 8, 6, 0, 0, 3, 0, 5, 2},
                {0, 0, 0, 5, 0, 0, 3, 8, 0}
            };
            int N = 9;
            BackTrackingSolver solver = new BackTrackingSolver();
            bool flag = solver.solveSudoku(board, N);
            Assert.AreEqual(true, flag);
        }

        [Test]
        public void TestIsSafe()
        {
            int[,] board =  {
                {9, 5, 8, 3, 0, 0, 0, 0, 0},
                {0, 0, 7, 0, 0, 8, 1, 9, 0},
                {0, 0, 0, 0, 0, 0, 8, 0, 0},
                {0, 6, 0, 0, 0, 7, 0, 0, 0},
                {0, 1, 0, 6, 0, 9, 5, 0, 7},
                {0, 0, 0, 4, 0, 5, 0, 0, 0},
                {5, 0, 9, 8, 7, 2, 4, 0, 0},
                {0, 8, 6, 0, 0, 3, 0, 5, 2},
                {0, 0, 0, 5, 0, 0, 3, 8, 0}
            };
            BackTrackingSolver solver = new BackTrackingSolver();
            bool flag = solver.isSafe(board, 0, 4, 1);
            Assert.AreEqual(true, flag);
        }
        
        [Test]
        public void TestIsSafeFalse()
        {
            int[,] board =  {
                {9, 5, 8, 3, 0, 0, 0, 0, 0},
                {0, 0, 7, 0, 0, 8, 1, 9, 0},
                {0, 0, 0, 0, 0, 0, 8, 0, 0},
                {0, 6, 0, 0, 0, 7, 0, 0, 0},
                {0, 1, 0, 6, 0, 9, 5, 0, 7},
                {0, 0, 0, 4, 0, 5, 0, 0, 0},
                {5, 0, 9, 8, 7, 2, 4, 0, 0},
                {0, 8, 6, 0, 0, 3, 0, 5, 2},
                {0, 0, 0, 5, 0, 0, 3, 8, 0}
            };
            BackTrackingSolver solver = new BackTrackingSolver();
            bool flag = solver.isSafe(board, 0, 4, 3);
            Assert.AreEqual(false, flag);
        }

        [Test]
        public void convertToMatrixTest()
        {
            Field field = new Field();
            field.createCells(new Panel());
            Values values = new Values();
            values.loadValues(field.Cells);
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    field.Cells[i, j].Text = Convert.ToString(field.Cells[i, j].Value);
                }
            }
            BackTrackingSolver solver = new BackTrackingSolver();
            int[,] board = solver.convertToMatrix(field.Cells);
            Assert.AreEqual(Convert.ToInt32(field.Cells[3, 5].Value), board[3, 5]);
        }
    }
    
    
}