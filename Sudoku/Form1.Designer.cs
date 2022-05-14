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
            this.startGame = new System.Windows.Forms.Button();
            this.check = new System.Windows.Forms.Button();
            this.rules = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.levels.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameField
            // 
            this.gameField.Location = new System.Drawing.Point(60, 113);
            this.gameField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gameField.Name = "gameField";
            this.gameField.Size = new System.Drawing.Size(490, 472);
            this.gameField.TabIndex = 0;
            // 
            // beginner
            // 
            this.beginner.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.beginner.ForeColor = System.Drawing.Color.ForestGreen;
            this.beginner.Location = new System.Drawing.Point(17, 31);
            this.beginner.Name = "beginner";
            this.beginner.Size = new System.Drawing.Size(145, 48);
            this.beginner.TabIndex = 0;
            this.beginner.TabStop = true;
            this.beginner.Text = "Beginner";
            this.beginner.UseVisualStyleBackColor = true;
            // 
            // intermidiate
            // 
            this.intermidiate.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.intermidiate.ForeColor = System.Drawing.Color.DarkOrange;
            this.intermidiate.Location = new System.Drawing.Point(17, 84);
            this.intermidiate.Name = "intermidiate";
            this.intermidiate.Size = new System.Drawing.Size(145, 48);
            this.intermidiate.TabIndex = 1;
            this.intermidiate.TabStop = true;
            this.intermidiate.Text = "Intermidiate";
            this.intermidiate.UseVisualStyleBackColor = true;
            // 
            // hard
            // 
            this.hard.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.hard.ForeColor = System.Drawing.Color.Red;
            this.hard.Location = new System.Drawing.Point(17, 138);
            this.hard.Name = "hard";
            this.hard.Size = new System.Drawing.Size(149, 48);
            this.hard.TabIndex = 2;
            this.hard.TabStop = true;
            this.hard.Text = "Hard";
            this.hard.UseVisualStyleBackColor = true;
            // 
            // levels
            // 
            this.levels.AutoSize = true;
            this.levels.BackColor = System.Drawing.SystemColors.Control;
            this.levels.Controls.Add(this.hard);
            this.levels.Controls.Add(this.intermidiate);
            this.levels.Controls.Add(this.beginner);
            this.levels.ForeColor = System.Drawing.SystemColors.ControlText;
            this.levels.Location = new System.Drawing.Point(556, 243);
            this.levels.Name = "levels";
            this.levels.Size = new System.Drawing.Size(172, 214);
            this.levels.TabIndex = 1;
            this.levels.TabStop = false;
            // 
            // startGame
            // 
            this.startGame.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.startGame.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.startGame.Location = new System.Drawing.Point(556, 57);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(172, 68);
            this.startGame.TabIndex = 2;
            this.startGame.Text = "Start Game!";
            this.startGame.UseVisualStyleBackColor = false;
            this.startGame.Click += new System.EventHandler(this.startGame_Click);
            // 
            // check
            // 
            this.check.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.check.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.check.Location = new System.Drawing.Point(556, 131);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(172, 69);
            this.check.TabIndex = 3;
            this.check.Text = "Check";
            this.check.UseVisualStyleBackColor = false;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // rules
            // 
            this.rules.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rules.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.rules.Location = new System.Drawing.Point(556, 483);
            this.rules.Name = "rules";
            this.rules.Size = new System.Drawing.Size(172, 70);
            this.rules.TabIndex = 4;
            this.rules.Text = "How to play";
            this.rules.UseVisualStyleBackColor = false;
            this.rules.Click += new System.EventHandler(this.rules_Click);
            // 
            // time
            // 
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.time.Location = new System.Drawing.Point(556, 8);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(166, 47);
            this.time.TabIndex = 5;
            this.time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(556, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Choose the level!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 596);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.time);
            this.Controls.Add(this.rules);
            this.Controls.Add(this.check);
            this.Controls.Add(this.startGame);
            this.Controls.Add(this.levels);
            this.Controls.Add(this.gameField);
            this.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Sudoku Game";
            this.levels.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;

        public System.Windows.Forms.Label time;

        private System.Windows.Forms.Button rules;

        private System.Windows.Forms.Button startGame;
        private System.Windows.Forms.Button check;

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