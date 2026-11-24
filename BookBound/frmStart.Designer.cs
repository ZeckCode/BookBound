namespace BookBound
{
    partial class frmStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStart));
            this.picStart = new System.Windows.Forms.PictureBox();
            this.btnReg = new System.Windows.Forms.PictureBox();
            this.btnLog = new System.Windows.Forms.PictureBox();
            this.btnGuest = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuest)).BeginInit();
            this.SuspendLayout();
            // 
            // picStart
            // 
            this.picStart.Image = ((System.Drawing.Image)(resources.GetObject("picStart.Image")));
            this.picStart.Location = new System.Drawing.Point(0, 1);
            this.picStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picStart.Name = "picStart";
            this.picStart.Size = new System.Drawing.Size(680, 397);
            this.picStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStart.TabIndex = 0;
            this.picStart.TabStop = false;
            // 
            // btnReg
            // 
            this.btnReg.Image = ((System.Drawing.Image)(resources.GetObject("btnReg.Image")));
            this.btnReg.Location = new System.Drawing.Point(88, 283);
            this.btnReg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(101, 38);
            this.btnReg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnReg.TabIndex = 3;
            this.btnReg.TabStop = false;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // btnLog
            // 
            this.btnLog.Image = ((System.Drawing.Image)(resources.GetObject("btnLog.Image")));
            this.btnLog.Location = new System.Drawing.Point(193, 283);
            this.btnLog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(101, 38);
            this.btnLog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnLog.TabIndex = 4;
            this.btnLog.TabStop = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnGuest
            // 
            this.btnGuest.Image = ((System.Drawing.Image)(resources.GetObject("btnGuest.Image")));
            this.btnGuest.Location = new System.Drawing.Point(133, 333);
            this.btnGuest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuest.Name = "btnGuest";
            this.btnGuest.Size = new System.Drawing.Size(118, 28);
            this.btnGuest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnGuest.TabIndex = 5;
            this.btnGuest.TabStop = false;
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 398);
            this.Controls.Add(this.btnGuest);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.picStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picStart;
        private System.Windows.Forms.PictureBox btnReg;
        private System.Windows.Forms.PictureBox btnLog;
        private System.Windows.Forms.PictureBox btnGuest;
    }
}

