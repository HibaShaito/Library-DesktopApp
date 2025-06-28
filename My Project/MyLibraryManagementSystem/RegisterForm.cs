using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Security.Cryptography;

namespace MyLibraryManagementSystem
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        //creating data set library object
        LibraryDataSet library = new LibraryDataSet();
        //defining User table adapter user
        LibraryDataSetTableAdapters.UserTableAdapter user;

        public void Clear()
        {
            /*clearing text boxes*/
            txtRegisterEmail.Text = "";
            txtRegisterName.Text = "";
            txtRegisterPassword.Text = "";

        }
        private void AddUser()
        {
            //creating the user adapter
            user= new LibraryDataSetTableAdapters.UserTableAdapter();

            //filling the library User table using the user adapter
            user.Fill(library.User);
            bool emailExist = false;
            foreach (DataRow r in library.User)
            {
                if (r["email"].ToString().ToLower().Equals(txtRegisterEmail.Text.ToLower()))
                {
                    ErrorWarning exist = new ErrorWarning("Email Already Exist!");
                    exist.Show();
                    emailExist = true;
                    break;
                }
            }
            if(!emailExist)
            {
                /*add user*/
                user.Insert(txtRegisterName.Text, txtRegisterEmail.Text, txtRegisterPassword.Text, 2);
                InformationMsgForm registered = new InformationMsgForm("Email Registered Successfully!");
                registered.Show();
                library.AcceptChanges();
            }
            Clear();
        }
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            /*when user clicks register btn he will be moved back to login form*/
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void ClosingLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegisterCheckboxPass_CheckedChanged(object sender, EventArgs e)
        {

            /*password char masks or hides char as stars*/

            if (!RegisterCheckboxPass.Checked)
                txtRegisterPassword.PasswordChar = '*';
            else
            {
                txtRegisterPassword.PasswordChar = '\0';
            }
        }

        private void txtRegisterPassword_TextChanged(object sender, EventArgs e)
        {  
            /*password char masks or hides char as stars here is for the first time user
            types
            */
            if (!RegisterCheckboxPass.Checked)
                txtRegisterPassword.PasswordChar = '*';
           
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(txtRegisterEmail.Text=="" ||  txtRegisterName.Text==""
                || txtRegisterPassword.Text == "")
            {
                ErrorWarning errorWarning =  new ErrorWarning("Please Fill all blank fields");
                    errorWarning.Show();
                Clear();
            }
            else if(txtRegisterEmail.Text.Contains("@gmail.com")){
                AddUser();
            }
            else
            {
                ErrorWarning errorWarning = new ErrorWarning("Please  write a proper Email!");
                errorWarning.Show();
                Clear();
            }
          
        }
    }
}
