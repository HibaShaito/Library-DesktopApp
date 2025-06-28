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
    
    public partial class MainAdmin : Form
    {
        public int check = 0;
        public MainAdmin()
        {
            InitializeComponent();
        }

        private void ClosingLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClosingLabel_MouseHover(object sender, EventArgs e)
        {
            ClosingLabel.ForeColor = Color.Bisque;
        }

        private void ClosingLabel_MouseLeave(object sender, EventArgs e)
        {
            ClosingLabel.ForeColor = Color.White;
        }

        private void LogOut_btn_Click(object sender, EventArgs e)
        {
           DialogResult checkMessage = new CheckMessage("Are you sure you want to LogOut?").ShowDialog(); 
           if(checkMessage== DialogResult.OK)
            {
                LoginForm login = new LoginForm();
                login.Show();
                this.Close();
            }

        }
        /*to change between user interfaces home addbooks returnbook issuebook on btn click*/
        private void btnHome_Click(object sender, EventArgs e)
        {
            home1.Visible = true;
            addBooks1.Visible = false;
            returnBooks1.Visible = false;
            issueBooks1.Visible = false;
        }

        private void btnAddBooks_Click(object sender, EventArgs e)
        {
            addBooks1.Visible = true;
            home1.Visible = false;
            returnBooks1.Visible = false;
            issueBooks1.Visible = false;
        }

        private void btnIssueBooks_Click(object sender, EventArgs e)
        {
            returnBooks1.Visible = false;
            home1.Visible = false;
            addBooks1.Visible = false;
            issueBooks1.Visible = true;
        }

        private void btnReturnBooks_Click(object sender, EventArgs e)
        {
            issueBooks1.Visible = false;
            home1.Visible = false;
            addBooks1.Visible = false;
            returnBooks1.Visible = true;  
        }
    }
}
