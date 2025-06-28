namespace MyLibraryManagementSystem
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.RegisterCheckboxPass = new System.Windows.Forms.CheckBox();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.txtRegisterEmail = new System.Windows.Forms.TextBox();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.LabelWelcomeUser = new System.Windows.Forms.Label();
            this.LibrarPicBox = new System.Windows.Forms.PictureBox();
            this.txtRegisterPassword = new System.Windows.Forms.TextBox();
            this.LabelRegisterAccount = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.TopLoginPanel = new System.Windows.Forms.Panel();
            this.ClosingLabel = new System.Windows.Forms.Label();
            this.LabelUserName = new System.Windows.Forms.Label();
            this.txtRegisterName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.LibrarPicBox)).BeginInit();
            this.TopLoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegisterCheckboxPass
            // 
            this.RegisterCheckboxPass.AutoSize = true;
            this.RegisterCheckboxPass.BackColor = System.Drawing.Color.Transparent;
            this.RegisterCheckboxPass.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterCheckboxPass.Location = new System.Drawing.Point(360, 558);
            this.RegisterCheckboxPass.Name = "RegisterCheckboxPass";
            this.RegisterCheckboxPass.Size = new System.Drawing.Size(155, 26);
            this.RegisterCheckboxPass.TabIndex = 22;
            this.RegisterCheckboxPass.Text = "Show Password";
            this.RegisterCheckboxPass.UseVisualStyleBackColor = false;
            this.RegisterCheckboxPass.CheckedChanged += new System.EventHandler(this.RegisterCheckboxPass_CheckedChanged);
            // 
            // LabelEmail
            // 
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.BackColor = System.Drawing.Color.Maroon;
            this.LabelEmail.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEmail.ForeColor = System.Drawing.Color.White;
            this.LabelEmail.Location = new System.Drawing.Point(32, 303);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(92, 34);
            this.LabelEmail.TabIndex = 20;
            this.LabelEmail.Text = "Email:";
            // 
            // txtRegisterEmail
            // 
            this.txtRegisterEmail.Location = new System.Drawing.Point(31, 340);
            this.txtRegisterEmail.Multiline = true;
            this.txtRegisterEmail.Name = "txtRegisterEmail";
            this.txtRegisterEmail.Size = new System.Drawing.Size(484, 44);
            this.txtRegisterEmail.TabIndex = 21;
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.BackColor = System.Drawing.Color.Maroon;
            this.LabelPassword.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPassword.ForeColor = System.Drawing.Color.White;
            this.LabelPassword.Location = new System.Drawing.Point(32, 471);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(142, 34);
            this.LabelPassword.TabIndex = 18;
            this.LabelPassword.Text = "Password:";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Olive;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(31, 590);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(484, 57);
            this.btnRegister.TabIndex = 17;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // LabelWelcomeUser
            // 
            this.LabelWelcomeUser.AutoSize = true;
            this.LabelWelcomeUser.BackColor = System.Drawing.Color.Transparent;
            this.LabelWelcomeUser.Font = new System.Drawing.Font("Cooper Black", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWelcomeUser.Location = new System.Drawing.Point(87, 253);
            this.LabelWelcomeUser.Name = "LabelWelcomeUser";
            this.LabelWelcomeUser.Size = new System.Drawing.Size(363, 42);
            this.LabelWelcomeUser.TabIndex = 16;
            this.LabelWelcomeUser.Text = "Registration Form";
            // 
            // LibrarPicBox
            // 
            this.LibrarPicBox.BackColor = System.Drawing.Color.Transparent;
            this.LibrarPicBox.Image = global::MyLibraryManagementSystem.Properties.Resources.b41;
            this.LibrarPicBox.Location = new System.Drawing.Point(31, 66);
            this.LibrarPicBox.Name = "LibrarPicBox";
            this.LibrarPicBox.Size = new System.Drawing.Size(465, 229);
            this.LibrarPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LibrarPicBox.TabIndex = 15;
            this.LibrarPicBox.TabStop = false;
            // 
            // txtRegisterPassword
            // 
            this.txtRegisterPassword.Location = new System.Drawing.Point(31, 508);
            this.txtRegisterPassword.Multiline = true;
            this.txtRegisterPassword.Name = "txtRegisterPassword";
            this.txtRegisterPassword.Size = new System.Drawing.Size(484, 44);
            this.txtRegisterPassword.TabIndex = 19;
            this.txtRegisterPassword.TextChanged += new System.EventHandler(this.txtRegisterPassword_TextChanged);
            // 
            // LabelRegisterAccount
            // 
            this.LabelRegisterAccount.AutoSize = true;
            this.LabelRegisterAccount.BackColor = System.Drawing.Color.Maroon;
            this.LabelRegisterAccount.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRegisterAccount.ForeColor = System.Drawing.Color.White;
            this.LabelRegisterAccount.Location = new System.Drawing.Point(171, 663);
            this.LabelRegisterAccount.Name = "LabelRegisterAccount";
            this.LabelRegisterAccount.Size = new System.Drawing.Size(223, 34);
            this.LabelRegisterAccount.TabIndex = 23;
            this.LabelRegisterAccount.Text = "Register Account";
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.Olive;
            this.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignIn.FlatAppearance.BorderSize = 0;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.Location = new System.Drawing.Point(31, 700);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(484, 51);
            this.btnSignIn.TabIndex = 24;
            this.btnSignIn.Text = "SIGN IN";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // TopLoginPanel
            // 
            this.TopLoginPanel.BackColor = System.Drawing.Color.Maroon;
            this.TopLoginPanel.Controls.Add(this.ClosingLabel);
            this.TopLoginPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopLoginPanel.Location = new System.Drawing.Point(0, 0);
            this.TopLoginPanel.Name = "TopLoginPanel";
            this.TopLoginPanel.Size = new System.Drawing.Size(862, 63);
            this.TopLoginPanel.TabIndex = 25;
            // 
            // ClosingLabel
            // 
            this.ClosingLabel.AutoSize = true;
            this.ClosingLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClosingLabel.Font = new System.Drawing.Font("Cooper Black", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClosingLabel.ForeColor = System.Drawing.Color.White;
            this.ClosingLabel.Location = new System.Drawing.Point(786, 9);
            this.ClosingLabel.Name = "ClosingLabel";
            this.ClosingLabel.Size = new System.Drawing.Size(47, 42);
            this.ClosingLabel.TabIndex = 0;
            this.ClosingLabel.Text = "X";
            this.ClosingLabel.Click += new System.EventHandler(this.ClosingLabel_Click);
            // 
            // LabelUserName
            // 
            this.LabelUserName.AutoSize = true;
            this.LabelUserName.BackColor = System.Drawing.Color.Maroon;
            this.LabelUserName.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUserName.ForeColor = System.Drawing.Color.White;
            this.LabelUserName.Location = new System.Drawing.Point(32, 387);
            this.LabelUserName.Name = "LabelUserName";
            this.LabelUserName.Size = new System.Drawing.Size(163, 34);
            this.LabelUserName.TabIndex = 26;
            this.LabelUserName.Text = "User Name:";
            // 
            // txtRegisterName
            // 
            this.txtRegisterName.Location = new System.Drawing.Point(31, 424);
            this.txtRegisterName.Multiline = true;
            this.txtRegisterName.Name = "txtRegisterName";
            this.txtRegisterName.Size = new System.Drawing.Size(484, 44);
            this.txtRegisterName.TabIndex = 27;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyLibraryManagementSystem.Properties.Resources.b5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(862, 763);
            this.Controls.Add(this.LabelUserName);
            this.Controls.Add(this.txtRegisterName);
            this.Controls.Add(this.TopLoginPanel);
            this.Controls.Add(this.RegisterCheckboxPass);
            this.Controls.Add(this.LabelEmail);
            this.Controls.Add(this.txtRegisterEmail);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.LabelWelcomeUser);
            this.Controls.Add(this.LibrarPicBox);
            this.Controls.Add(this.txtRegisterPassword);
            this.Controls.Add(this.LabelRegisterAccount);
            this.Controls.Add(this.btnSignIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)(this.LibrarPicBox)).EndInit();
            this.TopLoginPanel.ResumeLayout(false);
            this.TopLoginPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox RegisterCheckboxPass;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.TextBox txtRegisterEmail;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label LabelWelcomeUser;
        private System.Windows.Forms.PictureBox LibrarPicBox;
        private System.Windows.Forms.TextBox txtRegisterPassword;
        private System.Windows.Forms.Label LabelRegisterAccount;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Panel TopLoginPanel;
        private System.Windows.Forms.Label ClosingLabel;
        private System.Windows.Forms.Label LabelUserName;
        private System.Windows.Forms.TextBox txtRegisterName;
    }
}