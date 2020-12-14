
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
            this.Settings = new System.Windows.Forms.Panel();
            this.btnSizeMedium = new System.Windows.Forms.Button();
            this.btnSizeLarge = new System.Windows.Forms.Button();
            this.btnSizeSmall = new System.Windows.Forms.Button();
            this.lblGameSize = new System.Windows.Forms.Label();
            this.btnCloseSettings = new System.Windows.Forms.Button();
            this.lblSettings = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.MenuPanel.SuspendLayout();
            this.Settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.Transparent;
            this.MenuPanel.Controls.Add(this.Settings);
            this.MenuPanel.Controls.Add(this.btnSettings);
            this.MenuPanel.Controls.Add(this.btnPlay);
            this.MenuPanel.Controls.Add(this.pictureBox1);
            this.MenuPanel.Controls.Add(this.btnQuit);
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(886, 660);
            this.MenuPanel.TabIndex = 6;
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.Transparent;
            this.Settings.Controls.Add(this.btnSizeMedium);
            this.Settings.Controls.Add(this.btnSizeLarge);
            this.Settings.Controls.Add(this.btnSizeSmall);
            this.Settings.Controls.Add(this.lblGameSize);
            this.Settings.Controls.Add(this.btnCloseSettings);
            this.Settings.Controls.Add(this.lblSettings);
            this.Settings.Location = new System.Drawing.Point(0, 0);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(886, 660);
            this.Settings.TabIndex = 6;
            this.Settings.Visible = false;
            // 
            // btnSizeMedium
            // 
            this.btnSizeMedium.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSizeMedium.Location = new System.Drawing.Point(504, 238);
            this.btnSizeMedium.Name = "btnSizeMedium";
            this.btnSizeMedium.Size = new System.Drawing.Size(97, 76);
            this.btnSizeMedium.TabIndex = 4;
            this.btnSizeMedium.Text = "M";
            this.btnSizeMedium.UseVisualStyleBackColor = true;
            this.btnSizeMedium.Click += new System.EventHandler(this.GameSizeChange);
            // 
            // btnSizeLarge
            // 
            this.btnSizeLarge.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSizeLarge.Location = new System.Drawing.Point(663, 238);
            this.btnSizeLarge.Name = "btnSizeLarge";
            this.btnSizeLarge.Size = new System.Drawing.Size(97, 76);
            this.btnSizeLarge.TabIndex = 4;
            this.btnSizeLarge.Text = "L";
            this.btnSizeLarge.UseVisualStyleBackColor = true;
            this.btnSizeLarge.Click += new System.EventHandler(this.GameSizeChange);
            // 
            // btnSizeSmall
            // 
            this.btnSizeSmall.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSizeSmall.Location = new System.Drawing.Point(351, 238);
            this.btnSizeSmall.Name = "btnSizeSmall";
            this.btnSizeSmall.Size = new System.Drawing.Size(97, 76);
            this.btnSizeSmall.TabIndex = 4;
            this.btnSizeSmall.Text = "S";
            this.btnSizeSmall.UseVisualStyleBackColor = true;
            this.btnSizeSmall.Click += new System.EventHandler(this.GameSizeChange);
            // 
            // lblGameSize
            // 
            this.lblGameSize.AutoSize = true;
            this.lblGameSize.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGameSize.Location = new System.Drawing.Point(45, 238);
            this.lblGameSize.Name = "lblGameSize";
            this.lblGameSize.Size = new System.Drawing.Size(253, 62);
            this.lblGameSize.TabIndex = 3;
            this.lblGameSize.Text = "Game Size:";
            // 
            // btnCloseSettings
            // 
            this.btnCloseSettings.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCloseSettings.Location = new System.Drawing.Point(45, 35);
            this.btnCloseSettings.Name = "btnCloseSettings";
            this.btnCloseSettings.Size = new System.Drawing.Size(113, 101);
            this.btnCloseSettings.TabIndex = 2;
            this.btnCloseSettings.Text = "Close";
            this.btnCloseSettings.UseVisualStyleBackColor = true;
            this.btnCloseSettings.Click += new System.EventHandler(this.CloseButtonClick);
            // 
            // lblSettings
            // 
            this.lblSettings.AutoSize = true;
            this.lblSettings.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSettings.Location = new System.Drawing.Point(286, 23);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(276, 89);
            this.lblSettings.TabIndex = 0;
            this.lblSettings.Text = "Settings";
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(261, 447);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(282, 83);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.SettingsClick);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(260, 346);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(283, 84);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.PlayClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(164, -29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(521, 343);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(261, 548);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(282, 83);
            this.btnQuit.TabIndex = 6;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 675);
            this.Controls.Add(this.MenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Menu";
            this.Text = "Menu";
            this.MenuPanel.ResumeLayout(false);
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Panel Settings;
        private System.Windows.Forms.Button btnCloseSettings;
        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnSizeMedium;
        private System.Windows.Forms.Button btnSizeLarge;
        private System.Windows.Forms.Button btnSizeSmall;
        private System.Windows.Forms.Label lblGameSize;
        private System.Windows.Forms.Button btn;
    }
}