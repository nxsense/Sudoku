﻿using System.Windows.Forms;

namespace Sudoku
{
    public class Cell:Button
    {
        public int X { get; set; }

        public int Y { get; set; }

        public bool IsLocked { get; set; }

        public int Value { get; set; }

        public void Clear()
        {
            this.Text = string.Empty;
            this.IsLocked = false;
        }
    }
}