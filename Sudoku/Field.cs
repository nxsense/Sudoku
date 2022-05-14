using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sudoku
{
    public class Field
    {
        private Cell[,] cells = new Cell[9, 9];

        public Cell[,] Cells
        {
            get => cells;
            set => cells = value;
        }

        public void createCells(Panel gameField)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    //creating cells w styles and so on
                    cells[i,j] = new Cell();
                    cells[i, j].Font = new Font("Britannic Bold", 20);
                    cells[i, j].Size = new Size(40, 40);
                    cells[i, j].ForeColor = SystemColors.ControlDarkDark;
                    cells[i, j].Location = new Point(i * 40, j * 40);
                    cells[i, j].BackColor = ((i / 3) + (j / 3)) % 2 == 0 ? SystemColors.Control : Color.LightGray;
                    cells[i, j].FlatStyle = FlatStyle.Flat;
                    cells[i, j].FlatAppearance.BorderColor = Color.Black;
                    cells[i, j].X = i;
                    cells[i, j].Y = j;
                    cells[i, j].KeyPress += cell_keyPressed;
                    cells[i, j].Click += cell_buttonClick;
                    gameField.Controls.Add(cells[i, j]); 
                }
            }
        }
        private void cell_keyPressed(object sender, KeyPressEventArgs e)
        {
            var cell = sender as Cell;
            
            //if cell is locked do nothing
            if(cell.IsLocked) return;
            int value;
            
            //Adding the key pressed value in the cell ONLY if its a number
            if (int.TryParse(e.KeyChar.ToString(), out value))
            {
                //
                if (value == 0)
                    cell.Clear();
                else
                    cell.Text = value.ToString();

                cell.ForeColor = SystemColors.ControlDarkDark;

            }
            if(char.IsWhiteSpace(e.KeyChar)) cell.Clear();
        }
        private void cell_buttonClick(object sender, EventArgs e)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    cells[i, j].BackColor = ((i / 3) + (j / 3)) % 2 == 0 ? SystemColors.Control : Color.LightGray;
                }
            }
            var cell = sender as Cell;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (cells[i, j].Text == cell.Text && cells[i, j].Text != "")
                    {
                        cells[i, j].BackColor = Color.LightSkyBlue;
                    }
                }
            }
        }

    }
}