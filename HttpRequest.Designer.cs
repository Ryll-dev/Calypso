namespace Calypso
{
    partial class HttpRequest
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
            panel1 = new Panel();
            txtURL = new ReaLTaiizor.Controls.ForeverTextBox();
            cmbREQUESTTYPE = new ReaLTaiizor.Controls.ForeverComboBox();
            rtxtCONTENT = new RichTextBox();
            lblCONTENTBODY = new Label();
            rtxtCOOKIES = new RichTextBox();
            lblCOOKIES = new Label();
            rtxtHEADERS = new RichTextBox();
            lblHEADERS = new Label();
            btnSENDREQ = new ReaLTaiizor.Controls.LostButton();
            cmbCONTENTTYPE = new ReaLTaiizor.Controls.ForeverComboBox();
            lblREQUEST = new Label();
            panel2 = new Panel();
            lblMSS = new Label();
            lblMS = new Label();
            lblSTATUSCODE = new Label();
            lblSTATUS = new Label();
            rtxtrCONTENT = new RichTextBox();
            rtxtrCOOKIES = new RichTextBox();
            lblRCONTENTBODY = new Label();
            lblRCOOKIES = new Label();
            rtxtrHEADERS = new RichTextBox();
            lblRHEADERS = new Label();
            lblRESPONSE = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtURL);
            panel1.Controls.Add(cmbREQUESTTYPE);
            panel1.Controls.Add(rtxtCONTENT);
            panel1.Controls.Add(lblCONTENTBODY);
            panel1.Controls.Add(rtxtCOOKIES);
            panel1.Controls.Add(lblCOOKIES);
            panel1.Controls.Add(rtxtHEADERS);
            panel1.Controls.Add(lblHEADERS);
            panel1.Controls.Add(btnSENDREQ);
            panel1.Controls.Add(cmbCONTENTTYPE);
            panel1.Location = new Point(13, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(516, 599);
            panel1.TabIndex = 32;
            // 
            // txtURL
            // 
            txtURL.BackColor = Color.Transparent;
            txtURL.BaseColor = Color.FromArgb(25, 25, 25);
            txtURL.BorderColor = Color.FromArgb(20, 20, 20);
            txtURL.FocusOnHover = false;
            txtURL.Font = new Font("Bahnschrift Condensed", 12F);
            txtURL.ForeColor = SystemColors.ActiveBorder;
            txtURL.Location = new Point(12, 24);
            txtURL.MaxLength = 32767;
            txtURL.Multiline = false;
            txtURL.Name = "txtURL";
            txtURL.ReadOnly = false;
            txtURL.Size = new Size(489, 31);
            txtURL.TabIndex = 35;
            txtURL.TextAlign = HorizontalAlignment.Left;
            txtURL.UseSystemPasswordChar = false;
            // 
            // cmbREQUESTTYPE
            // 
            cmbREQUESTTYPE.BackColor = Color.FromArgb(25, 25, 25);
            cmbREQUESTTYPE.BaseColor = Color.FromArgb(25, 25, 25);
            cmbREQUESTTYPE.BGColor = Color.FromArgb(25, 25, 25);
            cmbREQUESTTYPE.DrawMode = DrawMode.OwnerDrawFixed;
            cmbREQUESTTYPE.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbREQUESTTYPE.Font = new Font("Bahnschrift Condensed", 12F);
            cmbREQUESTTYPE.ForeColor = SystemColors.ActiveBorder;
            cmbREQUESTTYPE.FormattingEnabled = true;
            cmbREQUESTTYPE.HoverColor = Color.Black;
            cmbREQUESTTYPE.HoverFontColor = Color.White;
            cmbREQUESTTYPE.ItemHeight = 18;
            cmbREQUESTTYPE.Items.AddRange(new object[] { "POST", "GET", "HEAD", "PUT", "DELETE", "OPTIONS", "PATCH" });
            cmbREQUESTTYPE.Location = new Point(12, 59);
            cmbREQUESTTYPE.Name = "cmbREQUESTTYPE";
            cmbREQUESTTYPE.Size = new Size(131, 24);
            cmbREQUESTTYPE.TabIndex = 34;
            // 
            // rtxtCONTENT
            // 
            rtxtCONTENT.BackColor = Color.FromArgb(25, 25, 25);
            rtxtCONTENT.BorderStyle = BorderStyle.None;
            rtxtCONTENT.Font = new Font("Bahnschrift Condensed", 12F);
            rtxtCONTENT.ForeColor = SystemColors.ActiveBorder;
            rtxtCONTENT.Location = new Point(12, 416);
            rtxtCONTENT.Name = "rtxtCONTENT";
            rtxtCONTENT.Size = new Size(489, 110);
            rtxtCONTENT.TabIndex = 33;
            rtxtCONTENT.Text = "";
            // 
            // lblCONTENTBODY
            // 
            lblCONTENTBODY.AutoSize = true;
            lblCONTENTBODY.Font = new Font("Bahnschrift Condensed", 18F);
            lblCONTENTBODY.ForeColor = SystemColors.ActiveBorder;
            lblCONTENTBODY.Location = new Point(12, 384);
            lblCONTENTBODY.Name = "lblCONTENTBODY";
            lblCONTENTBODY.Size = new Size(131, 29);
            lblCONTENTBODY.TabIndex = 32;
            lblCONTENTBODY.Text = "CONTENT-BODY";
            // 
            // rtxtCOOKIES
            // 
            rtxtCOOKIES.BackColor = Color.FromArgb(25, 25, 25);
            rtxtCOOKIES.BorderStyle = BorderStyle.None;
            rtxtCOOKIES.Font = new Font("Bahnschrift Condensed", 12F);
            rtxtCOOKIES.ForeColor = SystemColors.ActiveBorder;
            rtxtCOOKIES.Location = new Point(12, 275);
            rtxtCOOKIES.Name = "rtxtCOOKIES";
            rtxtCOOKIES.Size = new Size(489, 96);
            rtxtCOOKIES.TabIndex = 31;
            rtxtCOOKIES.Text = "";
            // 
            // lblCOOKIES
            // 
            lblCOOKIES.AutoSize = true;
            lblCOOKIES.Font = new Font("Bahnschrift Condensed", 18F);
            lblCOOKIES.ForeColor = SystemColors.ActiveBorder;
            lblCOOKIES.Location = new Point(12, 243);
            lblCOOKIES.Name = "lblCOOKIES";
            lblCOOKIES.Size = new Size(79, 29);
            lblCOOKIES.TabIndex = 30;
            lblCOOKIES.Text = "COOKIES";
            // 
            // rtxtHEADERS
            // 
            rtxtHEADERS.BackColor = Color.FromArgb(25, 25, 25);
            rtxtHEADERS.BorderStyle = BorderStyle.None;
            rtxtHEADERS.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            rtxtHEADERS.ForeColor = SystemColors.ActiveBorder;
            rtxtHEADERS.Location = new Point(12, 136);
            rtxtHEADERS.Name = "rtxtHEADERS";
            rtxtHEADERS.Size = new Size(489, 96);
            rtxtHEADERS.TabIndex = 29;
            rtxtHEADERS.Text = "User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:136.0) Gecko/20100101 Firefox/136.0\nPragma: no-cache\nAccept: */*";
            // 
            // lblHEADERS
            // 
            lblHEADERS.AutoSize = true;
            lblHEADERS.Font = new Font("Bahnschrift Condensed", 18F);
            lblHEADERS.ForeColor = SystemColors.ActiveBorder;
            lblHEADERS.Location = new Point(12, 104);
            lblHEADERS.Name = "lblHEADERS";
            lblHEADERS.Size = new Size(83, 29);
            lblHEADERS.TabIndex = 28;
            lblHEADERS.Text = "HEADERS";
            // 
            // btnSENDREQ
            // 
            btnSENDREQ.BackColor = Color.FromArgb(25, 25, 25);
            btnSENDREQ.Font = new Font("Bahnschrift Condensed", 14F);
            btnSENDREQ.ForeColor = SystemColors.ActiveBorder;
            btnSENDREQ.HoverColor = Color.FromArgb(20, 20, 20);
            btnSENDREQ.Image = null;
            btnSENDREQ.Location = new Point(12, 542);
            btnSENDREQ.Name = "btnSENDREQ";
            btnSENDREQ.Size = new Size(489, 40);
            btnSENDREQ.TabIndex = 27;
            btnSENDREQ.Text = "Send Request";
            btnSENDREQ.Click += btnSENDREQ_Click;
            // 
            // cmbCONTENTTYPE
            // 
            cmbCONTENTTYPE.BackColor = Color.FromArgb(25, 25, 25);
            cmbCONTENTTYPE.BaseColor = Color.FromArgb(25, 25, 25);
            cmbCONTENTTYPE.BGColor = Color.FromArgb(25, 25, 25);
            cmbCONTENTTYPE.DrawMode = DrawMode.OwnerDrawFixed;
            cmbCONTENTTYPE.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCONTENTTYPE.Font = new Font("Bahnschrift Condensed", 12F);
            cmbCONTENTTYPE.ForeColor = SystemColors.ActiveBorder;
            cmbCONTENTTYPE.FormattingEnabled = true;
            cmbCONTENTTYPE.HoverColor = Color.Black;
            cmbCONTENTTYPE.HoverFontColor = Color.White;
            cmbCONTENTTYPE.ItemHeight = 18;
            cmbCONTENTTYPE.Items.AddRange(new object[] { "application/x-www-form-urlencoded", "application/json", "application/atom+xml", "application/epub+zip", "application/geo+json", "application/graphql", "application/grpc", "application/java-archive", "application/javascript", "application/ld+json", "application/msword", "application/octet-stream", "application/pdf", "application/rss+xml", "application/rtf", "application/soap+xml", "application/sql", "application/vnd.android.package-archive", "application/vnd.api+json", "application/vnd.apple.installer+xml", "application/vnd.google-earth.kml+xml", "application/vnd.ms-excel", "application/vnd.ms-fontobject", "application/vnd.oasis.opendocument.text", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "application/x-bittorrent", "application/x-httpd-php", "application/x-rar-compressed", "application/x-shockwave-flash", "application/x-yaml", "application/xhtml+xml", "application/xml", "application/xml-dtd", "application/yaml", "application/zip", "audio/aac", "audio/midi", "audio/mpeg", "audio/ogg", "audio/wav", "audio/webm", "chemical/x-cif", "chemical/x-pdb", "example/*", "font/collection", "font/otf", "font/ttf", "font/woff", "font/woff2", "image/bmp", "image/gif", "image/jpeg", "image/png", "image/svg+xml", "image/tiff", "image/vnd.microsoft.icon", "image/webp", "message/global", "message/http", "message/partial", "message/rfc822", "model/gltf-binary", "model/gltf+json", "model/step", "model/stl", "multipart/alternative", "multipart/byteranges", "multipart/form-data", "multipart/mixed", "multipart/related", "multipart/signed", "prs.*", "text/calendar", "text/css", "text/csv", "text/html", "text/javascript", "text/markdown", "text/plain", "text/vcard", "text/xml", "text/yaml", "video/mp4", "video/mpeg", "video/ogg", "video/quicktime", "video/webm", "video/x-matroska", "video/x-msvideo", "x-convention/*" });
            cmbCONTENTTYPE.Location = new Point(149, 59);
            cmbCONTENTTYPE.Name = "cmbCONTENTTYPE";
            cmbCONTENTTYPE.Size = new Size(352, 24);
            cmbCONTENTTYPE.TabIndex = 26;
            // 
            // lblREQUEST
            // 
            lblREQUEST.AutoSize = true;
            lblREQUEST.Font = new Font("Bahnschrift Condensed", 22F);
            lblREQUEST.ForeColor = SystemColors.ActiveBorder;
            lblREQUEST.Location = new Point(224, 1);
            lblREQUEST.Name = "lblREQUEST";
            lblREQUEST.Size = new Size(100, 36);
            lblREQUEST.TabIndex = 36;
            lblREQUEST.Text = "REQUEST";
            // 
            // panel2
            // 
            panel2.Controls.Add(lblMSS);
            panel2.Controls.Add(lblMS);
            panel2.Controls.Add(lblSTATUSCODE);
            panel2.Controls.Add(lblSTATUS);
            panel2.Controls.Add(rtxtrCONTENT);
            panel2.Controls.Add(rtxtrCOOKIES);
            panel2.Controls.Add(lblRCONTENTBODY);
            panel2.Controls.Add(lblRCOOKIES);
            panel2.Controls.Add(rtxtrHEADERS);
            panel2.Controls.Add(lblRHEADERS);
            panel2.Location = new Point(535, 20);
            panel2.Name = "panel2";
            panel2.Size = new Size(516, 599);
            panel2.TabIndex = 37;
            // 
            // lblMSS
            // 
            lblMSS.AutoSize = true;
            lblMSS.Font = new Font("Bahnschrift Condensed", 18F);
            lblMSS.ForeColor = SystemColors.ActiveBorder;
            lblMSS.Location = new Point(431, 21);
            lblMSS.Name = "lblMSS";
            lblMSS.Size = new Size(43, 29);
            lblMSS.TabIndex = 42;
            lblMSS.Text = "200";
            lblMSS.Visible = false;
            // 
            // lblMS
            // 
            lblMS.AutoSize = true;
            lblMS.Font = new Font("Bahnschrift Condensed", 18F);
            lblMS.ForeColor = SystemColors.ActiveBorder;
            lblMS.Location = new Point(471, 21);
            lblMS.Name = "lblMS";
            lblMS.Size = new Size(36, 29);
            lblMS.TabIndex = 41;
            lblMS.Text = "MS";
            lblMS.Visible = false;
            // 
            // lblSTATUSCODE
            // 
            lblSTATUSCODE.AutoSize = true;
            lblSTATUSCODE.Font = new Font("Bahnschrift Condensed", 18F);
            lblSTATUSCODE.ForeColor = SystemColors.ActiveBorder;
            lblSTATUSCODE.Location = new Point(316, 21);
            lblSTATUSCODE.Name = "lblSTATUSCODE";
            lblSTATUSCODE.Size = new Size(43, 29);
            lblSTATUSCODE.TabIndex = 40;
            lblSTATUSCODE.Text = "200";
            lblSTATUSCODE.Visible = false;
            // 
            // lblSTATUS
            // 
            lblSTATUS.AutoSize = true;
            lblSTATUS.Font = new Font("Bahnschrift Condensed", 18F);
            lblSTATUS.ForeColor = SystemColors.ActiveBorder;
            lblSTATUS.Location = new Point(356, 21);
            lblSTATUS.Name = "lblSTATUS";
            lblSTATUS.Size = new Size(69, 29);
            lblSTATUS.TabIndex = 39;
            lblSTATUS.Text = "STATUS";
            lblSTATUS.Visible = false;
            // 
            // rtxtrCONTENT
            // 
            rtxtrCONTENT.BackColor = Color.FromArgb(25, 25, 25);
            rtxtrCONTENT.BorderStyle = BorderStyle.None;
            rtxtrCONTENT.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            rtxtrCONTENT.ForeColor = SystemColors.ActiveBorder;
            rtxtrCONTENT.Location = new Point(12, 396);
            rtxtrCONTENT.Name = "rtxtrCONTENT";
            rtxtrCONTENT.ReadOnly = true;
            rtxtrCONTENT.Size = new Size(489, 190);
            rtxtrCONTENT.TabIndex = 37;
            rtxtrCONTENT.Text = "";
            // 
            // rtxtrCOOKIES
            // 
            rtxtrCOOKIES.BackColor = Color.FromArgb(25, 25, 25);
            rtxtrCOOKIES.BorderStyle = BorderStyle.None;
            rtxtrCOOKIES.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            rtxtrCOOKIES.ForeColor = SystemColors.ActiveBorder;
            rtxtrCOOKIES.Location = new Point(12, 227);
            rtxtrCOOKIES.Name = "rtxtrCOOKIES";
            rtxtrCOOKIES.ReadOnly = true;
            rtxtrCOOKIES.Size = new Size(489, 120);
            rtxtrCOOKIES.TabIndex = 36;
            rtxtrCOOKIES.Text = "";
            // 
            // lblRCONTENTBODY
            // 
            lblRCONTENTBODY.AutoSize = true;
            lblRCONTENTBODY.Font = new Font("Bahnschrift Condensed", 18F);
            lblRCONTENTBODY.ForeColor = SystemColors.ActiveBorder;
            lblRCONTENTBODY.Location = new Point(12, 364);
            lblRCONTENTBODY.Name = "lblRCONTENTBODY";
            lblRCONTENTBODY.Size = new Size(131, 29);
            lblRCONTENTBODY.TabIndex = 35;
            lblRCONTENTBODY.Text = "CONTENT-BODY";
            // 
            // lblRCOOKIES
            // 
            lblRCOOKIES.AutoSize = true;
            lblRCOOKIES.Font = new Font("Bahnschrift Condensed", 18F);
            lblRCOOKIES.ForeColor = SystemColors.ActiveBorder;
            lblRCOOKIES.Location = new Point(12, 195);
            lblRCOOKIES.Name = "lblRCOOKIES";
            lblRCOOKIES.Size = new Size(79, 29);
            lblRCOOKIES.TabIndex = 34;
            lblRCOOKIES.Text = "COOKIES";
            // 
            // rtxtrHEADERS
            // 
            rtxtrHEADERS.BackColor = Color.FromArgb(25, 25, 25);
            rtxtrHEADERS.BorderStyle = BorderStyle.None;
            rtxtrHEADERS.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            rtxtrHEADERS.ForeColor = SystemColors.ActiveBorder;
            rtxtrHEADERS.Location = new Point(12, 66);
            rtxtrHEADERS.Name = "rtxtrHEADERS";
            rtxtrHEADERS.ReadOnly = true;
            rtxtrHEADERS.Size = new Size(489, 120);
            rtxtrHEADERS.TabIndex = 33;
            rtxtrHEADERS.Text = "";
            // 
            // lblRHEADERS
            // 
            lblRHEADERS.AutoSize = true;
            lblRHEADERS.Font = new Font("Bahnschrift Condensed", 18F);
            lblRHEADERS.ForeColor = SystemColors.ActiveBorder;
            lblRHEADERS.Location = new Point(12, 28);
            lblRHEADERS.Name = "lblRHEADERS";
            lblRHEADERS.Size = new Size(83, 29);
            lblRHEADERS.TabIndex = 32;
            lblRHEADERS.Text = "HEADERS";
            // 
            // lblRESPONSE
            // 
            lblRESPONSE.AutoSize = true;
            lblRESPONSE.Font = new Font("Bahnschrift Condensed", 22F);
            lblRESPONSE.ForeColor = SystemColors.ActiveBorder;
            lblRESPONSE.Location = new Point(742, 1);
            lblRESPONSE.Name = "lblRESPONSE";
            lblRESPONSE.Size = new Size(117, 36);
            lblRESPONSE.TabIndex = 38;
            lblRESPONSE.Text = "RESPONSE";
            // 
            // HttpRequest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 36, 36);
            ClientSize = new Size(1063, 626);
            Controls.Add(lblREQUEST);
            Controls.Add(lblRESPONSE);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HttpRequest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HttpRequest";
            Load += HttpRequest_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label lblREQUEST;
        private ReaLTaiizor.Controls.ForeverTextBox txtURL;
        private ReaLTaiizor.Controls.ForeverComboBox cmbREQUESTTYPE;
        private RichTextBox rtxtCONTENT;
        private Label lblCONTENTBODY;
        private RichTextBox rtxtCOOKIES;
        private Label lblCOOKIES;
        private RichTextBox rtxtHEADERS;
        private Label lblHEADERS;
        private ReaLTaiizor.Controls.LostButton btnSENDREQ;
        private ReaLTaiizor.Controls.ForeverComboBox cmbCONTENTTYPE;
        private Panel panel2;
        private Label lblMSS;
        private Label lblMS;
        private Label lblSTATUSCODE;
        private Label lblSTATUS;
        private Label lblRESPONSE;
        private RichTextBox rtxtrCONTENT;
        private RichTextBox rtxtrCOOKIES;
        private Label lblRCONTENTBODY;
        private Label lblRCOOKIES;
        private RichTextBox rtxtrHEADERS;
        private Label lblRHEADERS;
    }
}