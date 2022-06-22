using System;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            field.createCells(gameField);
        }

        private string sudokuRules = "1) Each row, column and block must contain the numbers from 1 to 9, without repetitions \n" +
                               "\n2) To start the game you need to choose the difficulty level \n" +
                               "\n3) To clear one cell you can press zero " +"\nin case if you want to clear all field, press Clear All button \n"+
                               "\n4) To check your answers, press a Check button \n" +
                               "Good luck!";
        private int N = 9;
        private BackTrackingSolver solver = new BackTrackingSolver();
        private Field field = new Field();
        private NewGame newGame = new NewGame();
        private DateTime _dateTime;
        Timer timer = new Timer();

        private void startGame_Click(object sender, EventArgs e)
        {
            if (!beginner.Checked && !intermidiate.Checked && !hard.Checked)
            {
                MessageBox.Show("Choose the level");
            }
            else
                newGame.startNewGame(field.Cells, beginner, intermidiate, hard);

            if (beginner.Checked || intermidiate.Checked || hard.Checked)
            {
                _dateTime = DateTime.Now;
                timer.Interval = 10;
                timer.Tick += tickTimer;
                timer.Start();
            }
        }

        private void tickTimer(object sender, EventArgs e)
        {
            long tick = DateTime.Now.Ticks - _dateTime.Ticks;
            DateTime stopWatch = new DateTime();
            stopWatch = stopWatch.AddTicks(tick);
            time.Text = String.Format("{0:HH:mm:ss}", stopWatch);

        }

        private void check_Click(object sender, EventArgs e)
        {
            newGame.Check(field.Cells, time, timer);
        }

        private void rules_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sudokuRules, "Game Rules");
        }


        private void clearBtn_Click(object sender, EventArgs e)
        {
            foreach (var cell in field.Cells)
            {
                if (!cell.IsLocked)
                {
                    cell.Clear();
                }

            }
        }

        private void solveByComp_Click(object sender, EventArgs e)
        {
            int[,] board = solver.convertToMatrix(field.Cells);
            foreach (var cell in field.Cells)
            {
                if (!cell.IsLocked)
                {
                    cell.Clear();
                }

            }
            if (solver.solveSudoku(board, N))
            {
                field.Cells = solver.convertToCells(field.Cells, board);
            }
            timer.Stop();
        }
    }
}