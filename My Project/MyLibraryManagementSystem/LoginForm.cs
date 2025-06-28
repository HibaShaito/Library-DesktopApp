using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLibraryManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        public void Clear()
        {
            /*clearing text boxes*/
            txtLoginName.Text = "";
            txtLoginPassword.Text = "";
        }
        //creating data set library object
        LibraryDataSet library = new LibraryDataSet();
        //defining User table adapter user
        LibraryDataSetTableAdapters.UserTableAdapter user;
        private void Check()
        {
            //creating the user adapter
            user = new LibraryDataSetTableAdapters.UserTableAdapter();
            //filling the library User table using the user adapter
            user.Fill(library.User);

            bool emailExist = false;
            bool correctpass = false;
            string role="";
            foreach (DataRow r in library.User)
            {
                if (r["email"].ToString().ToLower().Equals(txtLoginName.Text.ToLower()))
                {
                    role = r["role_id"].ToString();//learning whether he is admin or user
                    emailExist = true;
                    if (!r["password"].ToString().Equals(txtLoginPassword.Text))
                    {
                        ErrorWarning error = new ErrorWarning("Please Write Correct Password!");
                        error.Show();   
                        Clear();
                    }
                    else
                    {
                        correctpass = true;
                        break;
                    }   
                }

            }
            if (emailExist && correctpass)
            {
                DialogResult registered = new InformationMsgForm("Login Succesful!").ShowDialog();
                if (registered == DialogResult.OK)
                {


                    //will take us to another form based on whether you are user or admin
                    if (role.Equals("1"))//1 is admin
                    {
                        MainAdmin admin = new MainAdmin();
                        admin.Show();
                        this.Hide();
                    }
                    else
                    {
                        //open user page
                    }
                }
            }
            else if(!emailExist)
            {
                ErrorWarning error = new ErrorWarning("Please Sign Up First!");
                error.Show();
                Clear();
            }
        }
        /*Close x design when hover*/
        private void ClosingLabel_MouseHover(object sender, EventArgs e)
        {
            ClosingLabel.ForeColor = Color.Bisque;
        }

        private void ClosingLabel_MouseLeave(object sender, EventArgs e)
        {
            ClosingLabel.ForeColor = Color.White;
        }

        private void ClosingLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //when clicking Login btn
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            /*when user clicks register btn he will be moved to register form*/
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtLoginName.Text == "" || txtLoginPassword.Text == "")
            {
                ErrorWarning errorWarning = new ErrorWarning("Please Fill all blank fields");
                errorWarning.Show();
                Clear();
            }
            else if (txtLoginName.Text.ToLower().Contains("@gmail.com"))//contains ignore case sensitivity
            {
                Check();
            }
            else
            {
                ErrorWarning errorWarning = new ErrorWarning("Please  write a proper Email!");
                errorWarning.Show();
                Clear();
            }
        }

        private void LoginCheckboxPass_CheckedChanged(object sender, EventArgs e)
        {
            /*password char masks or hides char as stars*/

            if (!LoginCheckboxPass.Checked)
                txtLoginPassword.PasswordChar = '*';
            else
            {
                txtLoginPassword.PasswordChar = '\0';
            }
        }

        private void txtLoginPassword_TextChanged(object sender, EventArgs e)
        {
            /*password char masks or hides char as stars here is for the first time user
           types
           */
            if (!LoginCheckboxPass.Checked)
                txtLoginPassword.PasswordChar = '*';
        }
    }
}
