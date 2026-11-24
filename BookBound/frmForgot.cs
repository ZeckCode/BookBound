using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BookBound
{
    public partial class frmForgot : Form
    {
        private string userEmail;
        private int verificationCode;
        public frmForgot()
        {
            InitializeComponent();
        }
        string Verify = "";
        string connectionstring = "Server=localhost; User ID=root; Password=''; Database=BookBound;";
        public static string Email { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLog form = new frmLog();
            this.Hide();
            form.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void SendCode()
        {
            userEmail = txtEmail.Text.Trim();
            Random rand = new Random();
            verificationCode = rand.Next(100000, 999999);
            frmForgot.Email = userEmail;

            connection();
        }
        private void SendVerificationCode(string recipientEmail, int code)
        {
            string senderEmail = "noreply.bookbound@gmail.com";  // Sender email address
            string senderPassword = "knsn zpki afxv nfiq";  // Use your Gmail App Password here

            try
            {
                // SMTP configuration for Gmail
                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential(senderEmail, senderPassword),
                    EnableSsl = true
                };

                // Prepare the email message
                var mailMessage = new MailMessage(senderEmail, recipientEmail)
                {
                    Subject = "Verification Code",
                    Body = $"Your verification code is: {code}. Please enter it to verify your email.",
                    IsBodyHtml = false  // Plain text email
                };

                // Send the email
                smtpClient.Send(mailMessage);

                // Optionally show a success message
                MessageBox.Show("Verification code sent successfully!");
                //lblMessage.ForeColor = System.Drawing.Color.Green;
            }
            catch (Exception ex)
            {
                // Optionally show an error message
                MessageBox.Show(ex.Message);
                //lblMessage.ForeColor = System.Drawing.Color.Red;
            }
        }
        public void connection()
        {
            MySqlConnection connection = new MySqlConnection(connectionstring);
            MySqlCommand cmd = new MySqlCommand();
            connection.Open();
            cmd.Parameters.AddWithValue("@Email", userEmail);
            string query = "SELECT COUNT(*) FROM accounts WHERE Email = @Email;";


            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                SendVerificationCode(userEmail, verificationCode);
                connection.Close();
            }
            else
            {
                MessageBox.Show("No Email found in the database.");
                connection.Close();
            }

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SendCode();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int Code = Convert.ToInt32(txtCode.Text.Trim());
            if (verificationCode == Code)
            {
                frmChangePass form = new frmChangePass();
                this.Hide();
                form.Show();
            }
            else
            {
                MessageBox.Show("Wrong code entered, please try again.");
            }
        }
    }
}
