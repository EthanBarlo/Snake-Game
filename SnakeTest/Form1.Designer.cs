
namespace SnakeTest
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MovementTimer = new System.Windows.Forms.Timer(this.components);
            this.GamePanel = new System.Windows.Forms.Panel();
            this.SnakeHeadLabel = new System.Windows.Forms.Label();
            this.ScoreBox = new System.Windows.Forms.GroupBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.gameBorderBox = new System.Windows.Forms.PictureBox();
            this.GamePanel.SuspendLayout();
            this.ScoreBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameBorderBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MovementTimer
            // 
            this.MovementTimer.Tick += new System.EventHandler(this.TimerTick);
            // 
            // GamePanel
            // 
            this.GamePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GamePanel.BackgroundImage")));
            this.GamePanel.Controls.Add(this.SnakeHeadLabel);
            this.GamePanel.Location = new System.Drawing.Point(66, 48);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(500, 500);
            this.GamePanel.TabIndex = 0;
            // 
            // SnakeHeadLabel
            // 
            this.SnakeHeadLabel.BackColor = System.Drawing.Color.Transparent;
            this.SnakeHeadLabel.Image = ((System.Drawing.Image)(resources.GetObject("SnakeHeadLabel.Image")));
            this.SnakeHeadLabel.Location = new System.Drawing.Point(200, 200);
            this.SnakeHeadLabel.Name = "SnakeHeadLabel";
            this.SnakeHeadLabel.Size = new System.Drawing.Size(20, 20);
            this.SnakeHeadLabel.TabIndex = 0;
            // 
            // ScoreBox
            // 
            this.ScoreBox.Controls.Add(this.lblScore);
            this.ScoreBox.Controls.Add(this.label1);
            this.ScoreBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ScoreBox.Location = new System.Drawing.Point(582, 38);
            this.ScoreBox.Name = "ScoreBox";
            this.ScoreBox.Size = new System.Drawing.Size(184, 112);
            this.ScoreBox.TabIndex = 2;
            this.ScoreBox.TabStop = false;
            this.ScoreBox.Text = "ScoreBox";
            // 
            // lblScore
            // 
            this.lblScore.Location = new System.Drawing.Point(83, 30);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(93, 70);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "0000000";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "Score - 0000000";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReset
            // 
            this.btnReset.CausesValidation = false;
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(588, 176);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(82, 22);
            this.btnReset.TabIndex = 1;
            this.btnReset.TabStop = false;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // gameBorderBox
            // 
            this.gameBorderBox.Image = ((System.Drawing.Image)(resources.GetObject("gameBorderBox.Image")));
            this.gameBorderBox.Location = new System.Drawing.Point(56, 38);
            this.gameBorderBox.Name = "gameBorderBox";
            this.gameBorderBox.Size = new System.Drawing.Size(520, 520);
            this.gameBorderBox.TabIndex = 3;
            this.gameBorderBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 587);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.ScoreBox);
            this.Controls.Add(this.GamePanel);
            this.Controls.Add(this.gameBorderBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Snake Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyHasBeenPressed);
            this.GamePanel.ResumeLayout(false);
            this.ScoreBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gameBorderBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer MovementTimer;
        private System.Windows.Forms.Panel GamePanel;
        private System.Windows.Forms.Label SnakeHeadLabel;
        private System.Windows.Forms.GroupBox ScoreBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox gameBorderBox;
    }
}

