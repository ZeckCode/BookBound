namespace BookBound
{
    partial class frmLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLog));
            this.picLog = new System.Windows.Forms.PictureBox();
            this.btnLog = new System.Windows.Forms.PictureBox();
            this.btnForgot = new System.Windows.Forms.PictureBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnForgot)).BeginInit();
            this.SuspendLayout();
            // 
            // picLog
            // 
            this.picLog.Image = ((System.Drawing.Image)(resources.GetObject("picLog.Image")));
            this.picLog.Location = new System.Drawing.Point(-1, 1);
            this.picLog.Margin = new System.Windows.Forms.Padding(2);
            this.picLog.Name = "picLog";
            this.picLog.Size = new System.Drawing.Size(680, 397);
            this.picLog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLog.TabIndex = 1;
            this.picLog.TabStop = false;
            // 
            // btnLog
            // 
            this.btnLog.Image = ((System.Drawing.Image)(resources.GetObject("btnLog.Image")));
            this.btnLog.Location = new System.Drawing.Point(279, 300);
            this.btnLog.Margin = new System.Windows.Forms.Padding(2);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(117, 40);
            this.btnLog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnLog.TabIndex = 5;
            this.btnLog.TabStop = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnForgot
            // 
            this.btnForgot.Image = ((System.Drawing.Image)(resources.GetObject("btnForgot.Image")));
            this.btnForgot.Location = new System.Drawing.Point(486, 332);
            this.btnForgot.Margin = new System.Windows.Forms.Padding(2);
            this.btnForgot.Name = "btnForgot";
            this.btnForgot.Size = new System.Drawing.Size(155, 33);
            this.btnForgot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnForgot.TabIndex = 6;
            this.btnForgot.TabStop = false;
            this.btnForgot.Click += new System.EventHandler(this.btnForgot_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(214, 200);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(251, 20);
            this.txtUsername.TabIndex = 7;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(214, 274);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(251, 20);
            this.txtPassword.TabIndex = 9;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 333);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(105, 32);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "back button\r\n";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 398);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnForgot);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.picLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.picLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnForgot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLog;
        private System.Windows.Forms.PictureBox btnLog;
        private System.Windows.Forms.PictureBox btnForgot;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnBack;
    }
}