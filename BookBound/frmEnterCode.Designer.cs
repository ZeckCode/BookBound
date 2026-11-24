namespace BookBound
{
    partial class frmEnterCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnterCode));
            this.picReg = new System.Windows.Forms.PictureBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.btnContinue = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picReg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnContinue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
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
            this.picReg.TabIndex = 3;
            this.picReg.TabStop = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(127, 237);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(0, 13);
            this.lblEmail.TabIndex = 4;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(346, 230);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(247, 20);
            this.txtCode.TabIndex = 5;
            // 
            // btnContinue
            // 
            this.btnContinue.Image = ((System.Drawing.Image)(resources.GetObject("btnContinue.Image")));
            this.btnContinue.Location = new System.Drawing.Point(346, 308);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(126, 47);
            this.btnContinue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnContinue.TabIndex = 6;
            this.btnContinue.TabStop = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(187, 310);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 45);
            this.btnCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCancel.TabIndex = 7;
            this.btnCancel.TabStop = false;
            // 
            // frmEnterCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 398);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.picReg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEnterCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEnterCode";
            ((System.ComponentModel.ISupportInitialize)(this.picReg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnContinue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picReg;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.PictureBox btnContinue;
        private System.Windows.Forms.PictureBox btnCancel;
    }
}