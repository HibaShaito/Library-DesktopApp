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
    public partial class InformationMsgForm : Form
    {
        public InformationMsgForm(string msg)
        {
            InitializeComponent();
            txtInfoMessage.Text = msg;
        }

        private void InformationMsgForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
