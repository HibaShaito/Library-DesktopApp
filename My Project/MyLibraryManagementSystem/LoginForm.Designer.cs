namespace MyLibraryManagementSystem
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.TopLoginPanel = new System.Windows.Forms.Panel();
            this.ClosingLabel = new System.Windows.Forms.Label();
            this.LibrarPicBox = new System.Windows.Forms.PictureBox();
            this.LabelWelcomeUser = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.LabelUserName = new System.Windows.Forms.Label();
            this.txtLoginName = new System.Windows.Forms.TextBox();
            this.LoginCheckboxPass = new System.Windows.Forms.CheckBox();
            this.LabelRegisterNow = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.TopLoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LibrarPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TopLoginPanel
            // 
            this.TopLoginPanel.BackColor = System.Drawing.Color.Maroon;
            this.TopLoginPanel.Controls.Add(this.ClosingLabel);
            this.TopLoginPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopLoginPanel.Location = new System.Drawing.Point(0, 0);
            this.TopLoginPanel.Name = "TopLoginPanel";
            this.TopLoginPanel.Size = new System.Drawing.Size(862, 63);
            this.TopLoginPanel.TabIndex = 0;
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
            this.ClosingLabel.MouseLeave += new System.EventHandler(this.ClosingLabel_MouseLeave);
            this.ClosingLabel.MouseHover += new System.EventHandler(this.ClosingLabel_MouseHover);
            // 
            // LibrarPicBox
            // 
            this.LibrarPicBox.BackColor = System.Drawing.Color.Transparent;
            this.LibrarPicBox.Image = global::MyLibraryManagementSystem.Properties.Resources.b41;
            this.LibrarPicBox.Location = new System.Drawing.Point(38, 60);
            this.LibrarPicBox.Name = "LibrarPicBox";
            this.LibrarPicBox.Size = new System.Drawing.Size(465, 229);
            this.LibrarPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LibrarPicBox.TabIndex = 1;
            this.LibrarPicBox.TabStop = false;
            // 
            // LabelWelcomeUser
            // 
            this.LabelWelcomeUser.AutoSize = true;
            this.LabelWelcomeUser.BackColor = System.Drawing.Color.Transparent;
            this.LabelWelcomeUser.Font = new System.Drawing.Font("Cooper Black", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWelcomeUser.Location = new System.Drawing.Point(135, 247);
            this.LabelWelcomeUser.Name = "LabelWelcomeUser";
            this.LabelWelcomeUser.Size = new System.Drawing.Size(293, 42);
            this.LabelWelcomeUser.TabIndex = 2;
            this.LabelWelcomeUser.Text = "Welcome User!";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Olive;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(31, 550);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(484, 57);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.Location = new System.Drawing.Point(31, 468);
            this.txtLoginPassword.Multiline = true;
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.Size = new System.Drawing.Size(484, 44);
            this.txtLoginPassword.TabIndex = 9;
            this.txtLoginPassword.TextChanged += new System.EventHandler(this.txtLoginPassword_TextChanged);
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.BackColor = System.Drawing.Color.Maroon;
            this.LabelPassword.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPassword.ForeColor = System.Drawing.Color.White;
            this.LabelPassword.Location = new System.Drawing.Point(32, 431);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(142, 34);
            this.LabelPassword.TabIndex = 8;
            this.LabelPassword.Text = "Password:";
            // 
            // LabelUserName
            // 
            this.LabelUserName.AutoSize = true;
            this.LabelUserName.BackColor = System.Drawing.Color.Maroon;
            this.LabelUserName.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUserName.ForeColor = System.Drawing.Color.White;
            this.LabelUserName.Location = new System.Drawing.Point(32, 327);
            this.LabelUserName.Name = "LabelUserName";
            this.LabelUserName.Size = new System.Drawing.Size(157, 34);
            this.LabelUserName.TabIndex = 10;
            this.LabelUserName.Text = "User Email:";
            // 
            // txtLoginName
            // 
            this.txtLoginName.Location = new System.Drawing.Point(31, 364);
            this.txtLoginName.Multiline = true;
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.Size = new System.Drawing.Size(484, 44);
            this.txtLoginName.TabIndex = 11;
            // 
            // LoginCheckboxPass
            // 
            this.LoginCheckboxPass.AutoSize = true;
            this.LoginCheckboxPass.BackColor = System.Drawing.Color.Transparent;
            this.LoginCheckboxPass.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginCheckboxPass.Location = new System.Drawing.Point(360, 518);
            this.LoginCheckboxPass.Name = "LoginCheckboxPass";
            this.LoginCheckboxPass.Size = new System.Drawing.Size(155, 26);
            this.LoginCheckboxPass.TabIndex = 12;
            this.LoginCheckboxPass.Text = "Show Password";
            this.LoginCheckboxPass.UseVisualStyleBackColor = false;
            this.LoginCheckboxPass.CheckedChanged += new System.EventHandler(this.LoginCheckboxPass_CheckedChanged);
            // 
            // LabelRegisterNow
            // 
            this.LabelRegisterNow.AutoSize = true;
            this.LabelRegisterNow.BackColor = System.Drawing.Color.Maroon;
            this.LabelRegisterNow.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRegisterNow.ForeColor = System.Drawing.Color.White;
            this.LabelRegisterNow.Location = new System.Drawing.Point(168, 650);
            this.LabelRegisterNow.Name = "LabelRegisterNow";
            this.LabelRegisterNow.Size = new System.Drawing.Size(210, 40);
            this.LabelRegisterNow.TabIndex = 13;
            this.LabelRegisterNow.Text = "Register Now";
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.Olive;
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(31, 694);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(484, 57);
            this.btnSignUp.TabIndex = 14;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyLibraryManagementSystem.Properties.Resources.b5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(862, 763);
            this.Controls.Add(this.LoginCheckboxPass);
            this.Controls.Add(this.LabelUserName);
            this.Controls.Add(this.txtLoginName);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.LabelWelcomeUser);
            this.Controls.Add(this.TopLoginPanel);
            this.Controls.Add(this.LibrarPicBox);
            this.Controls.Add(this.txtLoginPassword);
            this.Controls.Add(this.LabelRegisterNow);
            this.Controls.Add(this.btnSignUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.TopLoginPanel.ResumeLayout(false);
            this.TopLoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LibrarPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopLoginPanel;
        private System.Windows.Forms.Label ClosingLabel;
        private System.Windows.Forms.PictureBox LibrarPicBox;
        private System.Windows.Forms.Label LabelWelcomeUser;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.Label LabelUserName;
        private System.Windows.Forms.TextBox txtLoginName;
        private System.Windows.Forms.CheckBox LoginCheckboxPass;
        private System.Windows.Forms.Label LabelRegisterNow;
        private System.Windows.Forms.Button btnSignUp;
    }
}