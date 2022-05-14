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
            newGame.startNewGame(field.Cells, beginner, intermidiate, hard);
        }

        private Field field = new Field();
        private NewGame newGame = new NewGame();
        private DateTime _dateTime;
        Timer timer = new Timer();

        private void startGame_Click(object sender, EventArgs e)
        {
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
            MessageBox.Show("rules", "rules");
        }

        // private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        // {
        //     const string message =
        //         "Are you sure that you want to exit?";
        //     const string caption = "Exit";
        //     var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo);
        //     if (result == DialogResult.Yes)
        //     {
        //        Application.Exit();
        //     }
        // }
        
    }
}