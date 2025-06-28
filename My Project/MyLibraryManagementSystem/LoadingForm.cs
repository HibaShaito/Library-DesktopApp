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
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }

        private void LoadingTimer_Tick(object sender, EventArgs e)
        {
            /*increasing the size of the mini panel until it becomes
             of same size as large panel
            to look as loading
            */
            MiniPanelLoad.Width += 10;
            if(MiniPanelLoad.Width>=LargePanelLoad.Width)
            {
                LoadingTimer.Stop();
                /*after laoding done a new form appears and the 
                 load one will be hidden*/
                LoginForm Form1= new LoginForm();
                Form1.Show();
                this.Hide();
            }
        }
    }
}
