using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BookBound
{
    public partial class frmChangePass : Form
    {
        public frmChangePass()
        {
            InitializeComponent();
        }
        string connectionstring = "Server=localhost; User ID=root; Password=''; Database=BookBound;";
        string password = "";
        private void btnConfirm_Click(object sender, EventArgs e)
        {

            NewPassword();
            frmLog form = new frmLog();
            this.Hide();
            form.Show();
        }
        private void NewPassword()
        {
            string newpassword = txtNew.Text.Trim();
            password = txtConfirm.Text.Trim();

            try
            {
                MySqlConnection connection = new MySqlConnection(connectionstring);
                MySqlCommand cmd = new MySqlCommand();
                connection.Open();
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@Email", frmForgot.Email);
                string query = "UPDATE Accounts SET Password = @password WHERE Email = @Email;";


                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;
                

                if (newpassword == password)
                {
                    
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully changed password.");
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Password does not match.");
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured" + ex.Message);
            }
            
        }

        private void frmChangePass_Load(object sender, EventArgs e)
        {

        }
    }
}
