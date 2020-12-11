﻿namespace SnakeTest
{
    partial class GameForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.MovementTimer = new System.Windows.Forms.Timer(this.components);
            this.GamePanel = new System.Windows.Forms.Panel();
            this.SnakeHeadBox = new System.Windows.Forms.PictureBox();
            this.ScoreBox = new System.Windows.Forms.GroupBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.gameBorderBox = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbLeaderboard = new System.Windows.Forms.ListBox();
            this.GamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SnakeHeadBox)).BeginInit();
            this.ScoreBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameBorderBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // MovementTimer
            // 
            this.MovementTimer.Tick += new System.EventHandler(this.TimerTick);
            // 
            // GamePanel
            // 
            this.GamePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GamePanel.BackgroundImage")));
            this.GamePanel.Controls.Add(this.SnakeHeadBox);
            this.GamePanel.Location = new System.Drawing.Point(33, 126);
            this.GamePanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(500, 500);
            this.GamePanel.TabIndex = 0;
            // 
            // SnakeHeadBox
            // 
            this.SnakeHeadBox.BackColor = System.Drawing.Color.Transparent;
            this.SnakeHeadBox.Image = ((System.Drawing.Image)(resources.GetObject("SnakeHeadBox.Image")));
            this.SnakeHeadBox.Location = new System.Drawing.Point(220, 220);
            this.SnakeHeadBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SnakeHeadBox.Name = "SnakeHeadBox";
            this.SnakeHeadBox.Size = new System.Drawing.Size(20, 20);
            this.SnakeHeadBox.TabIndex = 0;
            this.SnakeHeadBox.TabStop = false;
            // 
            // ScoreBox
            // 
            this.ScoreBox.Controls.Add(this.lblScore);
            this.ScoreBox.Controls.Add(this.label1);
            this.ScoreBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ScoreBox.Location = new System.Drawing.Point(626, 126);
            this.ScoreBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ScoreBox.Name = "ScoreBox";
            this.ScoreBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ScoreBox.Size = new System.Drawing.Size(214, 94);
            this.ScoreBox.TabIndex = 2;
            this.ScoreBox.TabStop = false;
            this.ScoreBox.Text = "ScoreBox";
            // 
            // lblScore
            // 
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Location = new System.Drawing.Point(99, 44);
            this.lblScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(89, 35);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "0000000";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(13, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Score - ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnReset
            // 
            this.btnReset.CausesValidation = false;
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(717, 43);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(96, 25);
            this.btnReset.TabIndex = 1;
            this.btnReset.TabStop = false;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // gameBorderBox
            // 
            this.gameBorderBox.Image = ((System.Drawing.Image)(resources.GetObject("gameBorderBox.Image")));
            this.gameBorderBox.Location = new System.Drawing.Point(23, 116);
            this.gameBorderBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gameBorderBox.Name = "gameBorderBox";
            this.gameBorderBox.Size = new System.Drawing.Size(520, 520);
            this.gameBorderBox.TabIndex = 3;
            this.gameBorderBox.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(274, -80);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(340, 190);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // lbLeaderboard
            // 
            this.lbLeaderboard.BackColor = System.Drawing.SystemColors.Control;
            this.lbLeaderboard.FormattingEnabled = true;
            this.lbLeaderboard.ItemHeight = 20;
            this.lbLeaderboard.Location = new System.Drawing.Point(626, 237);
            this.lbLeaderboard.Name = "lbLeaderboard";
            this.lbLeaderboard.Size = new System.Drawing.Size(214, 364);
            this.lbLeaderboard.TabIndex = 6;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 689);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.ScoreBox);
            this.Controls.Add(this.GamePanel);
            this.Controls.Add(this.gameBorderBox);
            this.Controls.Add(this.lbLeaderboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "GameForm";
            this.Text = "Snake Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyHasBeenPressed);
            this.GamePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SnakeHeadBox)).EndInit();
            this.ScoreBox.ResumeLayout(false);
            this.ScoreBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameBorderBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer MovementTimer;
        private System.Windows.Forms.Panel GamePanel;
        private System.Windows.Forms.GroupBox ScoreBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox gameBorderBox;
        private System.Windows.Forms.PictureBox SnakeHeadBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListBox lbLeaderboard;
        private System.Windows.Forms.Label lblScore;
    }
}