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
    public partial class ErrorWarning : Form
    {
        public ErrorWarning(string msg)
        {
            InitializeComponent();
            txtErrorMessage.Text = msg;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ErrorWarning_Load(object sender, EventArgs e)
        {

        }
    }
}
