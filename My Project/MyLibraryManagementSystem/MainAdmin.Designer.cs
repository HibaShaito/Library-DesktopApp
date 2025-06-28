namespace MyLibraryManagementSystem
{
    partial class MainAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainAdmin));
            this.TopLoginPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ClosingLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.LogOut_btn = new System.Windows.Forms.Button();
            this.btnReturnBooks = new System.Windows.Forms.Button();
            this.btnIssueBooks = new System.Windows.Forms.Button();
            this.btnAddBooks = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.greet_Label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UserControlPanel = new System.Windows.Forms.Panel();
            this.returnBooks1 = new MyLibraryManagementSystem.ReturnBooks();
            this.issueBooks1 = new MyLibraryManagementSystem.IssueBooks();
            this.addBooks1 = new MyLibraryManagementSystem.AddBooks();
            this.home1 = new MyLibraryManagementSystem.Home();
            this.TopLoginPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.UserControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopLoginPanel
            // 
            this.TopLoginPanel.BackColor = System.Drawing.Color.Maroon;
            this.TopLoginPanel.Controls.Add(this.label1);
            this.TopLoginPanel.Controls.Add(this.ClosingLabel);
            this.TopLoginPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopLoginPanel.Location = new System.Drawing.Point(0, 0);
            this.TopLoginPanel.Name = "TopLoginPanel";
            this.TopLoginPanel.Size = new System.Drawing.Size(1306, 56);
            this.TopLoginPanel.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Library Managment System | Admin Page";
            // 
            // ClosingLabel
            // 
            this.ClosingLabel.AutoSize = true;
            this.ClosingLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClosingLabel.Font = new System.Drawing.Font("Cooper Black", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClosingLabel.ForeColor = System.Drawing.Color.White;
            this.ClosingLabel.Location = new System.Drawing.Point(1251, 8);
            this.ClosingLabel.Name = "ClosingLabel";
            this.ClosingLabel.Size = new System.Drawing.Size(43, 38);
            this.ClosingLabel.TabIndex = 0;
            this.ClosingLabel.Text = "X";
            this.ClosingLabel.Click += new System.EventHandler(this.ClosingLabel_Click);
            this.ClosingLabel.MouseLeave += new System.EventHandler(this.ClosingLabel_MouseLeave);
            this.ClosingLabel.MouseHover += new System.EventHandler(this.ClosingLabel_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.LogOut_btn);
            this.panel1.Controls.Add(this.btnReturnBooks);
            this.panel1.Controls.Add(this.btnIssueBooks);
            this.panel1.Controls.Add(this.btnAddBooks);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.greet_Label);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 703);
            this.panel1.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(112, 636);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 34);
            this.label3.TabIndex = 7;
            this.label3.Text = "Log Out";
            // 
            // LogOut_btn
            // 
            this.LogOut_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOut_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightPink;
            this.LogOut_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.LogOut_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOut_btn.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut_btn.ForeColor = System.Drawing.Color.White;
            this.LogOut_btn.Image = global::MyLibraryManagementSystem.Properties.Resources.Logout;
            this.LogOut_btn.Location = new System.Drawing.Point(17, 604);
            this.LogOut_btn.Name = "LogOut_btn";
            this.LogOut_btn.Size = new System.Drawing.Size(89, 81);
            this.LogOut_btn.TabIndex = 6;
            this.LogOut_btn.UseVisualStyleBackColor = true;
            this.LogOut_btn.Click += new System.EventHandler(this.LogOut_btn_Click);
            // 
            // btnReturnBooks
            // 
            this.btnReturnBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturnBooks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightPink;
            this.btnReturnBooks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnReturnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnBooks.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnBooks.ForeColor = System.Drawing.Color.White;
            this.btnReturnBooks.Image = global::MyLibraryManagementSystem.Properties.Resources.Return_Book;
            this.btnReturnBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturnBooks.Location = new System.Drawing.Point(17, 483);
            this.btnReturnBooks.Name = "btnReturnBooks";
            this.btnReturnBooks.Size = new System.Drawing.Size(352, 79);
            this.btnReturnBooks.TabIndex = 5;
            this.btnReturnBooks.Text = "   RETURN BOOKS";
            this.btnReturnBooks.UseVisualStyleBackColor = true;
            this.btnReturnBooks.Click += new System.EventHandler(this.btnReturnBooks_Click);
            // 
            // btnIssueBooks
            // 
            this.btnIssueBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIssueBooks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightPink;
            this.btnIssueBooks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnIssueBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssueBooks.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueBooks.ForeColor = System.Drawing.Color.White;
            this.btnIssueBooks.Image = global::MyLibraryManagementSystem.Properties.Resources.book4;
            this.btnIssueBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssueBooks.Location = new System.Drawing.Point(17, 398);
            this.btnIssueBooks.Name = "btnIssueBooks";
            this.btnIssueBooks.Size = new System.Drawing.Size(352, 79);
            this.btnIssueBooks.TabIndex = 4;
            this.btnIssueBooks.Text = " ISSUE BOOKS";
            this.btnIssueBooks.UseVisualStyleBackColor = true;
            this.btnIssueBooks.Click += new System.EventHandler(this.btnIssueBooks_Click);
            // 
            // btnAddBooks
            // 
            this.btnAddBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBooks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightPink;
            this.btnAddBooks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnAddBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBooks.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBooks.ForeColor = System.Drawing.Color.White;
            this.btnAddBooks.Image = global::MyLibraryManagementSystem.Properties.Resources.ADD;
            this.btnAddBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddBooks.Location = new System.Drawing.Point(17, 313);
            this.btnAddBooks.Name = "btnAddBooks";
            this.btnAddBooks.Size = new System.Drawing.Size(352, 79);
            this.btnAddBooks.TabIndex = 3;
            this.btnAddBooks.Text = " ADD BOOKS";
            this.btnAddBooks.UseVisualStyleBackColor = true;
            this.btnAddBooks.Click += new System.EventHandler(this.btnAddBooks_Click);
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightPink;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::MyLibraryManagementSystem.Properties.Resources.DashBoard;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(17, 228);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(352, 79);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // greet_Label
            // 
            this.greet_Label.AutoSize = true;
            this.greet_Label.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greet_Label.ForeColor = System.Drawing.Color.White;
            this.greet_Label.Location = new System.Drawing.Point(109, 183);
            this.greet_Label.Name = "greet_Label";
            this.greet_Label.Size = new System.Drawing.Size(166, 21);
            this.greet_Label.TabIndex = 1;
            this.greet_Label.Text = "Welcome Admin!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyLibraryManagementSystem.Properties.Resources.b4;
            this.pictureBox1.Location = new System.Drawing.Point(136, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // UserControlPanel
            // 
            this.UserControlPanel.Controls.Add(this.home1);
            this.UserControlPanel.Controls.Add(this.addBooks1);
            this.UserControlPanel.Controls.Add(this.issueBooks1);
            this.UserControlPanel.Controls.Add(this.returnBooks1);
            this.UserControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserControlPanel.Location = new System.Drawing.Point(389, 56);
            this.UserControlPanel.Name = "UserControlPanel";
            this.UserControlPanel.Size = new System.Drawing.Size(917, 703);
            this.UserControlPanel.TabIndex = 28;
            // 
            // returnBooks1
            // 
            this.returnBooks1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.returnBooks1.Location = new System.Drawing.Point(0, 0);
            this.returnBooks1.Name = "returnBooks1";
            this.returnBooks1.Size = new System.Drawing.Size(917, 703);
            this.returnBooks1.TabIndex = 0;
            // 
            // issueBooks1
            // 
            this.issueBooks1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.issueBooks1.Location = new System.Drawing.Point(-3, 0);
            this.issueBooks1.Name = "issueBooks1";
            this.issueBooks1.Size = new System.Drawing.Size(917, 703);
            this.issueBooks1.TabIndex = 1;
            // 
            // addBooks1
            // 
            this.addBooks1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.addBooks1.Location = new System.Drawing.Point(0, -3);
            this.addBooks1.Name = "addBooks1";
            this.addBooks1.Size = new System.Drawing.Size(917, 703);
            this.addBooks1.TabIndex = 2;
            // 
            // home1
            // 
            this.home1.BackColor = System.Drawing.Color.White;
            this.home1.Location = new System.Drawing.Point(0, 0);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(917, 703);
            this.home1.TabIndex = 3;
            // 
            // MainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 759);
            this.Controls.Add(this.UserControlPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TopLoginPanel);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main  Page";
            this.TopLoginPanel.ResumeLayout(false);
            this.TopLoginPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.UserControlPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopLoginPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ClosingLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label greet_Label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnAddBooks;
        private System.Windows.Forms.Button btnReturnBooks;
        private System.Windows.Forms.Button btnIssueBooks;
        private System.Windows.Forms.Button LogOut_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel UserControlPanel;
        private Home home1;
        private AddBooks addBooks1;
        private IssueBooks issueBooks1;
        private ReturnBooks returnBooks1;
    }
}