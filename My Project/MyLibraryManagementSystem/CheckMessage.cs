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
    public partial class CheckMessage : Form
    {
        public CheckMessage(string msg)
        {
            InitializeComponent();
            txtVerifyMessage.Text = msg;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
           DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
