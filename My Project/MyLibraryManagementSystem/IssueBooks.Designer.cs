namespace MyLibraryManagementSystem
{
    partial class IssueBooks
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbEmail = new System.Windows.Forms.ComboBox();
            this.nudQtt = new System.Windows.Forms.NumericUpDown();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.pictureBook = new System.Windows.Forms.PictureBox();
            this.dtpReturnDAte = new System.Windows.Forms.DateTimePicker();
            this.dtpIssueDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.cbBook = new System.Windows.Forms.ComboBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lbl_statues = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_Qtt = new System.Windows.Forms.Label();
            this.lbl_Author = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBook = new System.Windows.Forms.Label();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet = new MyLibraryManagementSystem.LibraryDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewCheckOut = new System.Windows.Forms.DataGridView();
            this.bookTableAdapter = new MyLibraryManagementSystem.LibraryDataSetTableAdapters.BookTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCheckOut)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cbEmail);
            this.panel1.Controls.Add(this.nudQtt);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnBorrow);
            this.panel1.Controls.Add(this.pictureBook);
            this.panel1.Controls.Add(this.dtpReturnDAte);
            this.panel1.Controls.Add(this.dtpIssueDate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtAuthor);
            this.panel1.Controls.Add(this.cbBook);
            this.panel1.Controls.Add(this.txtStatus);
            this.panel1.Controls.Add(this.lbl_statues);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lbl_Qtt);
            this.panel1.Controls.Add(this.lbl_Author);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblBook);
            this.panel1.Location = new System.Drawing.Point(19, 470);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 202);
            this.panel1.TabIndex = 0;
            // 
            // cbEmail
            // 
            this.cbEmail.FormattingEnabled = true;
            this.cbEmail.Location = new System.Drawing.Point(401, 13);
            this.cbEmail.Name = "cbEmail";
            this.cbEmail.Size = new System.Drawing.Size(239, 24);
            this.cbEmail.TabIndex = 45;
            this.cbEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbBook_KeyPress);
            // 
            // nudQtt
            // 
            this.nudQtt.Location = new System.Drawing.Point(87, 47);
            this.nudQtt.Name = "nudQtt";
            this.nudQtt.Size = new System.Drawing.Size(225, 22);
            this.nudQtt.TabIndex = 44;
            this.nudQtt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Maroon;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(354, 133);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(335, 52);
            this.btnUpdate.TabIndex = 41;
            this.btnUpdate.Text = "Update ";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnBorrow
            // 
            this.btnBorrow.BackColor = System.Drawing.Color.Maroon;
            this.btnBorrow.FlatAppearance.BorderSize = 0;
            this.btnBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrow.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrow.ForeColor = System.Drawing.Color.White;
            this.btnBorrow.Location = new System.Drawing.Point(10, 133);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(327, 52);
            this.btnBorrow.TabIndex = 40;
            this.btnBorrow.Text = "Borrow";
            this.btnBorrow.UseVisualStyleBackColor = false;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // pictureBook
            // 
            this.pictureBook.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.pictureBook.Location = new System.Drawing.Point(709, 20);
            this.pictureBook.Name = "pictureBook";
            this.pictureBook.Size = new System.Drawing.Size(133, 148);
            this.pictureBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBook.TabIndex = 39;
            this.pictureBook.TabStop = false;
            // 
            // dtpReturnDAte
            // 
            this.dtpReturnDAte.Location = new System.Drawing.Point(401, 105);
            this.dtpReturnDAte.Name = "dtpReturnDAte";
            this.dtpReturnDAte.Size = new System.Drawing.Size(239, 22);
            this.dtpReturnDAte.TabIndex = 38;
            // 
            // dtpIssueDate
            // 
            this.dtpIssueDate.Enabled = false;
            this.dtpIssueDate.Location = new System.Drawing.Point(401, 76);
            this.dtpIssueDate.Name = "dtpIssueDate";
            this.dtpIssueDate.Size = new System.Drawing.Size(239, 22);
            this.dtpIssueDate.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(338, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 36;
            this.label2.Text = "Return:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(339, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 21);
            this.label3.TabIndex = 35;
            this.label3.Text = "Issue:";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Enabled = false;
            this.txtAuthor.Location = new System.Drawing.Point(87, 77);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(225, 22);
            this.txtAuthor.TabIndex = 34;
            // 
            // cbBook
            // 
            this.cbBook.FormattingEnabled = true;
            this.cbBook.Location = new System.Drawing.Point(87, 15);
            this.cbBook.Name = "cbBook";
            this.cbBook.Size = new System.Drawing.Size(225, 24);
            this.cbBook.TabIndex = 33;
            this.cbBook.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbBook_KeyPress);
            // 
            // txtStatus
            // 
            this.txtStatus.Enabled = false;
            this.txtStatus.Location = new System.Drawing.Point(87, 102);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(225, 22);
            this.txtStatus.TabIndex = 32;
            // 
            // lbl_statues
            // 
            this.lbl_statues.AutoSize = true;
            this.lbl_statues.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_statues.Location = new System.Drawing.Point(6, 102);
            this.lbl_statues.Name = "lbl_statues";
            this.lbl_statues.Size = new System.Drawing.Size(63, 21);
            this.lbl_statues.TabIndex = 31;
            this.lbl_statues.Text = "Status:";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(401, 46);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(239, 22);
            this.txtName.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(338, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 21);
            this.label6.TabIndex = 29;
            this.label6.Text = "Email:";
            // 
            // lbl_Qtt
            // 
            this.lbl_Qtt.AutoSize = true;
            this.lbl_Qtt.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Qtt.Location = new System.Drawing.Point(6, 50);
            this.lbl_Qtt.Name = "lbl_Qtt";
            this.lbl_Qtt.Size = new System.Drawing.Size(79, 21);
            this.lbl_Qtt.TabIndex = 27;
            this.lbl_Qtt.Text = "Quantity:";
            // 
            // lbl_Author
            // 
            this.lbl_Author.AutoSize = true;
            this.lbl_Author.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Author.Location = new System.Drawing.Point(6, 77);
            this.lbl_Author.Name = "lbl_Author";
            this.lbl_Author.Size = new System.Drawing.Size(66, 21);
            this.lbl_Author.TabIndex = 25;
            this.lbl_Author.Text = "Author:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(338, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 21);
            this.label5.TabIndex = 21;
            this.label5.Text = "Name:";
            // 
            // lblBook
            // 
            this.lblBook.AutoSize = true;
            this.lblBook.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBook.Location = new System.Drawing.Point(6, 19);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(52, 21);
            this.lblBook.TabIndex = 19;
            this.lblBook.Text = "Book:";
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
            this.bookBindingSource.DataSource = this.libraryDataSetBindingSource;
            // 
            // libraryDataSetBindingSource
            // 
            this.libraryDataSetBindingSource.DataSource = this.libraryDataSet;
            this.libraryDataSetBindingSource.Position = 0;
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "LibraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dataGridViewCheckOut);
            this.panel2.Location = new System.Drawing.Point(19, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(879, 435);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "All Issued Books";
            // 
            // dataGridViewCheckOut
            // 
            this.dataGridViewCheckOut.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dataGridViewCheckOut.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCheckOut.BackgroundColor = System.Drawing.Color.LightGoldenrodYellow;
            this.dataGridViewCheckOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCheckOut.Location = new System.Drawing.Point(21, 50);
            this.dataGridViewCheckOut.Name = "dataGridViewCheckOut";
            this.dataGridViewCheckOut.RowHeadersWidth = 51;
            this.dataGridViewCheckOut.RowTemplate.Height = 24;
            this.dataGridViewCheckOut.Size = new System.Drawing.Size(840, 364);
            this.dataGridViewCheckOut.TabIndex = 0;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // IssueBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "IssueBooks";
            this.Size = new System.Drawing.Size(917, 703);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCheckOut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewCheckOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_Qtt;
        private System.Windows.Forms.Label lbl_Author;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.Label lbl_statues;
        private System.Windows.Forms.ComboBox cbBook;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.DateTimePicker dtpReturnDAte;
        private System.Windows.Forms.DateTimePicker dtpIssueDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBook;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.NumericUpDown nudQtt;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cbEmail;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private System.Windows.Forms.BindingSource libraryDataSetBindingSource;
        private LibraryDataSet libraryDataSet;
        private LibraryDataSetTableAdapters.BookTableAdapter bookTableAdapter;
    }
}
