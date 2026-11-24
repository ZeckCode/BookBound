using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BookBound
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = !pictureBox4.Visible;
            pictureBox5.Visible = !pictureBox5.Visible;
            pictureBox6.Visible = !pictureBox6.Visible;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    

        private void frmHome_Load(object sender, EventArgs e)
        {

            MakePictureBoxRounded(pictureBox7, 40);
            MakePictureBoxRounded(pictureBox8, 40);
            MakePictureBoxRounded(pictureBox9, 40);
            MakePictureBoxRounded(pictureBox10, 40);
            MakePictureBoxRounded(pictureBox11, 40);
            MakePictureBoxRounded(pictureBox12, 40);
            MakePictureBoxRounded(pictureBox13, 40);
            MakePictureBoxRounded(pictureBox1, 40);
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            Stored.id = Stored.id - Stored.id;
            Stored.chapId = null;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmLib library = new frmLib();
            library.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {           
            frmStart start = new frmStart();
            start.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
        private void MakePictureBoxRounded(PictureBox pictureBox, int cornerRadius)
        {
            int width = pictureBox.Width;
            int height = pictureBox.Height;
            GraphicsPath path = new GraphicsPath();

            // Add a rounded rectangle path
            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90); // Top-left corner
            path.AddArc(width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90); // Top-right corner
            path.AddArc(width - cornerRadius, height - cornerRadius, cornerRadius, cornerRadius, 0, 90); // Bottom-right corner
            path.AddArc(0, height - cornerRadius, cornerRadius, cornerRadius, 90, 90); // Bottom-left corner
            path.CloseFigure();

            // Set the region of the PictureBox to the rounded rectangle
            pictureBox.Region = new Region(path);
        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            int id = 1;
            Stored.id = id;
            Stored.chapId = null;
            frmPage frmPage = new frmPage();
            frmPage.Show();
            this.Hide();
            Console.WriteLine($"Might book {Stored.id} chap {Stored.chapId}");
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            int id = 2;
            Stored.id = id;
            Stored.chapId = null;
            frmPage frmPage = new frmPage();
            frmPage.Show();
            this.Hide();
            Console.WriteLine($"Might book {Stored.id} chap {Stored.chapId}");
        }
    }
}
