using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Sudoku
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gameField = new System.Windows.Forms.Panel();
            this.beginner = new System.Windows.Forms.RadioButton();
            this.intermidiate = new System.Windows.Forms.RadioButton();
            this.hard = new System.Windows.Forms.RadioButton();
            this.levels = new System.Windows.Forms.GroupBox();
            this.levels.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameField
            // 
            this.gameField.Location = new System.Drawing.Point(68, 61);
            this.gameField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gameField.Name = "gameField";
            this.gameField.Size = new System.Drawing.Size(560, 504);
            this.gameField.TabIndex = 0;
            // 
            // beginner
            // 
            this.beginner.Location = new System.Drawing.Point(6, 40);
            this.beginner.Name = "beginner";
            this.beginner.Size = new System.Drawing.Size(187, 51);
            this.beginner.TabIndex = 0;
            this.beginner.TabStop = true;
            this.beginner.Text = "Beginner";
            this.beginner.UseVisualStyleBackColor = true;
            // 
            // intermidiate
            // 
            this.intermidiate.Location = new System.Drawing.Point(6, 97);
            this.intermidiate.Name = "intermidiate";
            this.intermidiate.Size = new System.Drawing.Size(187, 51);
            this.intermidiate.TabIndex = 1;
            this.intermidiate.TabStop = true;
            this.intermidiate.Text = "Intermidiate";
            this.intermidiate.UseVisualStyleBackColor = true;
            // 
            // hard
            // 
            this.hard.Location = new System.Drawing.Point(6, 152);
            this.hard.Name = "hard";
            this.hard.Size = new System.Drawing.Size(187, 51);
            this.hard.TabIndex = 2;
            this.hard.TabStop = true;
            this.hard.Text = "Hard";
            this.hard.UseVisualStyleBackColor = true;
            // 
            // levels
            // 
            this.levels.BackColor = System.Drawing.SystemColors.Control;
            this.levels.Controls.Add(this.hard);
            this.levels.Controls.Add(this.intermidiate);
            this.levels.Controls.Add(this.beginner);
            this.levels.ForeColor = System.Drawing.SystemColors.ControlText;
            this.levels.Location = new System.Drawing.Point(634, 339);
            this.levels.Name = "levels";
            this.levels.Size = new System.Drawing.Size(194, 226);
            this.levels.TabIndex = 1;
            this.levels.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 636);
            this.Controls.Add(this.levels);
            this.Controls.Add(this.gameField);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Sudoku Game";
            this.levels.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        public System.Windows.Forms.GroupBox levels;
        public System.Windows.Forms.RadioButton beginner;
        public System.Windows.Forms.RadioButton intermidiate;
        public System.Windows.Forms.RadioButton hard;


        public System.Windows.Forms.Panel gameField;
        
        #endregion
        public Panel GameField => gameField;
        public GroupBox Levels => levels;
        

    }
}