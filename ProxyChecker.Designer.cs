namespace Calypso
{
    partial class ProxyChecker
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
            txtURL = new ReaLTaiizor.Controls.ForeverTextBox();
            lblLIVE = new Label();
            lblLIVECOUNT = new Label();
            lblBADCOUNT = new Label();
            lblBAD = new Label();
            lblCHECKEDCOUNT = new Label();
            lblCHECKED = new Label();
            lblUNCHECKEDCOUNT = new Label();
            lblUNCHECKED = new Label();
            btnCHECKER = new ReaLTaiizor.Controls.LostButton();
            lstboxUNCHECKEDPROXIES = new ReaLTaiizor.Controls.MetroListBox();
            prgrsbarPROXYCHECK = new ReaLTaiizor.Controls.AloneProgressBar();
            lstboxCHECKEDPROXIES = new ReaLTaiizor.Controls.MetroListBox();
            btnGETHTML = new ReaLTaiizor.Controls.LostButton();
            txtLIVEKEY = new ReaLTaiizor.Controls.ForeverTextBox();
            SuspendLayout();
            // 
            // txtURL
            // 
            txtURL.BackColor = Color.Transparent;
            txtURL.BaseColor = Color.FromArgb(25, 25, 25);
            txtURL.BorderColor = Color.FromArgb(20, 20, 20);
            txtURL.FocusOnHover = false;
            txtURL.Font = new Font("Bahnschrift Condensed", 12F);
            txtURL.ForeColor = SystemColors.ActiveBorder;
            txtURL.Location = new Point(12, 12);
            txtURL.MaxLength = 32767;
            txtURL.Multiline = false;
            txtURL.Name = "txtURL";
            txtURL.ReadOnly = false;
            txtURL.Size = new Size(281, 31);
            txtURL.TabIndex = 36;
            txtURL.TextAlign = HorizontalAlignment.Left;
            txtURL.UseSystemPasswordChar = false;
            // 
            // lblLIVE
            // 
            lblLIVE.AutoSize = true;
            lblLIVE.Font = new Font("Bahnschrift Condensed", 18F);
            lblLIVE.ForeColor = SystemColors.ActiveBorder;
            lblLIVE.Location = new Point(12, 412);
            lblLIVE.Name = "lblLIVE";
            lblLIVE.Size = new Size(49, 29);
            lblLIVE.TabIndex = 37;
            lblLIVE.Text = "LIVE:";
            // 
            // lblLIVECOUNT
            // 
            lblLIVECOUNT.AutoSize = true;
            lblLIVECOUNT.Font = new Font("Bahnschrift Condensed", 18F);
            lblLIVECOUNT.ForeColor = SystemColors.ActiveBorder;
            lblLIVECOUNT.Location = new Point(54, 412);
            lblLIVECOUNT.Name = "lblLIVECOUNT";
            lblLIVECOUNT.Size = new Size(23, 29);
            lblLIVECOUNT.TabIndex = 38;
            lblLIVECOUNT.Text = "0";
            // 
            // lblBADCOUNT
            // 
            lblBADCOUNT.AutoSize = true;
            lblBADCOUNT.Font = new Font("Bahnschrift Condensed", 18F);
            lblBADCOUNT.ForeColor = SystemColors.ActiveBorder;
            lblBADCOUNT.Location = new Point(231, 412);
            lblBADCOUNT.Name = "lblBADCOUNT";
            lblBADCOUNT.Size = new Size(23, 29);
            lblBADCOUNT.TabIndex = 40;
            lblBADCOUNT.Text = "0";
            // 
            // lblBAD
            // 
            lblBAD.AutoSize = true;
            lblBAD.Font = new Font("Bahnschrift Condensed", 18F);
            lblBAD.ForeColor = SystemColors.ActiveBorder;
            lblBAD.Location = new Point(189, 412);
            lblBAD.Name = "lblBAD";
            lblBAD.Size = new Size(47, 29);
            lblBAD.TabIndex = 39;
            lblBAD.Text = "BAD:";
            // 
            // lblCHECKEDCOUNT
            // 
            lblCHECKEDCOUNT.AutoSize = true;
            lblCHECKEDCOUNT.Font = new Font("Bahnschrift Condensed", 18F);
            lblCHECKEDCOUNT.ForeColor = SystemColors.ActiveBorder;
            lblCHECKEDCOUNT.Location = new Point(454, 412);
            lblCHECKEDCOUNT.Name = "lblCHECKEDCOUNT";
            lblCHECKEDCOUNT.Size = new Size(23, 29);
            lblCHECKEDCOUNT.TabIndex = 42;
            lblCHECKEDCOUNT.Text = "0";
            // 
            // lblCHECKED
            // 
            lblCHECKED.AutoSize = true;
            lblCHECKED.Font = new Font("Bahnschrift Condensed", 18F);
            lblCHECKED.ForeColor = SystemColors.ActiveBorder;
            lblCHECKED.Location = new Point(374, 412);
            lblCHECKED.Name = "lblCHECKED";
            lblCHECKED.Size = new Size(84, 29);
            lblCHECKED.TabIndex = 41;
            lblCHECKED.Text = "CHECKED:";
            // 
            // lblUNCHECKEDCOUNT
            // 
            lblUNCHECKEDCOUNT.AutoSize = true;
            lblUNCHECKEDCOUNT.Font = new Font("Bahnschrift Condensed", 18F);
            lblUNCHECKEDCOUNT.ForeColor = SystemColors.ActiveBorder;
            lblUNCHECKEDCOUNT.Location = new Point(699, 412);
            lblUNCHECKEDCOUNT.Name = "lblUNCHECKEDCOUNT";
            lblUNCHECKEDCOUNT.Size = new Size(23, 29);
            lblUNCHECKEDCOUNT.TabIndex = 44;
            lblUNCHECKEDCOUNT.Text = "0";
            // 
            // lblUNCHECKED
            // 
            lblUNCHECKED.AutoSize = true;
            lblUNCHECKED.Font = new Font("Bahnschrift Condensed", 18F);
            lblUNCHECKED.ForeColor = SystemColors.ActiveBorder;
            lblUNCHECKED.Location = new Point(602, 412);
            lblUNCHECKED.Name = "lblUNCHECKED";
            lblUNCHECKED.Size = new Size(105, 29);
            lblUNCHECKED.TabIndex = 43;
            lblUNCHECKED.Text = "UNCHECKED:";
            // 
            // btnCHECKER
            // 
            btnCHECKER.BackColor = Color.FromArgb(25, 25, 25);
            btnCHECKER.Font = new Font("Bahnschrift Condensed", 14F);
            btnCHECKER.ForeColor = SystemColors.ActiveBorder;
            btnCHECKER.HoverColor = Color.FromArgb(20, 20, 20);
            btnCHECKER.Image = null;
            btnCHECKER.Location = new Point(693, 12);
            btnCHECKER.Name = "btnCHECKER";
            btnCHECKER.Size = new Size(95, 31);
            btnCHECKER.TabIndex = 45;
            btnCHECKER.Text = "Check";
            btnCHECKER.Click += btnCHECKER_Click;
            // 
            // lstboxUNCHECKEDPROXIES
            // 
            lstboxUNCHECKEDPROXIES.BackColor = Color.White;
            lstboxUNCHECKEDPROXIES.BorderColor = Color.LightGray;
            lstboxUNCHECKEDPROXIES.DisabledBackColor = Color.FromArgb(204, 204, 204);
            lstboxUNCHECKEDPROXIES.DisabledForeColor = Color.FromArgb(136, 136, 136);
            lstboxUNCHECKEDPROXIES.Font = new Font("Bahnschrift Condensed", 15F);
            lstboxUNCHECKEDPROXIES.HoveredItemBackColor = Color.LightGray;
            lstboxUNCHECKEDPROXIES.HoveredItemColor = Color.DimGray;
            lstboxUNCHECKEDPROXIES.IsDerivedStyle = true;
            lstboxUNCHECKEDPROXIES.ItemHeight = 30;
            lstboxUNCHECKEDPROXIES.Location = new Point(12, 49);
            lstboxUNCHECKEDPROXIES.MultiSelect = false;
            lstboxUNCHECKEDPROXIES.Name = "lstboxUNCHECKEDPROXIES";
            lstboxUNCHECKEDPROXIES.SelectedIndex = -1;
            lstboxUNCHECKEDPROXIES.SelectedItem = null;
            lstboxUNCHECKEDPROXIES.SelectedItemBackColor = Color.FromArgb(65, 177, 225);
            lstboxUNCHECKEDPROXIES.SelectedItemColor = Color.White;
            lstboxUNCHECKEDPROXIES.SelectedText = null;
            lstboxUNCHECKEDPROXIES.SelectedValue = null;
            lstboxUNCHECKEDPROXIES.ShowBorder = false;
            lstboxUNCHECKEDPROXIES.ShowScrollBar = false;
            lstboxUNCHECKEDPROXIES.Size = new Size(381, 331);
            lstboxUNCHECKEDPROXIES.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            lstboxUNCHECKEDPROXIES.StyleManager = null;
            lstboxUNCHECKEDPROXIES.TabIndex = 49;
            lstboxUNCHECKEDPROXIES.ThemeAuthor = "Taiizor";
            lstboxUNCHECKEDPROXIES.ThemeName = "MetroLight";
            // 
            // prgrsbarPROXYCHECK
            // 
            prgrsbarPROXYCHECK.BackColor = Color.Transparent;
            prgrsbarPROXYCHECK.BackgroundColor = Color.Black;
            prgrsbarPROXYCHECK.BaseColor = Color.FromArgb(46, 46, 46);
            prgrsbarPROXYCHECK.BorderColor = Color.FromArgb(46, 46, 46);
            prgrsbarPROXYCHECK.Location = new Point(12, 386);
            prgrsbarPROXYCHECK.Maximum = 100;
            prgrsbarPROXYCHECK.Minimum = 0;
            prgrsbarPROXYCHECK.Name = "prgrsbarPROXYCHECK";
            prgrsbarPROXYCHECK.Size = new Size(776, 23);
            prgrsbarPROXYCHECK.Stripes = Color.FromArgb(50, 50, 50);
            prgrsbarPROXYCHECK.TabIndex = 50;
            prgrsbarPROXYCHECK.Text = "aloneProgressBar1";
            prgrsbarPROXYCHECK.Value = 0;
            // 
            // lstboxCHECKEDPROXIES
            // 
            lstboxCHECKEDPROXIES.BackColor = Color.White;
            lstboxCHECKEDPROXIES.BorderColor = Color.LightGray;
            lstboxCHECKEDPROXIES.DisabledBackColor = Color.FromArgb(204, 204, 204);
            lstboxCHECKEDPROXIES.DisabledForeColor = Color.FromArgb(136, 136, 136);
            lstboxCHECKEDPROXIES.Font = new Font("Bahnschrift Condensed", 15F);
            lstboxCHECKEDPROXIES.HoveredItemBackColor = Color.LightGray;
            lstboxCHECKEDPROXIES.HoveredItemColor = Color.DimGray;
            lstboxCHECKEDPROXIES.IsDerivedStyle = true;
            lstboxCHECKEDPROXIES.ItemHeight = 30;
            lstboxCHECKEDPROXIES.Location = new Point(407, 49);
            lstboxCHECKEDPROXIES.MultiSelect = false;
            lstboxCHECKEDPROXIES.Name = "lstboxCHECKEDPROXIES";
            lstboxCHECKEDPROXIES.SelectedIndex = -1;
            lstboxCHECKEDPROXIES.SelectedItem = null;
            lstboxCHECKEDPROXIES.SelectedItemBackColor = Color.FromArgb(65, 177, 225);
            lstboxCHECKEDPROXIES.SelectedItemColor = Color.White;
            lstboxCHECKEDPROXIES.SelectedText = null;
            lstboxCHECKEDPROXIES.SelectedValue = null;
            lstboxCHECKEDPROXIES.ShowBorder = false;
            lstboxCHECKEDPROXIES.ShowScrollBar = false;
            lstboxCHECKEDPROXIES.Size = new Size(381, 331);
            lstboxCHECKEDPROXIES.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            lstboxCHECKEDPROXIES.StyleManager = null;
            lstboxCHECKEDPROXIES.TabIndex = 51;
            lstboxCHECKEDPROXIES.ThemeAuthor = "Taiizor";
            lstboxCHECKEDPROXIES.ThemeName = "MetroLight";
            // 
            // btnGETHTML
            // 
            btnGETHTML.BackColor = Color.FromArgb(25, 25, 25);
            btnGETHTML.Font = new Font("Bahnschrift Condensed", 14F);
            btnGETHTML.ForeColor = SystemColors.ActiveBorder;
            btnGETHTML.HoverColor = Color.FromArgb(20, 20, 20);
            btnGETHTML.Image = null;
            btnGETHTML.Location = new Point(592, 12);
            btnGETHTML.Name = "btnGETHTML";
            btnGETHTML.Size = new Size(95, 31);
            btnGETHTML.TabIndex = 52;
            btnGETHTML.Text = "Get Html";
            btnGETHTML.Click += btnGETHTML_Click;
            // 
            // txtLIVEKEY
            // 
            txtLIVEKEY.BackColor = Color.Transparent;
            txtLIVEKEY.BaseColor = Color.FromArgb(25, 25, 25);
            txtLIVEKEY.BorderColor = Color.FromArgb(20, 20, 20);
            txtLIVEKEY.FocusOnHover = false;
            txtLIVEKEY.Font = new Font("Bahnschrift Condensed", 12F);
            txtLIVEKEY.ForeColor = SystemColors.ActiveBorder;
            txtLIVEKEY.Location = new Point(299, 12);
            txtLIVEKEY.MaxLength = 32767;
            txtLIVEKEY.Multiline = false;
            txtLIVEKEY.Name = "txtLIVEKEY";
            txtLIVEKEY.ReadOnly = false;
            txtLIVEKEY.Size = new Size(281, 31);
            txtLIVEKEY.TabIndex = 53;
            txtLIVEKEY.TextAlign = HorizontalAlignment.Left;
            txtLIVEKEY.UseSystemPasswordChar = false;
            // 
            // ProxyChecker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 36, 36);
            ClientSize = new Size(800, 450);
            Controls.Add(txtLIVEKEY);
            Controls.Add(btnGETHTML);
            Controls.Add(lstboxCHECKEDPROXIES);
            Controls.Add(prgrsbarPROXYCHECK);
            Controls.Add(lstboxUNCHECKEDPROXIES);
            Controls.Add(btnCHECKER);
            Controls.Add(lblUNCHECKEDCOUNT);
            Controls.Add(lblUNCHECKED);
            Controls.Add(lblCHECKEDCOUNT);
            Controls.Add(lblCHECKED);
            Controls.Add(lblBADCOUNT);
            Controls.Add(lblBAD);
            Controls.Add(lblLIVECOUNT);
            Controls.Add(lblLIVE);
            Controls.Add(txtURL);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProxyChecker";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Proxy Checker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.ForeverTextBox txtURL;
        private Label lblLIVE;
        private Label lblLIVECOUNT;
        private Label lblBADCOUNT;
        private Label lblBAD;
        private Label lblCHECKEDCOUNT;
        private Label lblCHECKED;
        private Label lblUNCHECKEDCOUNT;
        private Label lblUNCHECKED;
        private ReaLTaiizor.Controls.LostButton btnCHECKER;
        private ReaLTaiizor.Controls.MetroListBox lstboxUNCHECKEDPROXIES;
        private ReaLTaiizor.Controls.AloneProgressBar prgrsbarPROXYCHECK;
        private ReaLTaiizor.Controls.MetroListBox lstboxCHECKEDPROXIES;
        private ReaLTaiizor.Controls.LostButton btnGETHTML;
        private ReaLTaiizor.Controls.ForeverTextBox txtLIVEKEY;
    }
}