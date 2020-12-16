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
            this.btnCloseGameOver = new System.Windows.Forms.Button();
            this.lblEnterName = new System.Windows.Forms.Label();
            this.btnNameConfirm = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.GameOverBackground = new System.Windows.Forms.PictureBox();
            this.SnakeHeadBox = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblScoreText = new System.Windows.Forms.Label();
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.lbl9 = new System.Windows.Forms.Label();
            this.lbl10 = new System.Windows.Forms.Label();
            this.leaderBoardSnake = new System.Windows.Forms.PictureBox();
            this.ScoreMultiplyerTimer = new System.Windows.Forms.Timer(this.components);
            this.lblMultiplier = new System.Windows.Forms.Label();
            this.lblMultiplierText = new System.Windows.Forms.Label();
            this.MultiplierBox = new System.Windows.Forms.PictureBox();
            this.GamePanel.SuspendLayout();
            this.GameOverPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GameOverBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SnakeHeadBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaderBoardSnake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MultiplierBox)).BeginInit();
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
            this.GameOverPanel.Controls.Add(this.btnCloseGameOver);
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
            // btnCloseGameOver
            // 
            this.btnCloseGameOver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(155)))), ((int)(((byte)(107)))));
            this.btnCloseGameOver.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCloseGameOver.Location = new System.Drawing.Point(248, 198);
            this.btnCloseGameOver.Name = "btnCloseGameOver";
            this.btnCloseGameOver.Size = new System.Drawing.Size(140, 45);
            this.btnCloseGameOver.TabIndex = 5;
            this.btnCloseGameOver.Text = "Close";
            this.btnCloseGameOver.UseVisualStyleBackColor = false;
            this.btnCloseGameOver.Click += new System.EventHandler(this.GameOverClose);
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
            this.btnNameConfirm.Location = new System.Drawing.Point(46, 198);
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
            this.lblScore.Location = new System.Drawing.Point(873, 248);
            this.lblScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(160, 61);
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
            this.lblScoreText.Location = new System.Drawing.Point(873, 192);
            this.lblScoreText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScoreText.Name = "lblScoreText";
            this.lblScoreText.Size = new System.Drawing.Size(160, 56);
            this.lblScoreText.TabIndex = 0;
            this.lblScoreText.Text = "Score";
            this.lblScoreText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblPlace1.Location = new System.Drawing.Point(832, 401);
            this.lblPlace1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlace1.Name = "lblPlace1";
            this.lblPlace1.Size = new System.Drawing.Size(186, 30);
            this.lblPlace1.TabIndex = 0;
            this.lblPlace1.Text = "TestName    000000";
            this.lblPlace1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPlace1.Visible = false;
            // 
            // lblPlace2
            // 
            this.lblPlace2.BackColor = System.Drawing.Color.Transparent;
            this.lblPlace2.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlace2.Image = ((System.Drawing.Image)(resources.GetObject("lblPlace2.Image")));
            this.lblPlace2.Location = new System.Drawing.Point(832, 436);
            this.lblPlace2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlace2.Name = "lblPlace2";
            this.lblPlace2.Size = new System.Drawing.Size(186, 30);
            this.lblPlace2.TabIndex = 0;
            this.lblPlace2.Text = "TestName    000000";
            this.lblPlace2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPlace2.Visible = false;
            // 
            // lblPlace3
            // 
            this.lblPlace3.BackColor = System.Drawing.Color.Transparent;
            this.lblPlace3.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlace3.Image = ((System.Drawing.Image)(resources.GetObject("lblPlace3.Image")));
            this.lblPlace3.Location = new System.Drawing.Point(832, 471);
            this.lblPlace3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlace3.Name = "lblPlace3";
            this.lblPlace3.Size = new System.Drawing.Size(186, 30);
            this.lblPlace3.TabIndex = 0;
            this.lblPlace3.Text = "TestName    000000";
            this.lblPlace3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPlace3.Visible = false;
            // 
            // lblPlace4
            // 
            this.lblPlace4.BackColor = System.Drawing.Color.Transparent;
            this.lblPlace4.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlace4.Image = ((System.Drawing.Image)(resources.GetObject("lblPlace4.Image")));
            this.lblPlace4.Location = new System.Drawing.Point(832, 506);
            this.lblPlace4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlace4.Name = "lblPlace4";
            this.lblPlace4.Size = new System.Drawing.Size(186, 30);
            this.lblPlace4.TabIndex = 0;
            this.lblPlace4.Text = "TestName    000000";
            this.lblPlace4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPlace4.Visible = false;
            // 
            // lblPlace5
            // 
            this.lblPlace5.BackColor = System.Drawing.Color.Transparent;
            this.lblPlace5.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlace5.Image = ((System.Drawing.Image)(resources.GetObject("lblPlace5.Image")));
            this.lblPlace5.Location = new System.Drawing.Point(832, 541);
            this.lblPlace5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlace5.Name = "lblPlace5";
            this.lblPlace5.Size = new System.Drawing.Size(186, 30);
            this.lblPlace5.TabIndex = 0;
            this.lblPlace5.Text = "TestName    000000";
            this.lblPlace5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPlace5.Visible = false;
            // 
            // lblPlace6
            // 
            this.lblPlace6.BackColor = System.Drawing.Color.Transparent;
            this.lblPlace6.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlace6.Image = ((System.Drawing.Image)(resources.GetObject("lblPlace6.Image")));
            this.lblPlace6.Location = new System.Drawing.Point(832, 576);
            this.lblPlace6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlace6.Name = "lblPlace6";
            this.lblPlace6.Size = new System.Drawing.Size(186, 30);
            this.lblPlace6.TabIndex = 0;
            this.lblPlace6.Text = "TestName    000000";
            this.lblPlace6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPlace6.Visible = false;
            // 
            // lblPlace7
            // 
            this.lblPlace7.BackColor = System.Drawing.Color.Transparent;
            this.lblPlace7.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlace7.Image = ((System.Drawing.Image)(resources.GetObject("lblPlace7.Image")));
            this.lblPlace7.Location = new System.Drawing.Point(832, 611);
            this.lblPlace7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlace7.Name = "lblPlace7";
            this.lblPlace7.Size = new System.Drawing.Size(186, 30);
            this.lblPlace7.TabIndex = 0;
            this.lblPlace7.Text = "TestName    000000";
            this.lblPlace7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPlace7.Visible = false;
            // 
            // lblPlace8
            // 
            this.lblPlace8.BackColor = System.Drawing.Color.Transparent;
            this.lblPlace8.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlace8.Image = ((System.Drawing.Image)(resources.GetObject("lblPlace8.Image")));
            this.lblPlace8.Location = new System.Drawing.Point(832, 646);
            this.lblPlace8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlace8.Name = "lblPlace8";
            this.lblPlace8.Size = new System.Drawing.Size(186, 30);
            this.lblPlace8.TabIndex = 0;
            this.lblPlace8.Text = "TestName    000000";
            this.lblPlace8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPlace8.Visible = false;
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
            this.lblYouBottom.Visible = false;
            // 
            // lblPlace9
            // 
            this.lblPlace9.BackColor = System.Drawing.Color.Transparent;
            this.lblPlace9.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlace9.Image = ((System.Drawing.Image)(resources.GetObject("lblPlace9.Image")));
            this.lblPlace9.Location = new System.Drawing.Point(832, 681);
            this.lblPlace9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlace9.Name = "lblPlace9";
            this.lblPlace9.Size = new System.Drawing.Size(186, 30);
            this.lblPlace9.TabIndex = 0;
            this.lblPlace9.Text = "TestName    000000";
            this.lblPlace9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPlace9.Visible = false;
            // 
            // lblPlace10
            // 
            this.lblPlace10.BackColor = System.Drawing.Color.Transparent;
            this.lblPlace10.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlace10.Image = ((System.Drawing.Image)(resources.GetObject("lblPlace10.Image")));
            this.lblPlace10.Location = new System.Drawing.Point(832, 716);
            this.lblPlace10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlace10.Name = "lblPlace10";
            this.lblPlace10.Size = new System.Drawing.Size(186, 30);
            this.lblPlace10.TabIndex = 0;
            this.lblPlace10.Text = "TestName    000000";
            this.lblPlace10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPlace10.Visible = false;
            // 
            // lbl1
            // 
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl1.Location = new System.Drawing.Point(784, 401);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(41, 30);
            this.lbl1.TabIndex = 8;
            this.lbl1.Text = "1.";
            this.lbl1.Visible = false;
            // 
            // lbl2
            // 
            this.lbl2.BackColor = System.Drawing.Color.Transparent;
            this.lbl2.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl2.Location = new System.Drawing.Point(784, 436);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(41, 30);
            this.lbl2.TabIndex = 8;
            this.lbl2.Text = "2.";
            this.lbl2.Visible = false;
            // 
            // lbl3
            // 
            this.lbl3.BackColor = System.Drawing.Color.Transparent;
            this.lbl3.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl3.Location = new System.Drawing.Point(784, 471);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(41, 30);
            this.lbl3.TabIndex = 8;
            this.lbl3.Text = "3.";
            this.lbl3.Visible = false;
            // 
            // lbl4
            // 
            this.lbl4.BackColor = System.Drawing.Color.Transparent;
            this.lbl4.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl4.Location = new System.Drawing.Point(784, 506);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(41, 30);
            this.lbl4.TabIndex = 8;
            this.lbl4.Text = "4.";
            this.lbl4.Visible = false;
            // 
            // lbl5
            // 
            this.lbl5.BackColor = System.Drawing.Color.Transparent;
            this.lbl5.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl5.Location = new System.Drawing.Point(784, 540);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(41, 30);
            this.lbl5.TabIndex = 8;
            this.lbl5.Text = "5.";
            this.lbl5.Visible = false;
            // 
            // lbl6
            // 
            this.lbl6.BackColor = System.Drawing.Color.Transparent;
            this.lbl6.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl6.Location = new System.Drawing.Point(784, 576);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(41, 30);
            this.lbl6.TabIndex = 8;
            this.lbl6.Text = "6.";
            this.lbl6.Visible = false;
            // 
            // lbl7
            // 
            this.lbl7.BackColor = System.Drawing.Color.Transparent;
            this.lbl7.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl7.Location = new System.Drawing.Point(784, 611);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(41, 30);
            this.lbl7.TabIndex = 8;
            this.lbl7.Text = "7.";
            this.lbl7.Visible = false;
            // 
            // lbl8
            // 
            this.lbl8.BackColor = System.Drawing.Color.Transparent;
            this.lbl8.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl8.Location = new System.Drawing.Point(784, 646);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(41, 30);
            this.lbl8.TabIndex = 8;
            this.lbl8.Text = "8.";
            this.lbl8.Visible = false;
            // 
            // lbl9
            // 
            this.lbl9.BackColor = System.Drawing.Color.Transparent;
            this.lbl9.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl9.Location = new System.Drawing.Point(784, 681);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(41, 30);
            this.lbl9.TabIndex = 8;
            this.lbl9.Text = "9.";
            this.lbl9.Visible = false;
            // 
            // lbl10
            // 
            this.lbl10.BackColor = System.Drawing.Color.Transparent;
            this.lbl10.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl10.Location = new System.Drawing.Point(771, 715);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(50, 30);
            this.lbl10.TabIndex = 8;
            this.lbl10.Text = "10.";
            this.lbl10.Visible = false;
            // 
            // leaderBoardSnake
            // 
            this.leaderBoardSnake.BackColor = System.Drawing.Color.Transparent;
            this.leaderBoardSnake.Image = ((System.Drawing.Image)(resources.GetObject("leaderBoardSnake.Image")));
            this.leaderBoardSnake.Location = new System.Drawing.Point(679, 401);
            this.leaderBoardSnake.Name = "leaderBoardSnake";
            this.leaderBoardSnake.Size = new System.Drawing.Size(64, 448);
            this.leaderBoardSnake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leaderBoardSnake.TabIndex = 9;
            this.leaderBoardSnake.TabStop = false;
            // 
            // ScoreMultiplyerTimer
            // 
            this.ScoreMultiplyerTimer.Interval = 500;
            this.ScoreMultiplyerTimer.Tick += new System.EventHandler(this.ScoreMultiplierTick);
            // 
            // lblMultiplier
            // 
            this.lblMultiplier.BackColor = System.Drawing.Color.Transparent;
            this.lblMultiplier.Font = new System.Drawing.Font("Arial", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMultiplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(135)))), ((int)(((byte)(88)))));
            this.lblMultiplier.Location = new System.Drawing.Point(770, 236);
            this.lblMultiplier.Name = "lblMultiplier";
            this.lblMultiplier.Size = new System.Drawing.Size(104, 61);
            this.lblMultiplier.TabIndex = 0;
            this.lblMultiplier.Text = "3x";
            // 
            // lblMultiplierText
            // 
            this.lblMultiplierText.BackColor = System.Drawing.Color.Transparent;
            this.lblMultiplierText.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMultiplierText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(135)))), ((int)(((byte)(88)))));
            this.lblMultiplierText.Location = new System.Drawing.Point(775, 206);
            this.lblMultiplierText.Name = "lblMultiplierText";
            this.lblMultiplierText.Size = new System.Drawing.Size(95, 30);
            this.lblMultiplierText.TabIndex = 0;
            this.lblMultiplierText.Text = "Multiplier";
            // 
            // MultiplierBox
            // 
            this.MultiplierBox.BackColor = System.Drawing.Color.Transparent;
            this.MultiplierBox.ErrorImage = null;
            this.MultiplierBox.Image = ((System.Drawing.Image)(resources.GetObject("MultiplierBox.Image")));
            this.MultiplierBox.Location = new System.Drawing.Point(770, 204);
            this.MultiplierBox.Name = "MultiplierBox";
            this.MultiplierBox.Size = new System.Drawing.Size(100, 100);
            this.MultiplierBox.TabIndex = 12;
            this.MultiplierBox.TabStop = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 846);
            this.Controls.Add(this.lblMultiplierText);
            this.Controls.Add(this.lblMultiplier);
            this.Controls.Add(this.leaderBoardSnake);
            this.Controls.Add(this.MultiplierBox);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.lbl8);
            this.Controls.Add(this.lbl9);
            this.Controls.Add(this.lbl10);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblScoreText);
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
            this.Controls.Add(this.GamePanel);
            this.Controls.Add(this.GameBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "GameForm";
            this.Text = "Snake Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyHasBeenPressed);
            this.GamePanel.ResumeLayout(false);
            this.GameOverPanel.ResumeLayout(false);
            this.GameOverPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GameOverBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SnakeHeadBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaderBoardSnake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MultiplierBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer MovementTimer;
        private System.Windows.Forms.Panel GamePanel;
        private System.Windows.Forms.Label lblScoreText;
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
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.PictureBox leaderBoardSnake;
        private System.Windows.Forms.Button btnCloseGameOver;
        private System.Windows.Forms.Timer ScoreMultiplyerTimer;
        private System.Windows.Forms.Label lblMultiplier;
        private System.Windows.Forms.Label lblMultiplierText;
        private System.Windows.Forms.PictureBox MultiplierBox;
    }
}