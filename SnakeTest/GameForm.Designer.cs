namespace SnakeTest
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
            this.lblScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.lbLeaderboard = new System.Windows.Forms.ListBox();
            this.GameBackground = new System.Windows.Forms.PictureBox();
            this.GamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SnakeHeadBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameBackground)).BeginInit();
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
            this.GamePanel.Location = new System.Drawing.Point(56, 155);
            this.GamePanel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(500, 500);
            this.GamePanel.TabIndex = 0;
            // 
            // SnakeHeadBox
            // 
            this.SnakeHeadBox.BackColor = System.Drawing.Color.Transparent;
            this.SnakeHeadBox.Image = ((System.Drawing.Image)(resources.GetObject("SnakeHeadBox.Image")));
            this.SnakeHeadBox.Location = new System.Drawing.Point(200, 260);
            this.SnakeHeadBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.SnakeHeadBox.Name = "SnakeHeadBox";
            this.SnakeHeadBox.Size = new System.Drawing.Size(20, 20);
            this.SnakeHeadBox.TabIndex = 0;
            this.SnakeHeadBox.TabStop = false;
            // 
            // lblScore
            // 
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblScore.Location = new System.Drawing.Point(736, 191);
            this.lblScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(107, 26);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "0000000";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(639, 191);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Score - ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnReset
            // 
            this.btnReset.CausesValidation = false;
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(674, 34);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(84, 19);
            this.btnReset.TabIndex = 1;
            this.btnReset.TabStop = false;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // lbLeaderboard
            // 
            this.lbLeaderboard.BackColor = System.Drawing.SystemColors.Control;
            this.lbLeaderboard.FormattingEnabled = true;
            this.lbLeaderboard.ItemHeight = 15;
            this.lbLeaderboard.Location = new System.Drawing.Point(629, 276);
            this.lbLeaderboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbLeaderboard.Name = "lbLeaderboard";
            this.lbLeaderboard.Size = new System.Drawing.Size(220, 379);
            this.lbLeaderboard.TabIndex = 6;
            // 
            // GameBackground
            // 
            this.GameBackground.Image = ((System.Drawing.Image)(resources.GetObject("GameBackground.Image")));
            this.GameBackground.Location = new System.Drawing.Point(0, 0);
            this.GameBackground.Name = "GameBackground";
            this.GameBackground.Size = new System.Drawing.Size(900, 700);
            this.GameBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GameBackground.TabIndex = 7;
            this.GameBackground.TabStop = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 693);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GamePanel);
            this.Controls.Add(this.lbLeaderboard);
            this.Controls.Add(this.GameBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "GameForm";
            this.Text = "Snake Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyHasBeenPressed);
            this.GamePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SnakeHeadBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer MovementTimer;
        private System.Windows.Forms.Panel GamePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox SnakeHeadBox;
        private System.Windows.Forms.ListBox lbLeaderboard;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox GameBackground;
    }
}