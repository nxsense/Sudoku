using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Sudoku
{
    public class NewGame
    {
        private Values _values = new Values();
        public void startNewGame(Cell[,] cells, RadioButton beginner, RadioButton intermediate, RadioButton hard)
        {
            _values.loadValues(cells);
            int hintsCount = 0;
            if (beginner.Checked) hintsCount = 45;
            if (intermediate.Checked) hintsCount = 30;
            if (hard.Checked) hintsCount = 15;
            _values.showRandomValues(hintsCount, cells);
        }
        public List<Cell> WrongCells(Cell[,] cells)
        {
            List<Cell> wrongcells = new List<Cell>();
            foreach (var cell in cells)
            {
                if (!string.Equals(cell.Value.ToString(), cell.Text))
                {
                    wrongcells.Add(cell);
                }
            }
            return wrongcells;
        }
        public void Check(Cell[,] cells, Label label, Timer timer)
        {
            List<Cell> list = WrongCells(cells);
            if (list.Any())
            {
                list.ForEach(cell => cell.ForeColor = Color.Firebrick);
                MessageBox.Show("Oops! Seems that you have to try again", "Wrong inputs");
            }
            else
            {
                MessageBox.Show("Congratulations! \n Your result is: " + label.Text, "Sudoku is completed!");
                timer.Stop();
            }
        }
        
        
    }
}