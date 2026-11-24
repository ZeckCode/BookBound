using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace BookBound
{
    public partial class frmEnterCode : Form
    {
        string Verify = "";
        string connectionstring = "Server=localhost; User ID=root; Password=''; Database=BookBound;";
        private string email;
        private int expectedCode;
        public frmEnterCode(string userEmail, int verificationCode)
        {
            InitializeComponent();
            email = userEmail;
            expectedCode = verificationCode;
            Verify = verificationCode.ToString();
            lblEmail.Text = $"{email}";
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            string userInputCode = txtCode.Text;
            if (userInputCode == expectedCode.ToString())
            {
                MessageBox.Show("Code verified successfully!");
            }
            else
            {
                MessageBox.Show("Incorrect code, please try again.");
            }
        }

        private void btnContinue_Click_1(object sender, EventArgs e)
        {
            register();
        }
        private void register()
        {
            string username = frmReg.username,
                   email = frmReg.email,
                   password = frmReg.password;
            string default_pename = "Anonymous";
            if (Verify != txtCode.Text)
            {
                MessageBox.Show("wrong code please try again.");
            }
            else
            {
                MySqlConnection connection = new MySqlConnection(connectionstring);
                MySqlCommand cmd = new MySqlCommand();
                connection.Open();
                try
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@penname", default_pename);

                    string query = "INSERT INTO accounts(Name, Email, Password, PenName)" + "VALUES(@username, @email, @password, @penname);";
                    cmd.CommandText = query;
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connection;

                    cmd.ExecuteNonQuery();                   
                    connection.Close();
                    this.Hide();
                    frmStart form = new frmStart();
                    form.Show();

                }
                catch (MySqlException e)
                {
                    MessageBox.Show("error: " + e.Message);
                    connection.Close();
                }
            }
            
            }
        
        }
    }

