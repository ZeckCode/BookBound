using System;
using System.Windows.Forms;

namespace BookBound
{
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            frmReg registerform = new frmReg();
            registerform.Show();
            this.Hide();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            frmLog loginform = new frmLog();
            loginform.Show();
            this.Hide();
        }
    }
}
