namespace BookBound
{
    partial class frmReg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReg));
            this.picReg = new System.Windows.Forms.PictureBox();
            this.btnReg = new System.Windows.Forms.PictureBox();
            this.btnLog = new System.Windows.Forms.PictureBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_connection = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picReg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLog)).BeginInit();
            this.SuspendLayout();
            // 
            // picReg
            // 
            this.picReg.Image = ((System.Drawing.Image)(resources.GetObject("picReg.Image")));
            this.picReg.Location = new System.Drawing.Point(-1, 2);
            this.picReg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picReg.Name = "picReg";
            this.picReg.Size = new System.Drawing.Size(680, 397);
            this.picReg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picReg.TabIndex = 1;
            this.picReg.TabStop = false;
            //this.picReg.Click += new System.EventHandler(this.picReg_Click);
            // 
            // btnReg
            // 
            this.btnReg.Image = ((System.Drawing.Image)(resources.GetObject("btnReg.Image")));
            this.btnReg.Location = new System.Drawing.Point(467, 291);
            this.btnReg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(117, 40);
            this.btnReg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnReg.TabIndex = 4;
            this.btnReg.TabStop = false;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // btnLog
            // 
            this.btnLog.Image = ((System.Drawing.Image)(resources.GetObject("btnLog.Image")));
            this.btnLog.Location = new System.Drawing.Point(454, 350);
            this.btnLog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(150, 40);
            this.btnLog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnLog.TabIndex = 5;
            this.btnLog.TabStop = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(441, 72);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(176, 20);
            this.txtUsername.TabIndex = 6;
            //this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(441, 136);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(176, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(441, 200);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(176, 20);
            this.txtPassword.TabIndex = 8;
            // 
            // txtConfirm
            // 
            this.txtConfirm.Location = new System.Drawing.Point(441, 264);
            this.txtConfirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(176, 20);
            this.txtConfirm.TabIndex = 9;
            //this.txtConfirm.TextChanged += new System.EventHandler(this.txtConfirm_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Connection status:";
            // 
            // label_connection
            // 
            this.label_connection.AutoSize = true;
            this.label_connection.Location = new System.Drawing.Point(151, 350);
            this.label_connection.Name = "label_connection";
            this.label_connection.Size = new System.Drawing.Size(70, 13);
            this.label_connection.TabIndex = 11;
            this.label_connection.Text = "Connecting...";
            //this.label_connection.Click += new System.EventHandler(this.label2_Click);
            // 
            // frmReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 398);
            this.Controls.Add(this.label_connection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConfirm);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.picReg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frmReg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picReg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picReg;
        private System.Windows.Forms.PictureBox btnReg;
        private System.Windows.Forms.PictureBox btnLog;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_connection;
    }
}