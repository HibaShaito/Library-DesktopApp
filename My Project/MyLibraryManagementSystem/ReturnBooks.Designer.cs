namespace MyLibraryManagementSystem
{
    partial class ReturnBooks
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
            this.panelIssuedBooks = new System.Windows.Forms.Panel();
            this.dataGridViewCheckOut = new System.Windows.Forms.DataGridView();
            this.lblAllBooks = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panelIssuedBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCheckOut)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelIssuedBooks
            // 
            this.panelIssuedBooks.BackColor = System.Drawing.Color.White;
            this.panelIssuedBooks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelIssuedBooks.Controls.Add(this.dataGridViewCheckOut);
            this.panelIssuedBooks.Controls.Add(this.lblAllBooks);
            this.panelIssuedBooks.Location = new System.Drawing.Point(26, 131);
            this.panelIssuedBooks.Name = "panelIssuedBooks";
            this.panelIssuedBooks.Size = new System.Drawing.Size(881, 542);
            this.panelIssuedBooks.TabIndex = 1;
            // 
            // dataGridViewCheckOut
            // 
            this.dataGridViewCheckOut.AllowUserToAddRows = false;
            this.dataGridViewCheckOut.AllowUserToDeleteRows = false;
            this.dataGridViewCheckOut.BackgroundColor = System.Drawing.Color.LightGoldenrodYellow;
            this.dataGridViewCheckOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCheckOut.Location = new System.Drawing.Point(24, 56);
            this.dataGridViewCheckOut.Name = "dataGridViewCheckOut";
            this.dataGridViewCheckOut.RowHeadersWidth = 51;
            this.dataGridViewCheckOut.RowTemplate.Height = 24;
            this.dataGridViewCheckOut.Size = new System.Drawing.Size(834, 462);
            this.dataGridViewCheckOut.TabIndex = 1;
            // 
            // lblAllBooks
            // 
            this.lblAllBooks.AutoSize = true;
            this.lblAllBooks.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllBooks.Location = new System.Drawing.Point(313, 19);
            this.lblAllBooks.Name = "lblAllBooks";
            this.lblAllBooks.Size = new System.Drawing.Size(218, 34);
            this.lblAllBooks.TabIndex = 0;
            this.lblAllBooks.Text = "All Issued Books";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Maroon;
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(24, 26);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(546, 52);
            this.btnReturn.TabIndex = 41;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnReturn);
            this.panel1.Location = new System.Drawing.Point(26, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 108);
            this.panel1.TabIndex = 2;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Maroon;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(576, 27);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(282, 52);
            this.btnRefresh.TabIndex = 42;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ReturnBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelIssuedBooks);
            this.Name = "ReturnBooks";
            this.Size = new System.Drawing.Size(917, 703);
            this.panelIssuedBooks.ResumeLayout(false);
            this.panelIssuedBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCheckOut)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelIssuedBooks;
        private System.Windows.Forms.DataGridView dataGridViewCheckOut;
        private System.Windows.Forms.Label lblAllBooks;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRefresh;
    }
}
