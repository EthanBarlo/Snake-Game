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
            this.lblScoreText = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.GameBackground = new System.Windows.Forms.PictureBox();
            this.lblLeaderboard = new System.Windows.Forms.Label();
            this.lblPlace1 = new System.Windows.Forms.Label();
            this.lblPlace2 = new System.Windows.Forms.Label();
            this.lblPlace3 = new System.Windows.Forms.Label();
            this.lblPlace4 = new System.Windows.Forms.Label();
            this.lblPlace5 = new System.Windows.Forms.Label();
            this.lblPlace6 = new System.Windows.Forms.Label();
            this.lblPlace7 = new System.Windows.Forms.Label();
            this.lblPlace8 = new System.Windows.Forms.Label();
            this.lblYouBottom = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.GamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SnakeHeadBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.lblScore.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(135)))), ((int)(((byte)(88)))));
            this.lblScore.Location = new System.Drawing.Point(629, 201);
            this.lblScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(220, 57);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "000000";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScoreText
            // 
            this.lblScoreText.BackColor = System.Drawing.Color.Transparent;
            this.lblScoreText.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblScoreText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(135)))), ((int)(((byte)(88)))));
            this.lblScoreText.Image = ((System.Drawing.Image)(resources.GetObject("lblScoreText.Image")));
            this.lblScoreText.Location = new System.Drawing.Point(674, 155);
            this.lblScoreText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScoreText.Name = "lblScoreText";
            this.lblScoreText.Size = new System.Drawing.Size(127, 46);
            this.lblScoreText.TabIndex = 0;
            this.lblScoreText.Text = "Score";
            this.lblScoreText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // lblLeaderboard
            // 
            this.lblLeaderboard.BackColor = System.Drawing.Color.Transparent;
            this.lblLeaderboard.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLeaderboard.Image = ((System.Drawing.Image)(resources.GetObject("lblLeaderboard.Image")));
            this.lblLeaderboard.Location = new System.Drawing.Point(631, 278);
            this.lblLeaderboard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLeaderboard.Name = "lblLeaderboard";
            this.lblLeaderboard.Size = new System.Drawing.Size(218, 46);
            this.lblLeaderboard.TabIndex = 0;
            this.lblLeaderboard.Text = "Leaderboard";
            this.lblLeaderboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlace1
            // 
            this.lblPlace1.BackColor = System.Drawing.Color.Transparent;
            this.lblPlace1.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlace1.Image = ((System.Drawing.Image)(resources.GetObject("lblPlace1.Image")));
            this.lblPlace1.Location = new System.Drawing.Point(631, 330);
            this.lblPlace1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlace1.Name = "lblPlace1";
            this.lblPlace1.Size = new System.Drawing.Size(218, 30);
            this.lblPlace1.TabIndex = 0;
            this.lblPlace1.Text = "1.   wwwwww    000000";
            this.lblPlace1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPlace2
            // 
            this.lblPlace2.BackColor = System.Drawing.Color.Transparent;
            this.lblPlace2.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlace2.Image = ((System.Drawing.Image)(resources.GetObject("lblPlace2.Image")));
            this.lblPlace2.Location = new System.Drawing.Point(631, 365);
            this.lblPlace2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlace2.Name = "lblPlace2";
            this.lblPlace2.Size = new System.Drawing.Size(218, 30);
            this.lblPlace2.TabIndex = 0;
            this.lblPlace2.Text = "2.   TestName    000000";
            this.lblPlace2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPlace3
            // 
            this.lblPlace3.BackColor = System.Drawing.Color.Transparent;
            this.lblPlace3.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlace3.Image = ((System.Drawing.Image)(resources.GetObject("lblPlace3.Image")));
            this.lblPlace3.Location = new System.Drawing.Point(631, 400);
            this.lblPlace3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlace3.Name = "lblPlace3";
            this.lblPlace3.Size = new System.Drawing.Size(218, 30);
            this.lblPlace3.TabIndex = 0;
            this.lblPlace3.Text = "3.   TestName    000000";
            this.lblPlace3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPlace4
            // 
            this.lblPlace4.BackColor = System.Drawing.Color.Transparent;
            this.lblPlace4.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlace4.Image = ((System.Drawing.Image)(resources.GetObject("lblPlace4.Image")));
            this.lblPlace4.Location = new System.Drawing.Point(631, 435);
            this.lblPlace4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlace4.Name = "lblPlace4";
            this.lblPlace4.Size = new System.Drawing.Size(218, 30);
            this.lblPlace4.TabIndex = 0;
            this.lblPlace4.Text = "4.   TestName    000000";
            this.lblPlace4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPlace5
            // 
            this.lblPlace5.BackColor = System.Drawing.Color.Transparent;
            this.lblPlace5.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlace5.Image = ((System.Drawing.Image)(resources.GetObject("lblPlace5.Image")));
            this.lblPlace5.Location = new System.Drawing.Point(631, 470);
            this.lblPlace5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlace5.Name = "lblPlace5";
            this.lblPlace5.Size = new System.Drawing.Size(218, 30);
            this.lblPlace5.TabIndex = 0;
            this.lblPlace5.Text = "5.   TestName    000000";
            this.lblPlace5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPlace6
            // 
            this.lblPlace6.BackColor = System.Drawing.Color.Transparent;
            this.lblPlace6.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlace6.Image = ((System.Drawing.Image)(resources.GetObject("lblPlace6.Image")));
            this.lblPlace6.Location = new System.Drawing.Point(631, 505);
            this.lblPlace6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlace6.Name = "lblPlace6";
            this.lblPlace6.Size = new System.Drawing.Size(218, 30);
            this.lblPlace6.TabIndex = 0;
            this.lblPlace6.Text = "6.   TestName    000000";
            this.lblPlace6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPlace7
            // 
            this.lblPlace7.BackColor = System.Drawing.Color.Transparent;
            this.lblPlace7.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlace7.Image = ((System.Drawing.Image)(resources.GetObject("lblPlace7.Image")));
            this.lblPlace7.Location = new System.Drawing.Point(631, 540);
            this.lblPlace7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlace7.Name = "lblPlace7";
            this.lblPlace7.Size = new System.Drawing.Size(218, 30);
            this.lblPlace7.TabIndex = 0;
            this.lblPlace7.Text = "7.   TestName    000000";
            this.lblPlace7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPlace8
            // 
            this.lblPlace8.BackColor = System.Drawing.Color.Transparent;
            this.lblPlace8.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlace8.Image = ((System.Drawing.Image)(resources.GetObject("lblPlace8.Image")));
            this.lblPlace8.Location = new System.Drawing.Point(631, 575);
            this.lblPlace8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlace8.Name = "lblPlace8";
            this.lblPlace8.Size = new System.Drawing.Size(218, 30);
            this.lblPlace8.TabIndex = 0;
            this.lblPlace8.Text = "8.   TestName    000000";
            this.lblPlace8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblYouBottom
            // 
            this.lblYouBottom.BackColor = System.Drawing.Color.Transparent;
            this.lblYouBottom.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblYouBottom.Image = ((System.Drawing.Image)(resources.GetObject("lblYouBottom.Image")));
            this.lblYouBottom.Location = new System.Drawing.Point(665, 610);
            this.lblYouBottom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYouBottom.Name = "lblYouBottom";
            this.lblYouBottom.Size = new System.Drawing.Size(182, 30);
            this.lblYouBottom.TabIndex = 0;
            this.lblYouBottom.Text = "You    000000";
            this.lblYouBottom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(155)))), ((int)(((byte)(107)))));
            this.pictureBox1.Location = new System.Drawing.Point(631, 166);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 92);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(155)))), ((int)(((byte)(107)))));
            this.pictureBox2.Location = new System.Drawing.Point(629, 278);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(220, 377);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 693);
            this.Controls.Add(this.lblYouBottom);
            this.Controls.Add(this.lblPlace8);
            this.Controls.Add(this.lblPlace7);
            this.Controls.Add(this.lblPlace6);
            this.Controls.Add(this.lblPlace5);
            this.Controls.Add(this.lblPlace4);
            this.Controls.Add(this.lblPlace3);
            this.Controls.Add(this.lblPlace2);
            this.Controls.Add(this.lblPlace1);
            this.Controls.Add(this.lblLeaderboard);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblScoreText);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.GamePanel);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer MovementTimer;
        private System.Windows.Forms.Panel GamePanel;
        private System.Windows.Forms.Label lblScoreText;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox SnakeHeadBox;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox GameBackground;
        private System.Windows.Forms.Label lblLeaderboard;
        private System.Windows.Forms.Label lblPlace1;
        private System.Windows.Forms.Label lblPlace2;
        private System.Windows.Forms.Label lblPlace3;
        private System.Windows.Forms.Label lblPlace4;
        private System.Windows.Forms.Label lblPlace5;
        private System.Windows.Forms.Label lblPlace6;
        private System.Windows.Forms.Label lblPlace7;
        private System.Windows.Forms.Label lblPlace8;
        private System.Windows.Forms.Label lblYouBottom;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}