namespace Calypso
{
    partial class CustomTaskbar
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
            pnlCUSTOMTASKBAR = new Panel();
            switchISACTIVE = new ReaLTaiizor.Controls.CyberSwitch();
            lblIMAGESEARCH = new Label();
            lblCUSTOMTASKBAR = new Label();
            pnlCUSTOMTASKBAR.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCUSTOMTASKBAR
            // 
            pnlCUSTOMTASKBAR.BackColor = Color.Transparent;
            pnlCUSTOMTASKBAR.BackgroundImageLayout = ImageLayout.None;
            pnlCUSTOMTASKBAR.Controls.Add(switchISACTIVE);
            pnlCUSTOMTASKBAR.Controls.Add(lblIMAGESEARCH);
            pnlCUSTOMTASKBAR.ForeColor = Color.Black;
            pnlCUSTOMTASKBAR.Location = new Point(12, 22);
            pnlCUSTOMTASKBAR.Name = "pnlCUSTOMTASKBAR";
            pnlCUSTOMTASKBAR.Size = new Size(806, 411);
            pnlCUSTOMTASKBAR.TabIndex = 41;
            // 
            // switchISACTIVE
            // 
            switchISACTIVE.Alpha = 50;
            switchISACTIVE.BackColor = Color.Transparent;
            switchISACTIVE.Background = true;
            switchISACTIVE.Background_WidthPen = 2F;
            switchISACTIVE.BackgroundPen = true;
            switchISACTIVE.Checked = false;
            switchISACTIVE.ColorBackground = Color.FromArgb(25, 25, 25);
            switchISACTIVE.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            switchISACTIVE.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            switchISACTIVE.ColorBackground_Pen = Color.Black;
            switchISACTIVE.ColorBackground_Value_1 = Color.FromArgb(28, 200, 238);
            switchISACTIVE.ColorBackground_Value_2 = Color.FromArgb(100, 208, 232);
            switchISACTIVE.ColorLighting = Color.FromArgb(29, 200, 238);
            switchISACTIVE.ColorPen_1 = Color.FromArgb(37, 52, 68);
            switchISACTIVE.ColorPen_2 = Color.FromArgb(41, 63, 86);
            switchISACTIVE.ColorValue = Color.Black;
            switchISACTIVE.CyberSwitchStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            switchISACTIVE.Font = new Font("Arial", 11F);
            switchISACTIVE.ForeColor = Color.FromArgb(245, 245, 245);
            switchISACTIVE.Lighting = false;
            switchISACTIVE.LinearGradient_Background = false;
            switchISACTIVE.LinearGradient_Value = false;
            switchISACTIVE.LinearGradientPen = false;
            switchISACTIVE.Location = new Point(22, 43);
            switchISACTIVE.Name = "switchISACTIVE";
            switchISACTIVE.PenWidth = 10;
            switchISACTIVE.RGB = false;
            switchISACTIVE.Rounding = true;
            switchISACTIVE.RoundingInt = 90;
            switchISACTIVE.Size = new Size(40, 20);
            switchISACTIVE.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            switchISACTIVE.TabIndex = 46;
            switchISACTIVE.Tag = "Cyber";
            switchISACTIVE.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            switchISACTIVE.Timer_RGB = 300;
            // 
            // lblIMAGESEARCH
            // 
            lblIMAGESEARCH.AutoSize = true;
            lblIMAGESEARCH.Font = new Font("Bahnschrift Condensed", 15F);
            lblIMAGESEARCH.ForeColor = SystemColors.ActiveBorder;
            lblIMAGESEARCH.Location = new Point(68, 39);
            lblIMAGESEARCH.Name = "lblIMAGESEARCH";
            lblIMAGESEARCH.Size = new Size(52, 24);
            lblIMAGESEARCH.TabIndex = 47;
            lblIMAGESEARCH.Text = "Active";
            // 
            // lblCUSTOMTASKBAR
            // 
            lblCUSTOMTASKBAR.AutoSize = true;
            lblCUSTOMTASKBAR.Font = new Font("Bahnschrift Condensed", 22F);
            lblCUSTOMTASKBAR.ForeColor = SystemColors.ActiveBorder;
            lblCUSTOMTASKBAR.Location = new Point(340, 4);
            lblCUSTOMTASKBAR.Name = "lblCUSTOMTASKBAR";
            lblCUSTOMTASKBAR.Size = new Size(191, 36);
            lblCUSTOMTASKBAR.TabIndex = 48;
            lblCUSTOMTASKBAR.Text = "CUSTOM TASK BAR";
            // 
            // CustomTaskbar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 36, 36);
            ClientSize = new Size(830, 450);
            Controls.Add(lblCUSTOMTASKBAR);
            Controls.Add(pnlCUSTOMTASKBAR);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomTaskbar";
            Text = "CustomTaskbar";
            Load += CustomTaskbar_Load;
            pnlCUSTOMTASKBAR.ResumeLayout(false);
            pnlCUSTOMTASKBAR.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlCUSTOMTASKBAR;
        private ReaLTaiizor.Controls.CyberSwitch switchISACTIVE;
        private Label lblIMAGESEARCH;
        private Label lblCUSTOMTASKBAR;
    }
}