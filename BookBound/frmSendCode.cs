using System.Windows.Forms;
using System.Net.Mail;

namespace BookBound
{
    public partial class frmSendCode : Form
    {        
        private string email;
        private int verificationCode;
        public frmSendCode(string userEmail, int code)
        {
            InitializeComponent();
            email = userEmail;
            verificationCode = code;  // Store the verification code passed from SearchForm
            lblEmailMessage.Text = $"We sent the code to: {email}";
        }
        private int _verificationCode;

        private void btnContinue_Click(object sender, System.EventArgs e)
        {
            frmEnterCode enterCodeForm = new frmEnterCode(email, verificationCode);  // Pass both email and code
            enterCodeForm.Show();
            this.Hide();
        }
    }
}

