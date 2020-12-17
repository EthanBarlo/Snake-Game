
namespace SnakeTest
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.LeaderBoardPanel = new System.Windows.Forms.Panel();
            this.lbtnClose = new System.Windows.Forms.Button();
            this.lbtnFalse = new System.Windows.Forms.Button();
            this.lbtnTrue = new System.Windows.Forms.Button();
            this.lbtnMedium = new System.Windows.Forms.Button();
            this.lbtnLarge = new System.Windows.Forms.Button();
            this.lbtnSmall = new System.Windows.Forms.Button();
            this.lbtnAll = new System.Windows.Forms.Button();
            this.lbLeaderboard = new System.Windows.Forms.ListBox();
            this.LeaderboardBackground = new System.Windows.Forms.PictureBox();
            this.SettingsPannel = new System.Windows.Forms.Panel();
            this.btnTeleportFalse = new System.Windows.Forms.Button();
            this.btnTeleportTrue = new System.Windows.Forms.Button();
            this.btnSizeMedium = new System.Windows.Forms.Button();
            this.btnSizeLarge = new System.Windows.Forms.Button();
            this.btnSizeSmall = new System.Windows.Forms.Button();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.SettingsBackground = new System.Windows.Forms.PictureBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnLeaderboard = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.MenuBackground = new System.Windows.Forms.PictureBox();
            this.MenuPanel.SuspendLayout();
            this.LeaderBoardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeaderboardBackground)).BeginInit();
            this.SettingsPannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.Transparent;
            this.MenuPanel.Controls.Add(this.LeaderBoardPanel);
            this.MenuPanel.Controls.Add(this.SettingsPannel);
            this.MenuPanel.Controls.Add(this.btnSettings);
            this.MenuPanel.Controls.Add(this.btnLeaderboard);
            this.MenuPanel.Controls.Add(this.btnPlay);
            this.MenuPanel.Controls.Add(this.btnQuit);
            this.MenuPanel.Controls.Add(this.MenuBackground);
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(888, 674);
            this.MenuPanel.TabIndex = 6;
            // 
            // LeaderBoardPanel
            // 
            this.LeaderBoardPanel.Controls.Add(this.lbtnClose);
            this.LeaderBoardPanel.Controls.Add(this.lbtnFalse);
            this.LeaderBoardPanel.Controls.Add(this.lbtnTrue);
            this.LeaderBoardPanel.Controls.Add(this.lbtnMedium);
            this.LeaderBoardPanel.Controls.Add(this.lbtnLarge);
            this.LeaderBoardPanel.Controls.Add(this.lbtnSmall);
            this.LeaderBoardPanel.Controls.Add(this.lbtnAll);
            this.LeaderBoardPanel.Controls.Add(this.lbLeaderboard);
            this.LeaderBoardPanel.Controls.Add(this.LeaderboardBackground);
            this.LeaderBoardPanel.Location = new System.Drawing.Point(0, 0);
            this.LeaderBoardPanel.Name = "LeaderBoardPanel";
            this.LeaderBoardPanel.Size = new System.Drawing.Size(886, 674);
            this.LeaderBoardPanel.TabIndex = 8;
            this.LeaderBoardPanel.Visible = false;
            // 
            // lbtnClose
            // 
            this.lbtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbtnClose.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbtnClose.Image = ((System.Drawing.Image)(resources.GetObject("lbtnClose.Image")));
            this.lbtnClose.Location = new System.Drawing.Point(37, 30);
            this.lbtnClose.Name = "lbtnClose";
            this.lbtnClose.Size = new System.Drawing.Size(150, 75);
            this.lbtnClose.TabIndex = 6;
            this.lbtnClose.UseVisualStyleBackColor = true;
            this.lbtnClose.Click += new System.EventHandler(this.LeaderboardClose);
            // 
            // lbtnFalse
            // 
            this.lbtnFalse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbtnFalse.Image = ((System.Drawing.Image)(resources.GetObject("lbtnFalse.Image")));
            this.lbtnFalse.Location = new System.Drawing.Point(668, 388);
            this.lbtnFalse.Name = "lbtnFalse";
            this.lbtnFalse.Size = new System.Drawing.Size(90, 90);
            this.lbtnFalse.TabIndex = 5;
            this.lbtnFalse.UseVisualStyleBackColor = true;
            this.lbtnFalse.Click += new System.EventHandler(this.LBoardTeleport);
            // 
            // lbtnTrue
            // 
            this.lbtnTrue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbtnTrue.Image = ((System.Drawing.Image)(resources.GetObject("lbtnTrue.Image")));
            this.lbtnTrue.Location = new System.Drawing.Point(668, 254);
            this.lbtnTrue.Name = "lbtnTrue";
            this.lbtnTrue.Size = new System.Drawing.Size(90, 90);
            this.lbtnTrue.TabIndex = 5;
            this.lbtnTrue.UseVisualStyleBackColor = true;
            this.lbtnTrue.Click += new System.EventHandler(this.LBoardTeleport);
            // 
            // lbtnMedium
            // 
            this.lbtnMedium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbtnMedium.Image = ((System.Drawing.Image)(resources.GetObject("lbtnMedium.Image")));
            this.lbtnMedium.Location = new System.Drawing.Point(104, 384);
            this.lbtnMedium.Name = "lbtnMedium";
            this.lbtnMedium.Size = new System.Drawing.Size(90, 90);
            this.lbtnMedium.TabIndex = 4;
            this.lbtnMedium.UseVisualStyleBackColor = true;
            this.lbtnMedium.Click += new System.EventHandler(this.LBoardSize);
            // 
            // lbtnLarge
            // 
            this.lbtnLarge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbtnLarge.Image = ((System.Drawing.Image)(resources.GetObject("lbtnLarge.Image")));
            this.lbtnLarge.Location = new System.Drawing.Point(104, 513);
            this.lbtnLarge.Name = "lbtnLarge";
            this.lbtnLarge.Size = new System.Drawing.Size(90, 90);
            this.lbtnLarge.TabIndex = 4;
            this.lbtnLarge.UseVisualStyleBackColor = true;
            this.lbtnLarge.Click += new System.EventHandler(this.LBoardSize);
            // 
            // lbtnSmall
            // 
            this.lbtnSmall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbtnSmall.Image = ((System.Drawing.Image)(resources.GetObject("lbtnSmall.Image")));
            this.lbtnSmall.Location = new System.Drawing.Point(104, 253);
            this.lbtnSmall.Name = "lbtnSmall";
            this.lbtnSmall.Size = new System.Drawing.Size(90, 90);
            this.lbtnSmall.TabIndex = 4;
            this.lbtnSmall.UseVisualStyleBackColor = true;
            this.lbtnSmall.Click += new System.EventHandler(this.LBoardSize);
            // 
            // lbtnAll
            // 
            this.lbtnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbtnAll.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbtnAll.Image = ((System.Drawing.Image)(resources.GetObject("lbtnAll.Image")));
            this.lbtnAll.Location = new System.Drawing.Point(334, 151);
            this.lbtnAll.Name = "lbtnAll";
            this.lbtnAll.Size = new System.Drawing.Size(210, 40);
            this.lbtnAll.TabIndex = 3;
            this.lbtnAll.UseVisualStyleBackColor = true;
            this.lbtnAll.Click += new System.EventHandler(this.LBoardClear);
            // 
            // lbLeaderboard
            // 
            this.lbLeaderboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(155)))), ((int)(((byte)(107)))));
            this.lbLeaderboard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbLeaderboard.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbLeaderboard.FormattingEnabled = true;
            this.lbLeaderboard.ItemHeight = 19;
            this.lbLeaderboard.Location = new System.Drawing.Point(300, 253);
            this.lbLeaderboard.Name = "lbLeaderboard";
            this.lbLeaderboard.Size = new System.Drawing.Size(280, 380);
            this.lbLeaderboard.TabIndex = 1;
            // 
            // LeaderboardBackground
            // 
            this.LeaderboardBackground.ErrorImage = null;
            this.LeaderboardBackground.Image = ((System.Drawing.Image)(resources.GetObject("LeaderboardBackground.Image")));
            this.LeaderboardBackground.Location = new System.Drawing.Point(0, 0);
            this.LeaderboardBackground.Name = "LeaderboardBackground";
            this.LeaderboardBackground.Size = new System.Drawing.Size(888, 674);
            this.LeaderboardBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LeaderboardBackground.TabIndex = 7;
            this.LeaderboardBackground.TabStop = false;
            // 
            // SettingsPannel
            // 
            this.SettingsPannel.BackColor = System.Drawing.Color.Transparent;
            this.SettingsPannel.Controls.Add(this.btnTeleportFalse);
            this.SettingsPannel.Controls.Add(this.btnTeleportTrue);
            this.SettingsPannel.Controls.Add(this.btnSizeMedium);
            this.SettingsPannel.Controls.Add(this.btnSizeLarge);
            this.SettingsPannel.Controls.Add(this.btnSizeSmall);
            this.SettingsPannel.Controls.Add(this.btnSaveSettings);
            this.SettingsPannel.Controls.Add(this.SettingsBackground);
            this.SettingsPannel.Location = new System.Drawing.Point(0, 0);
            this.SettingsPannel.Name = "SettingsPannel";
            this.SettingsPannel.Size = new System.Drawing.Size(886, 674);
            this.SettingsPannel.TabIndex = 6;
            this.SettingsPannel.Visible = false;
            // 
            // btnTeleportFalse
            // 
            this.btnTeleportFalse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeleportFalse.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTeleportFalse.Image = ((System.Drawing.Image)(resources.GetObject("btnTeleportFalse.Image")));
            this.btnTeleportFalse.Location = new System.Drawing.Point(593, 350);
            this.btnTeleportFalse.Name = "btnTeleportFalse";
            this.btnTeleportFalse.Size = new System.Drawing.Size(90, 90);
            this.btnTeleportFalse.TabIndex = 5;
            this.btnTeleportFalse.TabStop = false;
            this.btnTeleportFalse.UseVisualStyleBackColor = true;
            this.btnTeleportFalse.Click += new System.EventHandler(this.btnTeleportClick);
            // 
            // btnTeleportTrue
            // 
            this.btnTeleportTrue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeleportTrue.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTeleportTrue.Image = ((System.Drawing.Image)(resources.GetObject("btnTeleportTrue.Image")));
            this.btnTeleportTrue.Location = new System.Drawing.Point(454, 350);
            this.btnTeleportTrue.Name = "btnTeleportTrue";
            this.btnTeleportTrue.Size = new System.Drawing.Size(90, 90);
            this.btnTeleportTrue.TabIndex = 5;
            this.btnTeleportTrue.TabStop = false;
            this.btnTeleportTrue.UseVisualStyleBackColor = true;
            this.btnTeleportTrue.Click += new System.EventHandler(this.btnTeleportClick);
            // 
            // btnSizeMedium
            // 
            this.btnSizeMedium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSizeMedium.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSizeMedium.Image = ((System.Drawing.Image)(resources.GetObject("btnSizeMedium.Image")));
            this.btnSizeMedium.Location = new System.Drawing.Point(519, 254);
            this.btnSizeMedium.Name = "btnSizeMedium";
            this.btnSizeMedium.Size = new System.Drawing.Size(90, 90);
            this.btnSizeMedium.TabIndex = 4;
            this.btnSizeMedium.UseVisualStyleBackColor = true;
            this.btnSizeMedium.Click += new System.EventHandler(this.GameSizeBtnClick);
            // 
            // btnSizeLarge
            // 
            this.btnSizeLarge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSizeLarge.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSizeLarge.Image = ((System.Drawing.Image)(resources.GetObject("btnSizeLarge.Image")));
            this.btnSizeLarge.Location = new System.Drawing.Point(653, 254);
            this.btnSizeLarge.Name = "btnSizeLarge";
            this.btnSizeLarge.Size = new System.Drawing.Size(90, 90);
            this.btnSizeLarge.TabIndex = 4;
            this.btnSizeLarge.UseVisualStyleBackColor = true;
            this.btnSizeLarge.Click += new System.EventHandler(this.GameSizeBtnClick);
            // 
            // btnSizeSmall
            // 
            this.btnSizeSmall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSizeSmall.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSizeSmall.Image = ((System.Drawing.Image)(resources.GetObject("btnSizeSmall.Image")));
            this.btnSizeSmall.Location = new System.Drawing.Point(378, 254);
            this.btnSizeSmall.Name = "btnSizeSmall";
            this.btnSizeSmall.Size = new System.Drawing.Size(90, 90);
            this.btnSizeSmall.TabIndex = 4;
            this.btnSizeSmall.UseVisualStyleBackColor = true;
            this.btnSizeSmall.Click += new System.EventHandler(this.GameSizeBtnClick);
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveSettings.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveSettings.Image")));
            this.btnSaveSettings.Location = new System.Drawing.Point(321, 500);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(200, 75);
            this.btnSaveSettings.TabIndex = 2;
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.SaveSettingsClick);
            // 
            // SettingsBackground
            // 
            this.SettingsBackground.Image = ((System.Drawing.Image)(resources.GetObject("SettingsBackground.Image")));
            this.SettingsBackground.Location = new System.Drawing.Point(0, 0);
            this.SettingsBackground.Name = "SettingsBackground";
            this.SettingsBackground.Size = new System.Drawing.Size(886, 674);
            this.SettingsBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SettingsBackground.TabIndex = 6;
            this.SettingsBackground.TabStop = false;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(135)))), ((int)(((byte)(88)))));
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.Location = new System.Drawing.Point(227, 430);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(420, 70);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.SettingsClick);
            // 
            // btnLeaderboard
            // 
            this.btnLeaderboard.BackColor = System.Drawing.Color.Transparent;
            this.btnLeaderboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeaderboard.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLeaderboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(135)))), ((int)(((byte)(88)))));
            this.btnLeaderboard.Image = ((System.Drawing.Image)(resources.GetObject("btnLeaderboard.Image")));
            this.btnLeaderboard.Location = new System.Drawing.Point(223, 350);
            this.btnLeaderboard.Name = "btnLeaderboard";
            this.btnLeaderboard.Size = new System.Drawing.Size(420, 70);
            this.btnLeaderboard.TabIndex = 5;
            this.btnLeaderboard.Text = "Leaderboard";
            this.btnLeaderboard.UseVisualStyleBackColor = false;
            this.btnLeaderboard.Click += new System.EventHandler(this.LeaderboardOpen);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(135)))), ((int)(((byte)(88)))));
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.Location = new System.Drawing.Point(223, 270);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(420, 70);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.PlayClicked);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Transparent;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnQuit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(135)))), ((int)(((byte)(88)))));
            this.btnQuit.Image = ((System.Drawing.Image)(resources.GetObject("btnQuit.Image")));
            this.btnQuit.Location = new System.Drawing.Point(227, 510);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(420, 70);
            this.btnQuit.TabIndex = 6;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // MenuBackground
            // 
            this.MenuBackground.Image = ((System.Drawing.Image)(resources.GetObject("MenuBackground.Image")));
            this.MenuBackground.Location = new System.Drawing.Point(0, 0);
            this.MenuBackground.Name = "MenuBackground";
            this.MenuBackground.Size = new System.Drawing.Size(888, 683);
            this.MenuBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuBackground.TabIndex = 7;
            this.MenuBackground.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 675);
            this.Controls.Add(this.MenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Menu";
            this.Text = "Menu";
            this.MenuPanel.ResumeLayout(false);
            this.LeaderBoardPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LeaderboardBackground)).EndInit();
            this.SettingsPannel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SettingsBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Panel SettingsPannel;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnSizeMedium;
        private System.Windows.Forms.Button btnSizeLarge;
        private System.Windows.Forms.Button btnSizeSmall;
        private System.Windows.Forms.PictureBox MenuBackground;
        private System.Windows.Forms.Button btnTeleportTrue;
        private System.Windows.Forms.Button btnTeleportFalse;
        private System.Windows.Forms.PictureBox SettingsBackground;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Panel LeaderBoardPanel;
        private System.Windows.Forms.Button lbtnFalse;
        private System.Windows.Forms.Button lbtnTrue;
        private System.Windows.Forms.Button lbtnMedium;
        private System.Windows.Forms.Button lbtnLarge;
        private System.Windows.Forms.Button lbtnSmall;
        private System.Windows.Forms.Button lbtnAll;
        private System.Windows.Forms.ListBox lbLeaderboard;
        private System.Windows.Forms.Button lbtnClose;
        private System.Windows.Forms.Button btnLeaderboard;
        private System.Windows.Forms.PictureBox LeaderboardBackground;
    }
}