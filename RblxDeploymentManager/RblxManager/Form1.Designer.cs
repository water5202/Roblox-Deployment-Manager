namespace RblxManager
{
    partial class UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI));
            this.label1 = new System.Windows.Forms.Label();
            this.ClientSettings = new System.Windows.Forms.Button();
            this.RblxDownloader = new System.Windows.Forms.Button();
            this.GithubPage = new System.Windows.Forms.Button();
            this.LABELPROGRAM = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // ClientSettings
            // 
            this.ClientSettings.BackColor = System.Drawing.Color.Transparent;
            this.ClientSettings.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ClientSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClientSettings.ForeColor = System.Drawing.Color.White;
            this.ClientSettings.Location = new System.Drawing.Point(12, 56);
            this.ClientSettings.Name = "ClientSettings";
            this.ClientSettings.Size = new System.Drawing.Size(138, 41);
            this.ClientSettings.TabIndex = 1;
            this.ClientSettings.Text = "Roblox Version";
            this.ClientSettings.UseVisualStyleBackColor = false;
            this.ClientSettings.Click += new System.EventHandler(this.ClientSettings_Click);
            // 
            // RblxDownloader
            // 
            this.RblxDownloader.BackColor = System.Drawing.Color.Transparent;
            this.RblxDownloader.FlatAppearance.BorderSize = 0;
            this.RblxDownloader.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RblxDownloader.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RblxDownloader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RblxDownloader.ForeColor = System.Drawing.Color.Transparent;
            this.RblxDownloader.Location = new System.Drawing.Point(12, 9);
            this.RblxDownloader.Name = "RblxDownloader";
            this.RblxDownloader.Size = new System.Drawing.Size(138, 41);
            this.RblxDownloader.TabIndex = 2;
            this.RblxDownloader.Text = "Latest Release";
            this.RblxDownloader.UseVisualStyleBackColor = false;
            this.RblxDownloader.Click += new System.EventHandler(this.RblxDownloader_Click);
            // 
            // GithubPage
            // 
            this.GithubPage.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.GithubPage.FlatAppearance.BorderSize = 0;
            this.GithubPage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GithubPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GithubPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GithubPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GithubPage.ForeColor = System.Drawing.Color.Transparent;
            this.GithubPage.Location = new System.Drawing.Point(354, 178);
            this.GithubPage.Name = "GithubPage";
            this.GithubPage.Size = new System.Drawing.Size(93, 41);
            this.GithubPage.TabIndex = 3;
            this.GithubPage.Text = "About";
            this.GithubPage.UseVisualStyleBackColor = true;
            this.GithubPage.Click += new System.EventHandler(this.GithubPage_Click);
            // 
            // LABELPROGRAM
            // 
            this.LABELPROGRAM.AutoSize = true;
            this.LABELPROGRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABELPROGRAM.ForeColor = System.Drawing.Color.Transparent;
            this.LABELPROGRAM.Location = new System.Drawing.Point(200, 9);
            this.LABELPROGRAM.Name = "LABELPROGRAM";
            this.LABELPROGRAM.Size = new System.Drawing.Size(247, 20);
            this.LABELPROGRAM.TabIndex = 4;
            this.LABELPROGRAM.Text = "Roblox Deployment Manager v1.0";
            this.LABELPROGRAM.Click += new System.EventHandler(this.LABELPROGRAM_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::RblxManager.Properties.Resources.icons8_arrow_down_50;
            this.pictureBox1.Location = new System.Drawing.Point(396, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 50);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(462, 231);
            this.Controls.Add(this.GithubPage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LABELPROGRAM);
            this.Controls.Add(this.RblxDownloader);
            this.Controls.Add(this.ClientSettings);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UI";
            this.Opacity = 0.7D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roblox Deployment Manager";
            this.Load += new System.EventHandler(this.UI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ClientSettings;
        private System.Windows.Forms.Button RblxDownloader;
        private System.Windows.Forms.Button GithubPage;
        private System.Windows.Forms.Label LABELPROGRAM;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

