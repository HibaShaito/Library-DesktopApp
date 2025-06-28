namespace MyLibraryManagementSystem
{
    partial class Home
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.ReturnedBookPanel = new System.Windows.Forms.Panel();
            this.ReturnedBooksNumber = new System.Windows.Forms.Label();
            this.ReturnedLabel = new System.Windows.Forms.Label();
            this.IssuedBookPanel = new System.Windows.Forms.Panel();
            this.IssuedBooksNumber = new System.Windows.Forms.Label();
            this.IssuedLabel = new System.Windows.Forms.Label();
            this.AvailableBookPanel = new System.Windows.Forms.Panel();
            this.AvailableBooksNumber = new System.Windows.Forms.Label();
            this.AvailableLabel = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.ReturnedBookPanel.SuspendLayout();
            this.IssuedBookPanel.SuspendLayout();
            this.AvailableBookPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel1.Controls.Add(this.ReturnedBookPanel);
            this.panel1.Controls.Add(this.IssuedBookPanel);
            this.panel1.Controls.Add(this.AvailableBookPanel);
            this.panel1.Location = new System.Drawing.Point(13, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 251);
            this.panel1.TabIndex = 0;
            // 
            // ReturnedBookPanel
            // 
            this.ReturnedBookPanel.BackColor = System.Drawing.Color.Maroon;
            this.ReturnedBookPanel.Controls.Add(this.ReturnedBooksNumber);
            this.ReturnedBookPanel.Controls.Add(this.ReturnedLabel);
            this.ReturnedBookPanel.Controls.Add(this.pictureBox3);
            this.ReturnedBookPanel.Location = new System.Drawing.Point(600, 16);
            this.ReturnedBookPanel.Name = "ReturnedBookPanel";
            this.ReturnedBookPanel.Size = new System.Drawing.Size(265, 218);
            this.ReturnedBookPanel.TabIndex = 3;
            // 
            // ReturnedBooksNumber
            // 
            this.ReturnedBooksNumber.AutoSize = true;
            this.ReturnedBooksNumber.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnedBooksNumber.ForeColor = System.Drawing.Color.White;
            this.ReturnedBooksNumber.Location = new System.Drawing.Point(105, 152);
            this.ReturnedBooksNumber.Name = "ReturnedBooksNumber";
            this.ReturnedBooksNumber.Size = new System.Drawing.Size(45, 52);
            this.ReturnedBooksNumber.TabIndex = 2;
            this.ReturnedBooksNumber.Text = "0";
            // 
            // ReturnedLabel
            // 
            this.ReturnedLabel.AutoSize = true;
            this.ReturnedLabel.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnedLabel.ForeColor = System.Drawing.Color.White;
            this.ReturnedLabel.Location = new System.Drawing.Point(30, 108);
            this.ReturnedLabel.Name = "ReturnedLabel";
            this.ReturnedLabel.Size = new System.Drawing.Size(211, 34);
            this.ReturnedLabel.TabIndex = 0;
            this.ReturnedLabel.Text = "Returned Books";
            // 
            // IssuedBookPanel
            // 
            this.IssuedBookPanel.BackColor = System.Drawing.Color.Maroon;
            this.IssuedBookPanel.Controls.Add(this.IssuedBooksNumber);
            this.IssuedBookPanel.Controls.Add(this.IssuedLabel);
            this.IssuedBookPanel.Controls.Add(this.pictureBox2);
            this.IssuedBookPanel.Location = new System.Drawing.Point(310, 16);
            this.IssuedBookPanel.Name = "IssuedBookPanel";
            this.IssuedBookPanel.Size = new System.Drawing.Size(265, 218);
            this.IssuedBookPanel.TabIndex = 3;
            // 
            // IssuedBooksNumber
            // 
            this.IssuedBooksNumber.AutoSize = true;
            this.IssuedBooksNumber.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssuedBooksNumber.ForeColor = System.Drawing.Color.White;
            this.IssuedBooksNumber.Location = new System.Drawing.Point(105, 152);
            this.IssuedBooksNumber.Name = "IssuedBooksNumber";
            this.IssuedBooksNumber.Size = new System.Drawing.Size(45, 52);
            this.IssuedBooksNumber.TabIndex = 2;
            this.IssuedBooksNumber.Text = "0";
            // 
            // IssuedLabel
            // 
            this.IssuedLabel.AutoSize = true;
            this.IssuedLabel.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssuedLabel.ForeColor = System.Drawing.Color.White;
            this.IssuedLabel.Location = new System.Drawing.Point(44, 108);
            this.IssuedLabel.Name = "IssuedLabel";
            this.IssuedLabel.Size = new System.Drawing.Size(180, 34);
            this.IssuedLabel.TabIndex = 0;
            this.IssuedLabel.Text = "Issued Books";
            // 
            // AvailableBookPanel
            // 
            this.AvailableBookPanel.BackColor = System.Drawing.Color.Maroon;
            this.AvailableBookPanel.Controls.Add(this.AvailableBooksNumber);
            this.AvailableBookPanel.Controls.Add(this.AvailableLabel);
            this.AvailableBookPanel.Controls.Add(this.pictureBox1);
            this.AvailableBookPanel.Location = new System.Drawing.Point(17, 16);
            this.AvailableBookPanel.Name = "AvailableBookPanel";
            this.AvailableBookPanel.Size = new System.Drawing.Size(265, 218);
            this.AvailableBookPanel.TabIndex = 1;
            // 
            // AvailableBooksNumber
            // 
            this.AvailableBooksNumber.AutoSize = true;
            this.AvailableBooksNumber.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableBooksNumber.ForeColor = System.Drawing.Color.White;
            this.AvailableBooksNumber.Location = new System.Drawing.Point(105, 152);
            this.AvailableBooksNumber.Name = "AvailableBooksNumber";
            this.AvailableBooksNumber.Size = new System.Drawing.Size(45, 52);
            this.AvailableBooksNumber.TabIndex = 2;
            this.AvailableBooksNumber.Text = "0";
            // 
            // AvailableLabel
            // 
            this.AvailableLabel.AutoSize = true;
            this.AvailableLabel.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableLabel.ForeColor = System.Drawing.Color.White;
            this.AvailableLabel.Location = new System.Drawing.Point(30, 108);
            this.AvailableLabel.Name = "AvailableLabel";
            this.AvailableLabel.Size = new System.Drawing.Size(207, 34);
            this.AvailableLabel.TabIndex = 0;
            this.AvailableLabel.Text = "Available Books";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::MyLibraryManagementSystem.Properties.Resources.the_book_of_secrets_by_shaynart_wallpaper_preview;
            this.pictureBox4.Location = new System.Drawing.Point(13, 272);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(889, 418);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MyLibraryManagementSystem.Properties.Resources.Returned;
            this.pictureBox3.Location = new System.Drawing.Point(32, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(205, 139);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MyLibraryManagementSystem.Properties.Resources.Issued;
            this.pictureBox2.Location = new System.Drawing.Point(50, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(174, 134);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyLibraryManagementSystem.Properties.Resources.Available2;
            this.pictureBox1.Location = new System.Drawing.Point(14, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel1);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(917, 703);
            this.panel1.ResumeLayout(false);
            this.ReturnedBookPanel.ResumeLayout(false);
            this.ReturnedBookPanel.PerformLayout();
            this.IssuedBookPanel.ResumeLayout(false);
            this.IssuedBookPanel.PerformLayout();
            this.AvailableBookPanel.ResumeLayout(false);
            this.AvailableBookPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AvailableLabel;
        private System.Windows.Forms.Panel AvailableBookPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label AvailableBooksNumber;
        private System.Windows.Forms.Panel ReturnedBookPanel;
        private System.Windows.Forms.Label ReturnedBooksNumber;
        private System.Windows.Forms.Label ReturnedLabel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel IssuedBookPanel;
        private System.Windows.Forms.Label IssuedBooksNumber;
        private System.Windows.Forms.Label IssuedLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}
