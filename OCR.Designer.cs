namespace Calypso
{
    partial class OCR
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
            pctrboxIMAGE = new PictureBox();
            pnlOCR = new Panel();
            btnPASTEIMAGE = new ReaLTaiizor.Controls.LostButton();
            btnSELECTIMAGE = new ReaLTaiizor.Controls.LostButton();
            btnIMGTOTEXT = new ReaLTaiizor.Controls.LostButton();
            rtxtRESULTS = new RichTextBox();
            lblOCR = new Label();
            ((System.ComponentModel.ISupportInitialize)pctrboxIMAGE).BeginInit();
            pnlOCR.SuspendLayout();
            SuspendLayout();
            // 
            // pctrboxIMAGE
            // 
            pctrboxIMAGE.BorderStyle = BorderStyle.FixedSingle;
            pctrboxIMAGE.Location = new Point(19, 24);
            pctrboxIMAGE.Name = "pctrboxIMAGE";
            pctrboxIMAGE.Size = new Size(410, 154);
            pctrboxIMAGE.SizeMode = PictureBoxSizeMode.StretchImage;
            pctrboxIMAGE.TabIndex = 0;
            pctrboxIMAGE.TabStop = false;
            // 
            // pnlOCR
            // 
            pnlOCR.BackColor = Color.Transparent;
            pnlOCR.BackgroundImageLayout = ImageLayout.None;
            pnlOCR.Controls.Add(btnPASTEIMAGE);
            pnlOCR.Controls.Add(btnSELECTIMAGE);
            pnlOCR.Controls.Add(btnIMGTOTEXT);
            pnlOCR.Controls.Add(rtxtRESULTS);
            pnlOCR.Controls.Add(pctrboxIMAGE);
            pnlOCR.ForeColor = Color.Black;
            pnlOCR.Location = new Point(12, 21);
            pnlOCR.Name = "pnlOCR";
            pnlOCR.Size = new Size(449, 413);
            pnlOCR.TabIndex = 41;
            // 
            // btnPASTEIMAGE
            // 
            btnPASTEIMAGE.BackColor = Color.FromArgb(25, 25, 25);
            btnPASTEIMAGE.Font = new Font("Bahnschrift Condensed", 14F);
            btnPASTEIMAGE.ForeColor = SystemColors.ActiveBorder;
            btnPASTEIMAGE.HoverColor = Color.FromArgb(20, 20, 20);
            btnPASTEIMAGE.Image = null;
            btnPASTEIMAGE.Location = new Point(19, 155);
            btnPASTEIMAGE.Name = "btnPASTEIMAGE";
            btnPASTEIMAGE.Size = new Size(93, 23);
            btnPASTEIMAGE.TabIndex = 45;
            btnPASTEIMAGE.Text = "Paste Image";
            btnPASTEIMAGE.Click += btnPASTEIMAGE_Click;
            // 
            // btnSELECTIMAGE
            // 
            btnSELECTIMAGE.BackColor = Color.FromArgb(25, 25, 25);
            btnSELECTIMAGE.Font = new Font("Bahnschrift Condensed", 14F);
            btnSELECTIMAGE.ForeColor = SystemColors.ActiveBorder;
            btnSELECTIMAGE.HoverColor = Color.FromArgb(20, 20, 20);
            btnSELECTIMAGE.Image = null;
            btnSELECTIMAGE.Location = new Point(336, 155);
            btnSELECTIMAGE.Name = "btnSELECTIMAGE";
            btnSELECTIMAGE.Size = new Size(93, 23);
            btnSELECTIMAGE.TabIndex = 44;
            btnSELECTIMAGE.Text = "Select Image";
            btnSELECTIMAGE.Click += btnSELECTIMAGE_Click;
            // 
            // btnIMGTOTEXT
            // 
            btnIMGTOTEXT.BackColor = Color.FromArgb(25, 25, 25);
            btnIMGTOTEXT.Font = new Font("Bahnschrift Condensed", 14F);
            btnIMGTOTEXT.ForeColor = SystemColors.ActiveBorder;
            btnIMGTOTEXT.HoverColor = Color.FromArgb(20, 20, 20);
            btnIMGTOTEXT.Image = null;
            btnIMGTOTEXT.Location = new Point(19, 196);
            btnIMGTOTEXT.Name = "btnIMGTOTEXT";
            btnIMGTOTEXT.Size = new Size(410, 35);
            btnIMGTOTEXT.TabIndex = 43;
            btnIMGTOTEXT.Text = "Img to Text";
            btnIMGTOTEXT.Click += btnIMGTOTEXT_Click;
            // 
            // rtxtRESULTS
            // 
            rtxtRESULTS.BackColor = Color.FromArgb(25, 25, 25);
            rtxtRESULTS.BorderStyle = BorderStyle.None;
            rtxtRESULTS.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            rtxtRESULTS.ForeColor = SystemColors.ActiveBorder;
            rtxtRESULTS.Location = new Point(19, 251);
            rtxtRESULTS.Name = "rtxtRESULTS";
            rtxtRESULTS.ReadOnly = true;
            rtxtRESULTS.Size = new Size(410, 147);
            rtxtRESULTS.TabIndex = 42;
            rtxtRESULTS.Text = "";
            // 
            // lblOCR
            // 
            lblOCR.AutoSize = true;
            lblOCR.Font = new Font("Bahnschrift Condensed", 22F);
            lblOCR.ForeColor = SystemColors.ActiveBorder;
            lblOCR.Location = new Point(215, 2);
            lblOCR.Name = "lblOCR";
            lblOCR.Size = new Size(55, 36);
            lblOCR.TabIndex = 44;
            lblOCR.Text = "OCR";
            // 
            // OCR
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 36, 36);
            ClientSize = new Size(473, 446);
            Controls.Add(lblOCR);
            Controls.Add(pnlOCR);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OCR";
            Text = "OCR";
            Load += OCR_Load;
            Shown += OCR_Shown;
            ((System.ComponentModel.ISupportInitialize)pctrboxIMAGE).EndInit();
            pnlOCR.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pctrboxIMAGE;
        private Panel pnlOCR;
        private RichTextBox rtxtRESULTS;
        private ReaLTaiizor.Controls.LostButton btnIMGTOTEXT;
        private Label lblOCR;
        private ReaLTaiizor.Controls.LostButton btnPASTEIMAGE;
        private ReaLTaiizor.Controls.LostButton btnSELECTIMAGE;
    }
}