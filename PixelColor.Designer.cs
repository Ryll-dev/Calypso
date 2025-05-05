namespace Calypso
{
    partial class PixelColor
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
            lblRGB = new Label();
            lblHEX = new Label();
            lblPOSITION = new Label();
            lblRGBVALUE = new Label();
            lblHEXVALUE = new Label();
            lblPOSVALUE = new Label();
            pnlCOLOR = new Panel();
            imgLIVESCREEN = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)imgLIVESCREEN).BeginInit();
            SuspendLayout();
            // 
            // lblRGB
            // 
            lblRGB.AutoSize = true;
            lblRGB.Font = new Font("Bahnschrift Condensed", 18F);
            lblRGB.ForeColor = SystemColors.ActiveBorder;
            lblRGB.Location = new Point(12, 9);
            lblRGB.Name = "lblRGB";
            lblRGB.Size = new Size(49, 29);
            lblRGB.TabIndex = 0;
            lblRGB.Text = "RGB:";
            // 
            // lblHEX
            // 
            lblHEX.AutoSize = true;
            lblHEX.Font = new Font("Bahnschrift Condensed", 18F);
            lblHEX.ForeColor = SystemColors.ActiveBorder;
            lblHEX.Location = new Point(12, 48);
            lblHEX.Name = "lblHEX";
            lblHEX.Size = new Size(46, 29);
            lblHEX.TabIndex = 1;
            lblHEX.Text = "HEX:";
            // 
            // lblPOSITION
            // 
            lblPOSITION.AutoSize = true;
            lblPOSITION.Font = new Font("Bahnschrift Condensed", 18F);
            lblPOSITION.ForeColor = SystemColors.ActiveBorder;
            lblPOSITION.Location = new Point(12, 84);
            lblPOSITION.Name = "lblPOSITION";
            lblPOSITION.Size = new Size(89, 29);
            lblPOSITION.TabIndex = 2;
            lblPOSITION.Text = "POSITION:";
            // 
            // lblRGBVALUE
            // 
            lblRGBVALUE.AutoSize = true;
            lblRGBVALUE.Font = new Font("Bahnschrift Condensed", 18F);
            lblRGBVALUE.ForeColor = SystemColors.ActiveBorder;
            lblRGBVALUE.Location = new Point(58, 9);
            lblRGBVALUE.Name = "lblRGBVALUE";
            lblRGBVALUE.Size = new Size(107, 29);
            lblRGBVALUE.TabIndex = 3;
            lblRGBVALUE.Text = "180, 180, 180";
            // 
            // lblHEXVALUE
            // 
            lblHEXVALUE.AutoSize = true;
            lblHEXVALUE.Font = new Font("Bahnschrift Condensed", 18F);
            lblHEXVALUE.ForeColor = SystemColors.ActiveBorder;
            lblHEXVALUE.Location = new Point(54, 48);
            lblHEXVALUE.Name = "lblHEXVALUE";
            lblHEXVALUE.Size = new Size(82, 29);
            lblHEXVALUE.TabIndex = 4;
            lblHEXVALUE.Text = "#FF0000";
            // 
            // lblPOSVALUE
            // 
            lblPOSVALUE.AutoSize = true;
            lblPOSVALUE.Font = new Font("Bahnschrift Condensed", 18F);
            lblPOSVALUE.ForeColor = SystemColors.ActiveBorder;
            lblPOSVALUE.Location = new Point(96, 84);
            lblPOSVALUE.Name = "lblPOSVALUE";
            lblPOSVALUE.Size = new Size(93, 29);
            lblPOSVALUE.TabIndex = 5;
            lblPOSVALUE.Text = "1920x1080";
            // 
            // pnlCOLOR
            // 
            pnlCOLOR.Location = new Point(206, 9);
            pnlCOLOR.Name = "pnlCOLOR";
            pnlCOLOR.Size = new Size(100, 100);
            pnlCOLOR.TabIndex = 6;
            // 
            // imgLIVESCREEN
            // 
            imgLIVESCREEN.Location = new Point(318, 9);
            imgLIVESCREEN.Name = "imgLIVESCREEN";
            imgLIVESCREEN.Size = new Size(100, 100);
            imgLIVESCREEN.TabIndex = 7;
            imgLIVESCREEN.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Location = new Point(368, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(2, 47);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.Location = new Point(368, 62);
            panel2.Name = "panel2";
            panel2.Size = new Size(2, 47);
            panel2.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Red;
            panel3.Location = new Point(318, 57);
            panel3.Name = "panel3";
            panel3.Size = new Size(47, 2);
            panel3.TabIndex = 9;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Red;
            panel4.Location = new Point(373, 57);
            panel4.Name = "panel4";
            panel4.Size = new Size(47, 2);
            panel4.TabIndex = 10;
            // 
            // PixelColor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 36, 36);
            ClientSize = new Size(430, 122);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(imgLIVESCREEN);
            Controls.Add(pnlCOLOR);
            Controls.Add(lblPOSVALUE);
            Controls.Add(lblHEXVALUE);
            Controls.Add(lblRGBVALUE);
            Controls.Add(lblPOSITION);
            Controls.Add(lblHEX);
            Controls.Add(lblRGB);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PixelColor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PixelColor";
            ((System.ComponentModel.ISupportInitialize)imgLIVESCREEN).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRGB;
        private Label lblHEX;
        private Label lblPOSITION;
        private Label lblRGBVALUE;
        private Label lblHEXVALUE;
        private Label lblPOSVALUE;
        private Panel pnlCOLOR;
        private PictureBox imgLIVESCREEN;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}