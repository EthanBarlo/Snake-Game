
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
            this.btnTeleportFalse = new System.Windows.Forms.Button();
            this.btnTeleportTrue = new System.Windows.Forms.Button();
            this.btnSizeMedium = new System.Windows.Forms.Button();
            this.btnSizeLarge = new System.Windows.Forms.Button();
            this.btnSizeSmall = new System.Windows.Forms.Button();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.SettingsBackground = new System.Windows.Forms.PictureBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.MenuBackground = new System.Windows.Forms.PictureBox();
            this.MenuPanel.SuspendLayout();
            this.Settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.Transparent;
            this.MenuPanel.Controls.Add(this.Settings);
            this.MenuPanel.Controls.Add(this.btnSettings);
            this.MenuPanel.Controls.Add(this.btnPlay);
            this.MenuPanel.Controls.Add(this.btnQuit);
            this.MenuPanel.Controls.Add(this.MenuBackground);
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(888, 674);
            this.MenuPanel.TabIndex = 6;
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.Transparent;
            this.Settings.Controls.Add(this.btnTeleportFalse);
            this.Settings.Controls.Add(this.btnTeleportTrue);
            this.Settings.Controls.Add(this.btnSizeMedium);
            this.Settings.Controls.Add(this.btnSizeLarge);
            this.Settings.Controls.Add(this.btnSizeSmall);
            this.Settings.Controls.Add(this.btnSaveSettings);
            this.Settings.Controls.Add(this.SettingsBackground);
            this.Settings.Location = new System.Drawing.Point(0, 0);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(886, 674);
            this.Settings.TabIndex = 6;
            this.Settings.Visible = false;
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
            this.btnSizeMedium.Click += new System.EventHandler(this.GameSizeChange);
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
            this.btnSizeLarge.Click += new System.EventHandler(this.GameSizeChange);
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
            this.btnSizeSmall.Click += new System.EventHandler(this.GameSizeChange);
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
            this.btnSettings.Font = new System.Drawing.Font("Arial", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(135)))), ((int)(((byte)(88)))));
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.Location = new System.Drawing.Point(227, 390);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(420, 100);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.SettingsClick);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Arial", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(135)))), ((int)(((byte)(88)))));
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.Location = new System.Drawing.Point(227, 280);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(420, 100);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.PlayClicked);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Transparent;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("Arial", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnQuit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(135)))), ((int)(((byte)(88)))));
            this.btnQuit.Image = ((System.Drawing.Image)(resources.GetObject("btnQuit.Image")));
            this.btnQuit.Location = new System.Drawing.Point(227, 500);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(420, 100);
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
            this.Settings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SettingsBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Panel Settings;
        private System.Windows.Forms.Button btnCloseSettings;
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
    }
}