using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Sudoku
{
    public class NewGame
    {
        private Values _values = new Values();

        public void startNewGame(Cell[,] cells, RadioButton beginner, RadioButton intermidiate, RadioButton hard)
        {
            _values.loadValues(cells);
            
        }
    }
}