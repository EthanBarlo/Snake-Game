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
            this.GameOverPanel = new System.Windows.Forms.Panel();
            this.lblEnterName = new System.Windows.Forms.Label();
            this.btnNameConfirm = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.GameOverBackground = new System.Windows.Forms.PictureBox();
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
            this.lblPlace9 = new System.Windows.Forms.Label();
            this.lblPlace10 = new System.Windows.Forms.Label();
            this.ScorePanel = new System.Windows.Forms.Panel();
            this.GamePanel.SuspendLayout();
            this.GameOverPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GameOverBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SnakeHeadBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameBackground)).BeginInit();
            this.ScorePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MovementTimer
            // 
            this.MovementTimer.Tick += new System.EventHandler(this.TimerTick);
            // 
            // GamePanel
            // 
            this.GamePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GamePanel.BackgroundImage")));
            this.GamePanel.Controls.Add(this.GameOverPanel);
            this.GamePanel.Controls.Add(this.SnakeHeadBox);
            this.GamePanel.Location = new System.Drawing.Point(72, 192);
            this.GamePanel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(600, 600);
            this.GamePanel.TabIndex = 0;
            // 
            // GameOverPanel
            // 
            this.GameOverPanel.BackColor = System.Drawing.Color.Transparent;
            this.GameOverPanel.Controls.Add(this.lblEnterName);
            this.GameOverPanel.Controls.Add(this.btnNameConfirm);
            this.GameOverPanel.Controls.Add(this.tbName);
            this.GameOverPanel.Controls.Add(this.lblGameOver);
            this.GameOverPanel.Controls.Add(this.GameOverBackground);
            this.GameOverPanel.Location = new System.Drawing.Point(79, 157);
            this.GameOverPanel.Name = "GameOverPanel";
            this.GameOverPanel.Size = new System.Drawing.Size(446, 269);
            this.GameOverPanel.TabIndex = 8;
            this.GameOverPanel.Visible = false;
            // 
            // lblEnterName
            // 
            this.lblEnterName.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEnterName.Location = new System.Drawing.Point(46, 82);
            this.lblEnterName.Name = "lblEnterName";
            this.lblEnterName.Size = new System.Drawing.Size(342, 52);
            this.lblEnterName.TabIndex = 4;
            this.lblEnterName.Text = "Enter your Name. Max Size of 6 Characters";
            this.lblEnterName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNameConfirm
            // 
            this.btnNameConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(155)))), ((int)(((byte)(107)))));
            this.btnNameConfirm.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNameConfirm.Location = new System.Drawing.Point(121, 198);
            this.btnNameConfirm.Name = "btnNameConfirm";
            this.btnNameConfirm.Size = new System.Drawing.Size(191, 45);
            this.btnNameConfirm.TabIndex = 3;
            this.btnNameConfirm.Text = "Add Score";
            this.btnNameConfirm.UseVisualStyleBackColor = false;
            this.btnNameConfirm.Click += new System.EventHandler(this.AddScoreClick);
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(155)))), ((int)(((byte)(107)))));
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbName.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbName.Location = new System.Drawing.Point(46, 139);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(342, 53);
            this.tbName.TabIndex = 2;
            this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGameOver.Location = new System.Drawing.Point(93, 36);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(244, 46);
            this.lblGameOver.TabIndex = 1;
            this.lblGameOver.Text = "Game Over!";
            // 
            // GameOverBackground
            // 
            this.GameOverBackground.Image = ((System.Drawing.Image)(resources.GetObject("GameOverBackground.Image")));
            this.GameOverBackground.Location = new System.Drawing.Point(0, 0);
            this.GameOverBackground.Name = "GameOverBackground";
            this.GameOverBackground.Size = new System.Drawing.Size(446, 269);
            this.GameOverBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GameOverBackground.TabIndex = 0;
            this.GameOverBackground.TabStop = false;
            // 
            // SnakeHeadBox
            // 
            this.SnakeHeadBox.BackColor = System.Drawing.Color.Transparent;
            this.SnakeHeadBox.Image = ((System.Drawing.Image)(resources.GetObject("SnakeHeadBox.Image")));
            this.SnakeHeadBox.Location = new System.Drawing.Point(200, 200);
            this.SnakeHeadBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.SnakeHeadBox.Name = "SnakeHeadBox";
            this.SnakeHeadBox.Size = new System.Drawing.Size(40, 40);
            this.SnakeHeadBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SnakeHeadBox.TabIndex = 0;
            this.SnakeHeadBox.TabStop = false;
            // 
            // lblScore
            // 
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(135)))), ((int)(((byte)(88)))));
            this.lblScore.Location = new System.Drawing.Point(5, 66);
            this.lblScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(268, 61);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "000000";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScoreText
            // 
            this.lblScoreText.BackColor = System.Drawing.Color.Transparent;
            this.lblScoreText.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblScoreText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(135)))), ((int)(((byte)(88)))));
            this.lblScoreText.Image = ((System.Drawing.Image)(resources.GetObject("lblScoreText.Image")));
            this.lblScoreText.Location = new System.Drawing.Point(58, 13);
            this.lblScoreText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScoreText.Name = "lblScoreText";
            this.lblScoreText.Size = new System.Drawing.Size(160, 56);
            this.lblScoreText.TabIndex = 0;
            this.lblScoreText.Text = "Score";
            this.lblScoreText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReset
            // 
            this.btnReset.CausesValidation = false;
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(884, 103);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(130, 48);
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
            this.GameBackground.Size = new System.Drawing.Size(1095, 850);
            this.GameBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GameBackground.TabIndex = 7;
            this.GameBackground.TabStop = false;
            // 
            // lblLeaderboard
            // 
            this.lblLeaderboard.BackColor = System.Drawing.Color.Transparent;
            this.lblLeaderboard.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLeaderboard.Image = ((System.Drawing.Image)(resources.GetObject("lblLeaderboard.Image")));
            this.lblLeaderboard.Location = new System.Drawing.Point(794, 349);
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
            this.lblPlace1.Location = new System.Drawing.Point(784, 401);
            this.lblPlace1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlace1.Name = "lblPlace1";
            this.lblPlace1.Size = new System.Drawing.Size(234, 30);
            this.lblPlace1.TabIndex = 0;
            this.lblPlace1.Text = "1.   wwwwww    000000";
            this.lblPlace1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPlace2
            // 
            this.lblPlace2.BackColor = System.Drawing.Color.Transparent;
            this.lblPlace2.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlace2.Image = ((System.Drawing.Image)(resources.GetObject("lblPlace2.Image")));
            this.lblPlace2.Location = new System.Drawing.Point(784, 436);
            this.lblPlace2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlace2.Name = "lblPlace2";
            this.lblPlace2.Size = new System.Drawing.Size(234, 30);
            this.lblPlace2.TabIndex = 0;
            this.lblPlace2.Text = "2.   TestName    000000";
            this.lblPlace2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPlace3
            // 
            this.lblPlace3.BackColor = System.Drawing.Color.Transparent;
            this.lblPlace3.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlace3.Image = ((System.Drawing.Image)(resources.GetObject("lblPlace3.Image")));
            this.lblPlace3.Location = new System.Drawing.Point(784, 471);
            this.lblPlace3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlace3.Name = "lblPlace3";
            this.lblPlace3.Size = new System.Drawing.Size(234, 30);
            this.lblPlace3.TabIndex = 0;
            this.lblPlace3.Text = "3.   TestName    000000";
            this.lblPlace3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPlace4
            // 
            this.lblPlace4.BackColor = System.Drawing.Color.Transparent;
            this.lblPlace4.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlace4.Image = ((System.Drawing.Image)(resources.GetObject("lblPlace4.Image")));
            this.lblPlace4.Location = new System.Drawing.Point(784, 506);
            this.lblPlace4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlace4.Name = "lblPlace4";
            this.lblPlace4.Size = new System.Drawing.Size(234, 30);
            this.lblPlace4.TabIndex = 0;
            this.lblPlace4.Text = "4.   TestName    000000";
            this.lblPlace4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPlace5
            // 
            this.lblPlace5.BackColor = System.Drawing.Color.Transparent;
            this.lblPlace5.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlace5.Image = ((System.Drawing.Image)(resources.GetObject("lblPlace5.Image")));
            this.lblPlace5.Location = new System.Drawing.Point(784, 541);
            this.lblPlace5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlace5.Name = "lblPlace5";
            this.lblPlace5.Size = new System.Drawing.Size(234, 30);
            this.lblPlace5.TabIndex = 0;
            this.lblPlace5.Text = "5.   TestName    000000";
            this.lblPlace5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPlace6
            // 
            this.lblPlace6.BackColor = System.Drawing.Color.Transparent;
            this.lblPlace6.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlace6.Image = ((System.Drawing.Image)(resources.GetObject("lblPlace6.Image")));
            this.lblPlace6.Location = new System.Drawing.Point(784, 576);
            this.lblPlace6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlace6.Name = "lblPlace6";
            this.lblPlace6.Size = new System.Drawing.Size(234, 30);
            this.lblPlace6.TabIndex = 0;
            this.lblPlace6.Text = "6.   TestName    000000";
            this.lblPlace6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPlace7
            // 
            this.lblPlace7.BackColor = System.Drawing.Color.Transparent;
            this.lblPlace7.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlace7.Image = ((System.Drawing.Image)(resources.GetObject("lblPlace7.Image")));
            this.lblPlace7.Location = new System.Drawing.Point(784, 611);
            this.lblPlace7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlace7.Name = "lblPlace7";
            this.lblPlace7.Size = new System.Drawing.Size(234, 30);
            this.lblPlace7.TabIndex = 0;
            this.lblPlace7.Text = "7.   TestName    000000";
            this.lblPlace7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPlace8
            // 
            this.lblPlace8.BackColor = System.Drawing.Color.Transparent;
            this.lblPlace8.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlace8.Image = ((System.Drawing.Image)(resources.GetObject("lblPlace8.Image")));
            this.lblPlace8.Location = new System.Drawing.Point(784, 646);
            this.lblPlace8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlace8.Name = "lblPlace8";
            this.lblPlace8.Size = new System.Drawing.Size(234, 30);
            this.lblPlace8.TabIndex = 0;
            this.lblPlace8.Text = "8.   TestName    000000";
            this.lblPlace8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblYouBottom
            // 
            this.lblYouBottom.BackColor = System.Drawing.Color.Transparent;
            this.lblYouBottom.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblYouBottom.Image = ((System.Drawing.Image)(resources.GetObject("lblYouBottom.Image")));
            this.lblYouBottom.Location = new System.Drawing.Point(832, 751);
            this.lblYouBottom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYouBottom.Name = "lblYouBottom";
            this.lblYouBottom.Size = new System.Drawing.Size(182, 30);
            this.lblYouBottom.TabIndex = 0;
            this.lblYouBottom.Text = "You    000000";
            this.lblYouBottom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPlace9
            // 
            this.lblPlace9.BackColor = System.Drawing.Color.Transparent;
            this.lblPlace9.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlace9.Image = ((System.Drawing.Image)(resources.GetObject("lblPlace9.Image")));
            this.lblPlace9.Location = new System.Drawing.Point(784, 681);
            this.lblPlace9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlace9.Name = "lblPlace9";
            this.lblPlace9.Size = new System.Drawing.Size(234, 30);
            this.lblPlace9.TabIndex = 0;
            this.lblPlace9.Text = "9.   TestName    000000";
            this.lblPlace9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPlace10
            // 
            this.lblPlace10.BackColor = System.Drawing.Color.Transparent;
            this.lblPlace10.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlace10.Image = ((System.Drawing.Image)(resources.GetObject("lblPlace10.Image")));
            this.lblPlace10.Location = new System.Drawing.Point(784, 716);
            this.lblPlace10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlace10.Name = "lblPlace10";
            this.lblPlace10.Size = new System.Drawing.Size(234, 30);
            this.lblPlace10.TabIndex = 0;
            this.lblPlace10.Text = "10.  TestName    000000";
            this.lblPlace10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ScorePanel
            // 
            this.ScorePanel.BackColor = System.Drawing.Color.Transparent;
            this.ScorePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ScorePanel.BackgroundImage")));
            this.ScorePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ScorePanel.Controls.Add(this.lblScoreText);
            this.ScorePanel.Controls.Add(this.lblScore);
            this.ScorePanel.Location = new System.Drawing.Point(754, 181);
            this.ScorePanel.Name = "ScorePanel";
            this.ScorePanel.Size = new System.Drawing.Size(289, 145);
            this.ScorePanel.TabIndex = 8;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 846);
            this.Controls.Add(this.ScorePanel);
            this.Controls.Add(this.lblYouBottom);
            this.Controls.Add(this.lblPlace9);
            this.Controls.Add(this.lblPlace10);
            this.Controls.Add(this.lblPlace8);
            this.Controls.Add(this.lblPlace7);
            this.Controls.Add(this.lblPlace6);
            this.Controls.Add(this.lblPlace5);
            this.Controls.Add(this.lblPlace4);
            this.Controls.Add(this.lblPlace3);
            this.Controls.Add(this.lblPlace2);
            this.Controls.Add(this.lblPlace1);
            this.Controls.Add(this.lblLeaderboard);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.GamePanel);
            this.Controls.Add(this.GameBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "GameForm";
            this.Text = "Snake Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyHasBeenPressed);
            this.GamePanel.ResumeLayout(false);
            this.GameOverPanel.ResumeLayout(false);
            this.GameOverPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GameOverBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SnakeHeadBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameBackground)).EndInit();
            this.ScorePanel.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblPlace9;
        private System.Windows.Forms.Label lblPlace10;
        private System.Windows.Forms.Panel GameOverPanel;
        private System.Windows.Forms.PictureBox GameOverBackground;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Label lblEnterName;
        private System.Windows.Forms.Button btnNameConfirm;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Panel ScorePanel;
    }
}