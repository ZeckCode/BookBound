using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace BookBound
{
    public partial class frmLog : Form
    {
        public frmLog()
        {
            InitializeComponent();
        }

        string connectionstring = "Server=localhost; User ID=root; Password=''; Database=BookBound;";
        private void btnBack_Click(object sender, EventArgs e)
        {
            frmStart start = new frmStart();
            start.Show();
            this.Hide();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            MySqlConnection connection = new MySqlConnection(connectionstring);
            MySqlCommand cmd = new MySqlCommand();
            connection.Open();
            if (connection.State == ConnectionState.Open)
            {
                //initialization
                string username = txtUsername.Text,
                       password = txtPassword.Text;

                //parameters
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                string query = "SELECT * FROM accounts WHERE Name = @username AND Password = @password";
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;
                MySqlDataReader reader = cmd.ExecuteReader();

                //checks if username and password tugma idk
                if (reader.HasRows)

                {                    
                    frmHome home = new frmHome();
                    home.Show();
                    this.Hide();
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Wrong username or password.");
                    connection.Close();
                }

            }
            else
            {
                MessageBox.Show("Wrong Password or Username");
                connection.Close();
            }
        }

        private void btnForgot_Click(object sender, EventArgs e)
        {
            frmForgot form = new frmForgot();
            this.Hide();
            form.Show();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
