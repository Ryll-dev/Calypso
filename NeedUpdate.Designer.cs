namespace Calypso
{
    partial class NeedUpdate
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
            lblNEEDUPDATE = new Label();
            lblVERSION = new Label();
            prgrsbarUPDATE = new ReaLTaiizor.Controls.AloneProgressBar();
            btnUPDATE = new ReaLTaiizor.Controls.LostButton();
            SuspendLayout();
            // 
            // lblNEEDUPDATE
            // 
            lblNEEDUPDATE.AutoSize = true;
            lblNEEDUPDATE.Font = new Font("Bahnschrift Condensed", 22F);
            lblNEEDUPDATE.ForeColor = SystemColors.ActiveBorder;
            lblNEEDUPDATE.Location = new Point(102, 17);
            lblNEEDUPDATE.Name = "lblNEEDUPDATE";
            lblNEEDUPDATE.Size = new Size(140, 36);
            lblNEEDUPDATE.TabIndex = 37;
            lblNEEDUPDATE.Text = "NEED UPDATE";
            // 
            // lblVERSION
            // 
            lblVERSION.AutoSize = true;
            lblVERSION.Font = new Font("Bahnschrift Condensed", 22F);
            lblVERSION.ForeColor = SystemColors.ActiveBorder;
            lblVERSION.Location = new Point(102, 53);
            lblVERSION.Name = "lblVERSION";
            lblVERSION.Size = new Size(132, 36);
            lblVERSION.TabIndex = 38;
            lblVERSION.Text = "1.0.0 --> 1.0.1";
            // 
            // prgrsbarUPDATE
            // 
            prgrsbarUPDATE.BackColor = Color.Transparent;
            prgrsbarUPDATE.BackgroundColor = Color.Black;
            prgrsbarUPDATE.BaseColor = Color.FromArgb(46, 46, 46);
            prgrsbarUPDATE.BorderColor = Color.FromArgb(46, 46, 46);
            prgrsbarUPDATE.Location = new Point(42, 114);
            prgrsbarUPDATE.Maximum = 100;
            prgrsbarUPDATE.Minimum = 0;
            prgrsbarUPDATE.Name = "prgrsbarUPDATE";
            prgrsbarUPDATE.Size = new Size(254, 30);
            prgrsbarUPDATE.Stripes = Color.FromArgb(50, 50, 50);
            prgrsbarUPDATE.TabIndex = 51;
            prgrsbarUPDATE.Text = "aloneProgressBar1";
            prgrsbarUPDATE.Value = 0;
            prgrsbarUPDATE.Visible = false;
            // 
            // btnUPDATE
            // 
            btnUPDATE.BackColor = Color.FromArgb(25, 25, 25);
            btnUPDATE.Font = new Font("Bahnschrift Condensed", 20F);
            btnUPDATE.ForeColor = SystemColors.ActiveBorder;
            btnUPDATE.HoverColor = Color.FromArgb(20, 20, 20);
            btnUPDATE.Image = null;
            btnUPDATE.Location = new Point(75, 108);
            btnUPDATE.Name = "btnUPDATE";
            btnUPDATE.Size = new Size(191, 36);
            btnUPDATE.TabIndex = 53;
            btnUPDATE.Text = "Download";
            btnUPDATE.Click += btnUPDATE_Click;
            // 
            // NeedUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 36, 36);
            ClientSize = new Size(332, 164);
            Controls.Add(btnUPDATE);
            Controls.Add(prgrsbarUPDATE);
            Controls.Add(lblVERSION);
            Controls.Add(lblNEEDUPDATE);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NeedUpdate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NeedUpdate";
            Load += NeedUpdate_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNEEDUPDATE;
        private Label lblVERSION;
        private ReaLTaiizor.Controls.AloneProgressBar prgrsbarUPDATE;
        private ReaLTaiizor.Controls.LostButton btnUPDATE;
    }
}