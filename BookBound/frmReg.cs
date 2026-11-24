using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace BookBound
{
    public partial class frmReg : Form
    {
        public string userEmail;
        private static int verificationCode;
        public frmReg()
        {
            InitializeComponent();
        }
        public static string username { get; set; }
        public static string email { get; set; }
        public static string password {  get; set; }


        string connectionstring = "Server=localhost; User ID=root; Password=''; Database=BookBound;";

        private void btnLog_Click(object sender, EventArgs e)
        {
            frmLog loginform = new frmLog();
            loginform.Show();
            this.Hide();
        }
        string default_pename = "Anonymous";

        private void btnReg_Click(object sender, EventArgs e)
        {
            userEmail = txtEmail.Text;  // Get the user's email from the textbox.

            frmReg.username = txtUsername.Text;
            frmReg.email = txtEmail.Text;
            frmReg.password = txtConfirm.Text;
            // Generate a random 6-digit code
            Random rand = new Random();
            verificationCode = rand.Next(100000, 999999);  // Generates a 6-digit code

            // Send the verification code to the user's email
            SendVerificationCode(userEmail, verificationCode);

            // Open the second form to display the message
            frmEnterCode codeSentForm = new frmEnterCode(userEmail, verificationCode);  // Pass the email and code to the next form
            codeSentForm.Show();
            this.Hide();
            //register();
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
                //lblMessage.Text = "Verification code sent successfully!";
                //lblMessage.ForeColor = System.Drawing.Color.Green;
            }
            catch (Exception ex)
            {
                // Optionally show an error message
                //lblMessage.Text = $"Error sending email: {ex.Message}";
                //lblMessage.ForeColor = System.Drawing.Color.Red;
            }
        }


        private void frmReg_Load(object sender, EventArgs e)
        {
            connection();
        }
       
        public void connection()
        {
            MySqlConnection connection = new MySqlConnection(connectionstring);
            MySqlCommand cmd = new MySqlCommand();
            connection.Open();
            if (connection.State == ConnectionState.Open)
            {
                label_connection.Text = "Connected.";
                connection.Close();
            }
            else
            {
                label_connection.Text = "Not connected.";
                connection.Close();
            }

        }
        private bool IsEmailExists(string email)
        {
            string query = "SELECT COUNT(*) FROM accounts WHERE Email = @Email";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionstring))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        int count = Convert.ToInt32(command.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception here if needed
                Console.WriteLine("An error occurred: " + ex.Message);
                return false;
            }
        }

    }
}
