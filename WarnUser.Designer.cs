namespace Calypso
{
    partial class WarnUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarnUser));
            pnlALERT = new Panel();
            rtxtALERT = new RichTextBox();
            imgALERT = new PictureBox();
            lblALERT = new Label();
            pnlALERT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgALERT).BeginInit();
            SuspendLayout();
            // 
            // pnlALERT
            // 
            pnlALERT.Controls.Add(rtxtALERT);
            pnlALERT.Controls.Add(imgALERT);
            pnlALERT.Controls.Add(lblALERT);
            pnlALERT.Location = new Point(6, 6);
            pnlALERT.Name = "pnlALERT";
            pnlALERT.Size = new Size(337, 166);
            pnlALERT.TabIndex = 30;
            // 
            // rtxtALERT
            // 
            rtxtALERT.BackColor = Color.FromArgb(36, 36, 36);
            rtxtALERT.BorderStyle = BorderStyle.None;
            rtxtALERT.Font = new Font("Bahnschrift Condensed", 12F);
            rtxtALERT.ForeColor = SystemColors.ActiveBorder;
            rtxtALERT.Location = new Point(9, 50);
            rtxtALERT.Name = "rtxtALERT";
            rtxtALERT.ReadOnly = true;
            rtxtALERT.Size = new Size(319, 110);
            rtxtALERT.TabIndex = 32;
            rtxtALERT.Text = "";
            // 
            // imgALERT
            // 
            imgALERT.Image = (Image)resources.GetObject("imgALERT.Image");
            imgALERT.Location = new Point(9, 9);
            imgALERT.Name = "imgALERT";
            imgALERT.Size = new Size(30, 30);
            imgALERT.SizeMode = PictureBoxSizeMode.StretchImage;
            imgALERT.TabIndex = 31;
            imgALERT.TabStop = false;
            // 
            // lblALERT
            // 
            lblALERT.AutoSize = true;
            lblALERT.Font = new Font("Bahnschrift Condensed", 18F);
            lblALERT.ForeColor = SystemColors.ActiveBorder;
            lblALERT.Location = new Point(45, 10);
            lblALERT.Name = "lblALERT";
            lblALERT.Size = new Size(61, 29);
            lblALERT.TabIndex = 30;
            lblALERT.Text = "ALERT";
            // 
            // WarnUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 36, 36);
            ClientSize = new Size(346, 175);
            Controls.Add(pnlALERT);
            FormBorderStyle = FormBorderStyle.None;
            Name = "WarnUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WarnUser";
            TopMost = true;
            Load += WarnUser_Load;
            Shown += WarnUser_Shown;
            pnlALERT.ResumeLayout(false);
            pnlALERT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgALERT).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlALERT;
        private RichTextBox rtxtALERT;
        private PictureBox imgALERT;
        private Label lblALERT;
    }
}