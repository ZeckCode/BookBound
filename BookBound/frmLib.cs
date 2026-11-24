using System;
using System.Windows.Forms;

namespace BookBound
{
    public partial class frmLib : Form
    {
        public frmLib()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            home.Show();
            this.Close();
        }
    }
}
