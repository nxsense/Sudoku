using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Sudoku
{
    public class NewGame
    {
        private Values _values = new Values();
        private BackTrackingSolver solver = new BackTrackingSolver();

        public void startNewGame(Cell[,] cells, RadioButton beginner, RadioButton intermediate, RadioButton hard)
        {
            _values.loadValues(cells);
            int hintsCount = 0;
            if (beginner.Checked) hintsCount = 45;
            if (intermediate.Checked) hintsCount = 35;
            if (hard.Checked) hintsCount = 25;
            _values.showRandomValues(hintsCount, cells);
            int[,] board = solver.convertToMatrix(cells);
            if (!solver.solveSudoku(board, 9)) _values.showRandomValues(hintsCount, cells);
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
            int count = 0;
            List<Cell> list = WrongCells(cells);
            if (list.Any())
            {
                list.ForEach(cell => cell.ForeColor = Color.Firebrick);
                foreach (var cell in cells)
                {
                    if (cell.Text != "") count++;
                }

                if (count != 81)
                {
                    MessageBox.Show("Fill the field and try again!", "Fill cells");
                }
                else
                {
                    MessageBox.Show("Oops! Seems that you have to try again", "Wrong inputs");
                }
            }
            else
            {
                MessageBox.Show("Congratulations! \n Your result is: " + label.Text, "Sudoku is completed!");
                timer.Stop();
            }
        }
        
        
    }
}