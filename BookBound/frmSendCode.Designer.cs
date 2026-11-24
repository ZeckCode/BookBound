namespace BookBound
{
    partial class frmSendCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSendCode));
            this.picReg = new System.Windows.Forms.PictureBox();
            this.lblEmailMessage = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.PictureBox();
            this.btnContinue = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picReg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnContinue)).BeginInit();
            this.SuspendLayout();
            // 
            // picReg
            // 
            this.picReg.Image = ((System.Drawing.Image)(resources.GetObject("picReg.Image")));
            this.picReg.Location = new System.Drawing.Point(-1, 1);
            this.picReg.Margin = new System.Windows.Forms.Padding(2);
            this.picReg.Name = "picReg";
            this.picReg.Size = new System.Drawing.Size(680, 397);
            this.picReg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picReg.TabIndex = 2;
            this.picReg.TabStop = false;
            // 
            // lblEmailMessage
            // 
            this.lblEmailMessage.Location = new System.Drawing.Point(214, 216);
            this.lblEmailMessage.Name = "lblEmailMessage";
            this.lblEmailMessage.Size = new System.Drawing.Size(250, 20);
            this.lblEmailMessage.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(214, 311);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 45);
            this.btnCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCancel.TabIndex = 4;
            this.btnCancel.TabStop = false;
            // 
            // btnContinue
            // 
            this.btnContinue.Image = ((System.Drawing.Image)(resources.GetObject("btnContinue.Image")));
            this.btnContinue.Location = new System.Drawing.Point(345, 309);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(126, 47);
            this.btnContinue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnContinue.TabIndex = 5;
            this.btnContinue.TabStop = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // frmSendCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 398);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblEmailMessage);
            this.Controls.Add(this.picReg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSendCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.picReg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnContinue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picReg;
        private System.Windows.Forms.TextBox lblEmailMessage;
        private System.Windows.Forms.PictureBox btnCancel;
        private System.Windows.Forms.PictureBox btnContinue;
    }
}