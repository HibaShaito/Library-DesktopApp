namespace MyLibraryManagementSystem
{
    partial class LoadingForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingForm));
            this.LargePanelLoad = new System.Windows.Forms.Panel();
            this.MiniPanelLoad = new System.Windows.Forms.Panel();
            this.LibraryNameLabel = new System.Windows.Forms.Label();
            this.LibraryPictureBox = new System.Windows.Forms.PictureBox();
            this.LoadingTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.LibraryPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LargePanelLoad
            // 
            this.LargePanelLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LargePanelLoad.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LargePanelLoad.Location = new System.Drawing.Point(0, 501);
            this.LargePanelLoad.Name = "LargePanelLoad";
            this.LargePanelLoad.Size = new System.Drawing.Size(929, 33);
            this.LargePanelLoad.TabIndex = 0;
            // 
            // MiniPanelLoad
            // 
            this.MiniPanelLoad.BackColor = System.Drawing.Color.Gold;
            this.MiniPanelLoad.Location = new System.Drawing.Point(0, 501);
            this.MiniPanelLoad.Name = "MiniPanelLoad";
            this.MiniPanelLoad.Size = new System.Drawing.Size(61, 33);
            this.MiniPanelLoad.TabIndex = 0;
            // 
            // LibraryNameLabel
            // 
            this.LibraryNameLabel.AutoSize = true;
            this.LibraryNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.LibraryNameLabel.Font = new System.Drawing.Font("Cooper Black", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LibraryNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LibraryNameLabel.Location = new System.Drawing.Point(64, 243);
            this.LibraryNameLabel.Name = "LibraryNameLabel";
            this.LibraryNameLabel.Size = new System.Drawing.Size(553, 38);
            this.LibraryNameLabel.TabIndex = 1;
            this.LibraryNameLabel.Text = "My Library Management System";
            // 
            // LibraryPictureBox
            // 
            this.LibraryPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.LibraryPictureBox.Image = global::MyLibraryManagementSystem.Properties.Resources.b4;
            this.LibraryPictureBox.Location = new System.Drawing.Point(52, 58);
            this.LibraryPictureBox.Name = "LibraryPictureBox";
            this.LibraryPictureBox.Size = new System.Drawing.Size(565, 202);
            this.LibraryPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LibraryPictureBox.TabIndex = 2;
            this.LibraryPictureBox.TabStop = false;
            // 
            // LoadingTimer
            // 
            this.LoadingTimer.Enabled = true;
            this.LoadingTimer.Tick += new System.EventHandler(this.LoadingTimer_Tick);
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyLibraryManagementSystem.Properties.Resources.b1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(929, 534);
            this.Controls.Add(this.LibraryNameLabel);
            this.Controls.Add(this.MiniPanelLoad);
            this.Controls.Add(this.LargePanelLoad);
            this.Controls.Add(this.LibraryPictureBox);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Cyan;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoadingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Library";
            ((System.ComponentModel.ISupportInitialize)(this.LibraryPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel LargePanelLoad;
        private System.Windows.Forms.Panel MiniPanelLoad;
        private System.Windows.Forms.Label LibraryNameLabel;
        private System.Windows.Forms.PictureBox LibraryPictureBox;
        private System.Windows.Forms.Timer LoadingTimer;
    }
}

