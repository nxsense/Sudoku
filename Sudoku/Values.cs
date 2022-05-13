using System;
using System.Collections.Generic;
using System.Drawing;

namespace Sudoku
{
    public class Values
    {
        
        public void showRandomValues(int hintsCount, Cell[,] cells)
        {
            for (int i = 0; i < hintsCount; i++)
            {
                var rX = random.Next(9);
                var rY = random.Next(9);

                cells[rX, rY].Text = cells[rX, rY].Value.ToString();
                cells[rX, rY].ForeColor = Color.Black;
                cells[rX, rY].IsLocked = true;

            }
        }
        public void loadValues(Cell[,] cells)
        {
            foreach (var cell in cells)
            {
                cell.Value = 0;
                cell.Clear();
            }

            findNextSellValue(0, -1, cells);
        }
        
        private Random random = new Random();
        public bool findNextSellValue(int i, int j, Cell[,]cells)
        {
            if (++j > 8)
            {
                j = 0;
                if (++i > 8) return true;
            }

            var value = 0;
            var numsLeft = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9};

            do
            {
                if (numsLeft.Count < 1)
                {
                    cells[i, j].Value = 0;
                    return false;
                }

                value = numsLeft[random.Next(0, numsLeft.Count)];
                cells[i, j].Value = value;
                numsLeft.Remove(value);
            } while (!isValueValid(value, i, j, cells) || !findNextSellValue(i, j, cells));

            return true;
        }
        public bool isValueValid(int value, int x, int y, Cell[,] cells)
        {
            bool flag = checkVertical(value, x, y, cells);
            flag = checkHorizontal(value, x, y, cells);
            flag = checkBlock(value, x, y, cells);
            return flag;
        }
        public bool checkVertical(int value, int x, int y, Cell[,] cells)
        {
            bool flag = true;
            for (int i = 0; i < 9; i++)
                if (i != y && cells[x, i].Value == value) flag = false;
            return flag;
        }
        public bool checkHorizontal(int value, int x, int y, Cell[,] cells)
        {
            bool flag = true;
            for (int i = 0; i < 9; i++)
                if (i != x && cells[y, i].Value == value) flag = false;
            return flag;
        }
        public bool checkBlock(int value, int x, int y, Cell[,] cells)
        {
            bool flag = true;
            for (int i = x - (x % 3); i < x - (x % 3) + 3; i++)
            {
                for (int j = y - (y % 3); j < y - (y % 3) + 3; j++)
                {
                    if (i != x && j != y && cells[i, j].Value == value)
                     flag = false;
                }
            }
            return flag;
            
        }
        
    }
}