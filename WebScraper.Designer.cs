namespace Calypso
{
    partial class WebScraper
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
            btnSCRAPE = new ReaLTaiizor.Controls.LostButton();
            prgrsbarSCRAPER = new ReaLTaiizor.Controls.CircleProgressBar();
            pnlSETTINGS = new Panel();
            txtSETTING = new ReaLTaiizor.Controls.ForeverTextBox();
            lstboxSETTINGS = new ReaLTaiizor.Controls.MetroListBox();
            btnDELETESETTING = new ReaLTaiizor.Controls.LostButton();
            btnSAVESETTING = new ReaLTaiizor.Controls.LostButton();
            lblSETTINGS = new Label();
            pnlLINKS = new Panel();
            txtLINK = new ReaLTaiizor.Controls.ForeverTextBox();
            btnDELETELINK = new ReaLTaiizor.Controls.LostButton();
            btnADDLINK = new ReaLTaiizor.Controls.LostButton();
            lstboxLINKS = new ReaLTaiizor.Controls.MetroListBox();
            lblLINKS = new Label();
            pnlSCRAPER = new Panel();
            switchIMAGESEARCH = new ReaLTaiizor.Controls.CyberSwitch();
            lblIMAGESEARCH = new Label();
            cmbTIMEFILTER = new ReaLTaiizor.Controls.ForeverComboBox();
            txtREGEX = new ReaLTaiizor.Controls.ForeverTextBox();
            lblTEXT = new Label();
            txtTEXT = new ReaLTaiizor.Controls.ForeverTextBox();
            switchREGEXSEARCH = new ReaLTaiizor.Controls.CyberSwitch();
            lblREGEXSEARCH = new Label();
            lblREGEX = new Label();
            lblSCRAPER = new Label();
            pnlRESULTS = new Panel();
            lblRESULTS = new Label();
            lblRESULTCOUNT = new Label();
            lblBLACKLISTWORDS = new Label();
            panel1 = new Panel();
            btnDELETEBLACKLISTWORD = new ReaLTaiizor.Controls.LostButton();
            txtBLACKLISTWORD = new ReaLTaiizor.Controls.ForeverTextBox();
            lstboxBLACKLISTWORDS = new ReaLTaiizor.Controls.MetroListBox();
            btnADDBLACKLISTWORD = new ReaLTaiizor.Controls.LostButton();
            label1 = new Label();
            panel2 = new Panel();
            btnCHECKPROXIES = new ReaLTaiizor.Controls.LostButton();
            btnAUTLOADPROXIES = new ReaLTaiizor.Controls.LostButton();
            rtxtPROXIES = new RichTextBox();
            lblTOTALPROXIES = new Label();
            pnlLINE = new Panel();
            btnCLEARPROXIE = new ReaLTaiizor.Controls.LostButton();
            lstboxPROXIES = new ReaLTaiizor.Controls.MetroListBox();
            btnADDPROXIE = new ReaLTaiizor.Controls.LostButton();
            pnlSETTINGS.SuspendLayout();
            pnlLINKS.SuspendLayout();
            pnlSCRAPER.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnSCRAPE
            // 
            btnSCRAPE.BackColor = Color.FromArgb(25, 25, 25);
            btnSCRAPE.Font = new Font("Bahnschrift Condensed", 14F);
            btnSCRAPE.ForeColor = SystemColors.ActiveBorder;
            btnSCRAPE.HoverColor = Color.FromArgb(20, 20, 20);
            btnSCRAPE.Image = null;
            btnSCRAPE.Location = new Point(12, 317);
            btnSCRAPE.Name = "btnSCRAPE";
            btnSCRAPE.Size = new Size(197, 35);
            btnSCRAPE.TabIndex = 33;
            btnSCRAPE.Text = "Scrape";
            btnSCRAPE.Click += btnSCRAPE_Click;
            // 
            // prgrsbarSCRAPER
            // 
            prgrsbarSCRAPER.BackColor = Color.FromArgb(36, 36, 36);
            prgrsbarSCRAPER.Font = new Font("Segoe UI", 15F);
            prgrsbarSCRAPER.Location = new Point(50, 198);
            prgrsbarSCRAPER.Maximum = 100L;
            prgrsbarSCRAPER.MinimumSize = new Size(100, 100);
            prgrsbarSCRAPER.Name = "prgrsbarSCRAPER";
            prgrsbarSCRAPER.PercentColor = SystemColors.ActiveBorder;
            prgrsbarSCRAPER.ProgressColor1 = Color.Blue;
            prgrsbarSCRAPER.ProgressColor2 = Color.Purple;
            prgrsbarSCRAPER.ProgressShape = ReaLTaiizor.Controls.CircleProgressBar._ProgressShape.Round;
            prgrsbarSCRAPER.Size = new Size(113, 113);
            prgrsbarSCRAPER.TabIndex = 34;
            prgrsbarSCRAPER.Text = "circleProgressBar1";
            prgrsbarSCRAPER.Value = 0L;
            // 
            // pnlSETTINGS
            // 
            pnlSETTINGS.BackColor = Color.Transparent;
            pnlSETTINGS.BackgroundImageLayout = ImageLayout.None;
            pnlSETTINGS.Controls.Add(txtSETTING);
            pnlSETTINGS.Controls.Add(lstboxSETTINGS);
            pnlSETTINGS.Controls.Add(btnDELETESETTING);
            pnlSETTINGS.Controls.Add(btnSAVESETTING);
            pnlSETTINGS.ForeColor = Color.Black;
            pnlSETTINGS.Location = new Point(12, 22);
            pnlSETTINGS.Name = "pnlSETTINGS";
            pnlSETTINGS.Size = new Size(162, 363);
            pnlSETTINGS.TabIndex = 37;
            // 
            // txtSETTING
            // 
            txtSETTING.BackColor = Color.Transparent;
            txtSETTING.BaseColor = Color.FromArgb(25, 25, 25);
            txtSETTING.BorderColor = Color.FromArgb(20, 20, 20);
            txtSETTING.FocusOnHover = false;
            txtSETTING.Font = new Font("Bahnschrift Condensed", 12F);
            txtSETTING.ForeColor = SystemColors.ActiveBorder;
            txtSETTING.Location = new Point(7, 291);
            txtSETTING.MaxLength = 32767;
            txtSETTING.Multiline = false;
            txtSETTING.Name = "txtSETTING";
            txtSETTING.ReadOnly = false;
            txtSETTING.Size = new Size(145, 31);
            txtSETTING.TabIndex = 46;
            txtSETTING.TextAlign = HorizontalAlignment.Left;
            txtSETTING.UseSystemPasswordChar = false;
            // 
            // lstboxSETTINGS
            // 
            lstboxSETTINGS.BackColor = Color.White;
            lstboxSETTINGS.BorderColor = Color.LightGray;
            lstboxSETTINGS.DisabledBackColor = Color.FromArgb(204, 204, 204);
            lstboxSETTINGS.DisabledForeColor = Color.FromArgb(136, 136, 136);
            lstboxSETTINGS.Font = new Font("Bahnschrift Condensed", 15F);
            lstboxSETTINGS.HoveredItemBackColor = Color.LightGray;
            lstboxSETTINGS.HoveredItemColor = Color.DimGray;
            lstboxSETTINGS.IsDerivedStyle = true;
            lstboxSETTINGS.ItemHeight = 30;
            lstboxSETTINGS.Location = new Point(7, 19);
            lstboxSETTINGS.MultiSelect = false;
            lstboxSETTINGS.Name = "lstboxSETTINGS";
            lstboxSETTINGS.SelectedIndex = -1;
            lstboxSETTINGS.SelectedItem = null;
            lstboxSETTINGS.SelectedItemBackColor = Color.FromArgb(65, 177, 225);
            lstboxSETTINGS.SelectedItemColor = Color.White;
            lstboxSETTINGS.SelectedText = null;
            lstboxSETTINGS.SelectedValue = null;
            lstboxSETTINGS.ShowBorder = false;
            lstboxSETTINGS.ShowScrollBar = false;
            lstboxSETTINGS.Size = new Size(145, 266);
            lstboxSETTINGS.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            lstboxSETTINGS.StyleManager = null;
            lstboxSETTINGS.TabIndex = 35;
            lstboxSETTINGS.ThemeAuthor = "Taiizor";
            lstboxSETTINGS.ThemeName = "MetroLight";
            lstboxSETTINGS.SelectedIndexChanged += lstboxSETTINGS_SelectedIndexChanged;
            // 
            // btnDELETESETTING
            // 
            btnDELETESETTING.BackColor = Color.FromArgb(25, 25, 25);
            btnDELETESETTING.Font = new Font("Bahnschrift Condensed", 14F);
            btnDELETESETTING.ForeColor = SystemColors.ActiveBorder;
            btnDELETESETTING.HoverColor = Color.FromArgb(20, 20, 20);
            btnDELETESETTING.Image = null;
            btnDELETESETTING.Location = new Point(80, 328);
            btnDELETESETTING.Name = "btnDELETESETTING";
            btnDELETESETTING.Size = new Size(72, 24);
            btnDELETESETTING.TabIndex = 34;
            btnDELETESETTING.Text = "Delete";
            btnDELETESETTING.Click += btnDELETESETTING_Click;
            // 
            // btnSAVESETTING
            // 
            btnSAVESETTING.BackColor = Color.FromArgb(25, 25, 25);
            btnSAVESETTING.Font = new Font("Bahnschrift Condensed", 14F);
            btnSAVESETTING.ForeColor = SystemColors.ActiveBorder;
            btnSAVESETTING.HoverColor = Color.FromArgb(20, 20, 20);
            btnSAVESETTING.Image = null;
            btnSAVESETTING.Location = new Point(7, 328);
            btnSAVESETTING.Name = "btnSAVESETTING";
            btnSAVESETTING.Size = new Size(72, 24);
            btnSAVESETTING.TabIndex = 33;
            btnSAVESETTING.Text = "Save";
            btnSAVESETTING.Click += btnSAVESETTING_Click;
            // 
            // lblSETTINGS
            // 
            lblSETTINGS.AutoSize = true;
            lblSETTINGS.Font = new Font("Bahnschrift Condensed", 22F);
            lblSETTINGS.ForeColor = SystemColors.ActiveBorder;
            lblSETTINGS.Location = new Point(42, 3);
            lblSETTINGS.Name = "lblSETTINGS";
            lblSETTINGS.Size = new Size(107, 36);
            lblSETTINGS.TabIndex = 32;
            lblSETTINGS.Text = "SETTINGS";
            // 
            // pnlLINKS
            // 
            pnlLINKS.BackColor = Color.Transparent;
            pnlLINKS.BackgroundImageLayout = ImageLayout.None;
            pnlLINKS.Controls.Add(txtLINK);
            pnlLINKS.Controls.Add(btnDELETELINK);
            pnlLINKS.Controls.Add(btnADDLINK);
            pnlLINKS.Controls.Add(lstboxLINKS);
            pnlLINKS.ForeColor = Color.Black;
            pnlLINKS.Location = new Point(180, 22);
            pnlLINKS.Name = "pnlLINKS";
            pnlLINKS.Size = new Size(183, 363);
            pnlLINKS.TabIndex = 38;
            // 
            // txtLINK
            // 
            txtLINK.BackColor = Color.Transparent;
            txtLINK.BaseColor = Color.FromArgb(25, 25, 25);
            txtLINK.BorderColor = Color.FromArgb(20, 20, 20);
            txtLINK.FocusOnHover = false;
            txtLINK.Font = new Font("Bahnschrift Condensed", 12F);
            txtLINK.ForeColor = SystemColors.ActiveBorder;
            txtLINK.Location = new Point(8, 291);
            txtLINK.MaxLength = 32767;
            txtLINK.Multiline = false;
            txtLINK.Name = "txtLINK";
            txtLINK.ReadOnly = false;
            txtLINK.Size = new Size(164, 31);
            txtLINK.TabIndex = 47;
            txtLINK.TextAlign = HorizontalAlignment.Left;
            txtLINK.UseSystemPasswordChar = false;
            // 
            // btnDELETELINK
            // 
            btnDELETELINK.BackColor = Color.FromArgb(25, 25, 25);
            btnDELETELINK.Font = new Font("Bahnschrift Condensed", 14F);
            btnDELETELINK.ForeColor = SystemColors.ActiveBorder;
            btnDELETELINK.HoverColor = Color.FromArgb(20, 20, 20);
            btnDELETELINK.Image = null;
            btnDELETELINK.Location = new Point(92, 328);
            btnDELETELINK.Name = "btnDELETELINK";
            btnDELETELINK.Size = new Size(80, 24);
            btnDELETELINK.TabIndex = 37;
            btnDELETELINK.Text = "Delete";
            btnDELETELINK.Click += btnDELETELINK_Click;
            // 
            // btnADDLINK
            // 
            btnADDLINK.BackColor = Color.FromArgb(25, 25, 25);
            btnADDLINK.Font = new Font("Bahnschrift Condensed", 14F);
            btnADDLINK.ForeColor = SystemColors.ActiveBorder;
            btnADDLINK.HoverColor = Color.FromArgb(20, 20, 20);
            btnADDLINK.Image = null;
            btnADDLINK.Location = new Point(8, 328);
            btnADDLINK.Name = "btnADDLINK";
            btnADDLINK.Size = new Size(80, 24);
            btnADDLINK.TabIndex = 36;
            btnADDLINK.Text = "Add";
            btnADDLINK.Click += btnADDLINK_Click;
            // 
            // lstboxLINKS
            // 
            lstboxLINKS.BackColor = Color.White;
            lstboxLINKS.BorderColor = Color.LightGray;
            lstboxLINKS.DisabledBackColor = Color.FromArgb(204, 204, 204);
            lstboxLINKS.DisabledForeColor = Color.FromArgb(136, 136, 136);
            lstboxLINKS.Font = new Font("Bahnschrift Condensed", 15F);
            lstboxLINKS.HoveredItemBackColor = Color.LightGray;
            lstboxLINKS.HoveredItemColor = Color.DimGray;
            lstboxLINKS.IsDerivedStyle = true;
            lstboxLINKS.ItemHeight = 30;
            lstboxLINKS.Location = new Point(8, 19);
            lstboxLINKS.MultiSelect = false;
            lstboxLINKS.Name = "lstboxLINKS";
            lstboxLINKS.SelectedIndex = -1;
            lstboxLINKS.SelectedItem = null;
            lstboxLINKS.SelectedItemBackColor = Color.FromArgb(65, 177, 225);
            lstboxLINKS.SelectedItemColor = Color.White;
            lstboxLINKS.SelectedText = null;
            lstboxLINKS.SelectedValue = null;
            lstboxLINKS.ShowBorder = false;
            lstboxLINKS.ShowScrollBar = false;
            lstboxLINKS.Size = new Size(164, 266);
            lstboxLINKS.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            lstboxLINKS.StyleManager = null;
            lstboxLINKS.TabIndex = 35;
            lstboxLINKS.ThemeAuthor = "Taiizor";
            lstboxLINKS.ThemeName = "MetroLight";
            // 
            // lblLINKS
            // 
            lblLINKS.AutoSize = true;
            lblLINKS.Font = new Font("Bahnschrift Condensed", 22F);
            lblLINKS.ForeColor = SystemColors.ActiveBorder;
            lblLINKS.Location = new Point(236, 3);
            lblLINKS.Name = "lblLINKS";
            lblLINKS.Size = new Size(70, 36);
            lblLINKS.TabIndex = 32;
            lblLINKS.Text = "LINKS";
            // 
            // pnlSCRAPER
            // 
            pnlSCRAPER.BackColor = Color.Transparent;
            pnlSCRAPER.BackgroundImageLayout = ImageLayout.None;
            pnlSCRAPER.Controls.Add(switchIMAGESEARCH);
            pnlSCRAPER.Controls.Add(lblIMAGESEARCH);
            pnlSCRAPER.Controls.Add(cmbTIMEFILTER);
            pnlSCRAPER.Controls.Add(txtREGEX);
            pnlSCRAPER.Controls.Add(lblTEXT);
            pnlSCRAPER.Controls.Add(txtTEXT);
            pnlSCRAPER.Controls.Add(switchREGEXSEARCH);
            pnlSCRAPER.Controls.Add(lblREGEXSEARCH);
            pnlSCRAPER.Controls.Add(btnSCRAPE);
            pnlSCRAPER.Controls.Add(prgrsbarSCRAPER);
            pnlSCRAPER.Controls.Add(lblREGEX);
            pnlSCRAPER.ForeColor = Color.Black;
            pnlSCRAPER.Location = new Point(801, 22);
            pnlSCRAPER.Name = "pnlSCRAPER";
            pnlSCRAPER.Size = new Size(225, 363);
            pnlSCRAPER.TabIndex = 40;
            // 
            // switchIMAGESEARCH
            // 
            switchIMAGESEARCH.Alpha = 50;
            switchIMAGESEARCH.BackColor = Color.Transparent;
            switchIMAGESEARCH.Background = true;
            switchIMAGESEARCH.Background_WidthPen = 2F;
            switchIMAGESEARCH.BackgroundPen = true;
            switchIMAGESEARCH.Checked = false;
            switchIMAGESEARCH.ColorBackground = Color.FromArgb(25, 25, 25);
            switchIMAGESEARCH.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            switchIMAGESEARCH.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            switchIMAGESEARCH.ColorBackground_Pen = Color.Black;
            switchIMAGESEARCH.ColorBackground_Value_1 = Color.FromArgb(28, 200, 238);
            switchIMAGESEARCH.ColorBackground_Value_2 = Color.FromArgb(100, 208, 232);
            switchIMAGESEARCH.ColorLighting = Color.FromArgb(29, 200, 238);
            switchIMAGESEARCH.ColorPen_1 = Color.FromArgb(37, 52, 68);
            switchIMAGESEARCH.ColorPen_2 = Color.FromArgb(41, 63, 86);
            switchIMAGESEARCH.ColorValue = Color.Black;
            switchIMAGESEARCH.CyberSwitchStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            switchIMAGESEARCH.Font = new Font("Arial", 11F);
            switchIMAGESEARCH.ForeColor = Color.FromArgb(245, 245, 245);
            switchIMAGESEARCH.Lighting = false;
            switchIMAGESEARCH.LinearGradient_Background = false;
            switchIMAGESEARCH.LinearGradient_Value = false;
            switchIMAGESEARCH.LinearGradientPen = false;
            switchIMAGESEARCH.Location = new Point(169, 76);
            switchIMAGESEARCH.Name = "switchIMAGESEARCH";
            switchIMAGESEARCH.PenWidth = 10;
            switchIMAGESEARCH.RGB = false;
            switchIMAGESEARCH.Rounding = true;
            switchIMAGESEARCH.RoundingInt = 90;
            switchIMAGESEARCH.Size = new Size(40, 20);
            switchIMAGESEARCH.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            switchIMAGESEARCH.TabIndex = 46;
            switchIMAGESEARCH.Tag = "Cyber";
            switchIMAGESEARCH.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            switchIMAGESEARCH.Timer_RGB = 300;
            switchIMAGESEARCH.CheckedChanged += switchIMAGESEARCH_CheckedChanged;
            // 
            // lblIMAGESEARCH
            // 
            lblIMAGESEARCH.AutoSize = true;
            lblIMAGESEARCH.Font = new Font("Bahnschrift Condensed", 15F);
            lblIMAGESEARCH.ForeColor = SystemColors.ActiveBorder;
            lblIMAGESEARCH.Location = new Point(12, 72);
            lblIMAGESEARCH.Name = "lblIMAGESEARCH";
            lblIMAGESEARCH.Size = new Size(102, 24);
            lblIMAGESEARCH.TabIndex = 47;
            lblIMAGESEARCH.Text = "Image Search";
            // 
            // cmbTIMEFILTER
            // 
            cmbTIMEFILTER.BackColor = Color.FromArgb(25, 25, 25);
            cmbTIMEFILTER.BaseColor = Color.FromArgb(20, 20, 20);
            cmbTIMEFILTER.BGColor = Color.FromArgb(25, 25, 25);
            cmbTIMEFILTER.DrawMode = DrawMode.OwnerDrawFixed;
            cmbTIMEFILTER.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTIMEFILTER.Font = new Font("Bahnschrift Condensed", 12F);
            cmbTIMEFILTER.ForeColor = SystemColors.ActiveBorder;
            cmbTIMEFILTER.FormattingEnabled = true;
            cmbTIMEFILTER.HoverColor = Color.Black;
            cmbTIMEFILTER.HoverFontColor = Color.White;
            cmbTIMEFILTER.ItemHeight = 18;
            cmbTIMEFILTER.Items.AddRange(new object[] { "Last 24H", "Last 7D", "Last 4W", "Last 12M", "No Limit" });
            cmbTIMEFILTER.Location = new Point(12, 169);
            cmbTIMEFILTER.Name = "cmbTIMEFILTER";
            cmbTIMEFILTER.Size = new Size(197, 24);
            cmbTIMEFILTER.TabIndex = 45;
            // 
            // txtREGEX
            // 
            txtREGEX.BackColor = Color.Transparent;
            txtREGEX.BaseColor = Color.FromArgb(25, 25, 25);
            txtREGEX.BorderColor = Color.FromArgb(20, 20, 20);
            txtREGEX.Enabled = false;
            txtREGEX.FocusOnHover = false;
            txtREGEX.Font = new Font("Bahnschrift Condensed", 12F);
            txtREGEX.ForeColor = SystemColors.ActiveBorder;
            txtREGEX.Location = new Point(69, 132);
            txtREGEX.MaxLength = 32767;
            txtREGEX.Multiline = false;
            txtREGEX.Name = "txtREGEX";
            txtREGEX.ReadOnly = false;
            txtREGEX.Size = new Size(140, 31);
            txtREGEX.TabIndex = 43;
            txtREGEX.TextAlign = HorizontalAlignment.Left;
            txtREGEX.UseSystemPasswordChar = false;
            // 
            // lblTEXT
            // 
            lblTEXT.AutoSize = true;
            lblTEXT.Font = new Font("Bahnschrift Condensed", 15F);
            lblTEXT.ForeColor = SystemColors.ActiveBorder;
            lblTEXT.Location = new Point(12, 34);
            lblTEXT.Name = "lblTEXT";
            lblTEXT.Size = new Size(37, 24);
            lblTEXT.TabIndex = 42;
            lblTEXT.Text = "Text";
            // 
            // txtTEXT
            // 
            txtTEXT.BackColor = Color.Transparent;
            txtTEXT.BaseColor = Color.FromArgb(25, 25, 25);
            txtTEXT.BorderColor = Color.FromArgb(20, 20, 20);
            txtTEXT.FocusOnHover = false;
            txtTEXT.Font = new Font("Bahnschrift Condensed", 12F);
            txtTEXT.ForeColor = SystemColors.ActiveBorder;
            txtTEXT.Location = new Point(69, 34);
            txtTEXT.MaxLength = 32767;
            txtTEXT.Multiline = false;
            txtTEXT.Name = "txtTEXT";
            txtTEXT.ReadOnly = false;
            txtTEXT.Size = new Size(140, 31);
            txtTEXT.TabIndex = 41;
            txtTEXT.TextAlign = HorizontalAlignment.Left;
            txtTEXT.UseSystemPasswordChar = false;
            // 
            // switchREGEXSEARCH
            // 
            switchREGEXSEARCH.Alpha = 50;
            switchREGEXSEARCH.BackColor = Color.Transparent;
            switchREGEXSEARCH.Background = true;
            switchREGEXSEARCH.Background_WidthPen = 2F;
            switchREGEXSEARCH.BackgroundPen = true;
            switchREGEXSEARCH.Checked = false;
            switchREGEXSEARCH.ColorBackground = Color.FromArgb(25, 25, 25);
            switchREGEXSEARCH.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            switchREGEXSEARCH.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            switchREGEXSEARCH.ColorBackground_Pen = Color.Black;
            switchREGEXSEARCH.ColorBackground_Value_1 = Color.FromArgb(28, 200, 238);
            switchREGEXSEARCH.ColorBackground_Value_2 = Color.FromArgb(100, 208, 232);
            switchREGEXSEARCH.ColorLighting = Color.FromArgb(29, 200, 238);
            switchREGEXSEARCH.ColorPen_1 = Color.FromArgb(37, 52, 68);
            switchREGEXSEARCH.ColorPen_2 = Color.FromArgb(41, 63, 86);
            switchREGEXSEARCH.ColorValue = Color.Black;
            switchREGEXSEARCH.CyberSwitchStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            switchREGEXSEARCH.Font = new Font("Arial", 11F);
            switchREGEXSEARCH.ForeColor = Color.FromArgb(245, 245, 245);
            switchREGEXSEARCH.Lighting = false;
            switchREGEXSEARCH.LinearGradient_Background = false;
            switchREGEXSEARCH.LinearGradient_Value = false;
            switchREGEXSEARCH.LinearGradientPen = false;
            switchREGEXSEARCH.Location = new Point(169, 106);
            switchREGEXSEARCH.Name = "switchREGEXSEARCH";
            switchREGEXSEARCH.PenWidth = 10;
            switchREGEXSEARCH.RGB = false;
            switchREGEXSEARCH.Rounding = true;
            switchREGEXSEARCH.RoundingInt = 90;
            switchREGEXSEARCH.Size = new Size(40, 20);
            switchREGEXSEARCH.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            switchREGEXSEARCH.TabIndex = 37;
            switchREGEXSEARCH.Tag = "Cyber";
            switchREGEXSEARCH.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            switchREGEXSEARCH.Timer_RGB = 300;
            switchREGEXSEARCH.CheckedChanged += switchREGEXSEARCH_CheckedChanged;
            // 
            // lblREGEXSEARCH
            // 
            lblREGEXSEARCH.AutoSize = true;
            lblREGEXSEARCH.Font = new Font("Bahnschrift Condensed", 15F);
            lblREGEXSEARCH.ForeColor = SystemColors.ActiveBorder;
            lblREGEXSEARCH.Location = new Point(12, 102);
            lblREGEXSEARCH.Name = "lblREGEXSEARCH";
            lblREGEXSEARCH.Size = new Size(102, 24);
            lblREGEXSEARCH.TabIndex = 38;
            lblREGEXSEARCH.Text = "Regex Search";
            // 
            // lblREGEX
            // 
            lblREGEX.AutoSize = true;
            lblREGEX.Font = new Font("Bahnschrift Condensed", 15F);
            lblREGEX.ForeColor = SystemColors.ActiveBorder;
            lblREGEX.Location = new Point(12, 132);
            lblREGEX.Name = "lblREGEX";
            lblREGEX.Size = new Size(51, 24);
            lblREGEX.TabIndex = 44;
            lblREGEX.Text = "Regex";
            // 
            // lblSCRAPER
            // 
            lblSCRAPER.AutoSize = true;
            lblSCRAPER.Font = new Font("Bahnschrift Condensed", 22F);
            lblSCRAPER.ForeColor = SystemColors.ActiveBorder;
            lblSCRAPER.Location = new Point(861, 3);
            lblSCRAPER.Name = "lblSCRAPER";
            lblSCRAPER.Size = new Size(104, 36);
            lblSCRAPER.TabIndex = 32;
            lblSCRAPER.Text = "SCRAPER";
            // 
            // pnlRESULTS
            // 
            pnlRESULTS.Location = new Point(12, 403);
            pnlRESULTS.Name = "pnlRESULTS";
            pnlRESULTS.Size = new Size(1014, 368);
            pnlRESULTS.TabIndex = 42;
            // 
            // lblRESULTS
            // 
            lblRESULTS.AutoSize = true;
            lblRESULTS.Font = new Font("Bahnschrift Condensed", 22F);
            lblRESULTS.ForeColor = SystemColors.ActiveBorder;
            lblRESULTS.Location = new Point(475, 385);
            lblRESULTS.Name = "lblRESULTS";
            lblRESULTS.Size = new Size(97, 36);
            lblRESULTS.TabIndex = 43;
            lblRESULTS.Text = "RESULTS";
            // 
            // lblRESULTCOUNT
            // 
            lblRESULTCOUNT.AutoSize = true;
            lblRESULTCOUNT.Font = new Font("Bahnschrift Condensed", 22F);
            lblRESULTCOUNT.ForeColor = SystemColors.ActiveBorder;
            lblRESULTCOUNT.Location = new Point(960, 385);
            lblRESULTCOUNT.Name = "lblRESULTCOUNT";
            lblRESULTCOUNT.Size = new Size(27, 36);
            lblRESULTCOUNT.TabIndex = 44;
            lblRESULTCOUNT.Text = "0";
            lblRESULTCOUNT.Visible = false;
            // 
            // lblBLACKLISTWORDS
            // 
            lblBLACKLISTWORDS.AutoSize = true;
            lblBLACKLISTWORDS.Font = new Font("Bahnschrift Condensed", 22F);
            lblBLACKLISTWORDS.ForeColor = SystemColors.ActiveBorder;
            lblBLACKLISTWORDS.Location = new Point(378, 3);
            lblBLACKLISTWORDS.Name = "lblBLACKLISTWORDS";
            lblBLACKLISTWORDS.Size = new Size(193, 36);
            lblBLACKLISTWORDS.TabIndex = 46;
            lblBLACKLISTWORDS.Text = "BLACKLIST WORDS";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(btnDELETEBLACKLISTWORD);
            panel1.Controls.Add(txtBLACKLISTWORD);
            panel1.Controls.Add(lstboxBLACKLISTWORDS);
            panel1.Controls.Add(btnADDBLACKLISTWORD);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(369, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(210, 363);
            panel1.TabIndex = 47;
            // 
            // btnDELETEBLACKLISTWORD
            // 
            btnDELETEBLACKLISTWORD.BackColor = Color.FromArgb(25, 25, 25);
            btnDELETEBLACKLISTWORD.Font = new Font("Bahnschrift Condensed", 14F);
            btnDELETEBLACKLISTWORD.ForeColor = SystemColors.ActiveBorder;
            btnDELETEBLACKLISTWORD.HoverColor = Color.FromArgb(20, 20, 20);
            btnDELETEBLACKLISTWORD.Image = null;
            btnDELETEBLACKLISTWORD.Location = new Point(107, 328);
            btnDELETEBLACKLISTWORD.Name = "btnDELETEBLACKLISTWORD";
            btnDELETEBLACKLISTWORD.Size = new Size(94, 24);
            btnDELETEBLACKLISTWORD.TabIndex = 52;
            btnDELETEBLACKLISTWORD.Text = "Delete";
            btnDELETEBLACKLISTWORD.Click += btnDELETEBLACKLISTWORD_Click;
            // 
            // txtBLACKLISTWORD
            // 
            txtBLACKLISTWORD.BackColor = Color.Transparent;
            txtBLACKLISTWORD.BaseColor = Color.FromArgb(25, 25, 25);
            txtBLACKLISTWORD.BorderColor = Color.FromArgb(20, 20, 20);
            txtBLACKLISTWORD.FocusOnHover = false;
            txtBLACKLISTWORD.Font = new Font("Bahnschrift Condensed", 12F);
            txtBLACKLISTWORD.ForeColor = SystemColors.ActiveBorder;
            txtBLACKLISTWORD.Location = new Point(8, 291);
            txtBLACKLISTWORD.MaxLength = 32767;
            txtBLACKLISTWORD.Multiline = false;
            txtBLACKLISTWORD.Name = "txtBLACKLISTWORD";
            txtBLACKLISTWORD.ReadOnly = false;
            txtBLACKLISTWORD.Size = new Size(193, 31);
            txtBLACKLISTWORD.TabIndex = 51;
            txtBLACKLISTWORD.TextAlign = HorizontalAlignment.Left;
            txtBLACKLISTWORD.UseSystemPasswordChar = false;
            // 
            // lstboxBLACKLISTWORDS
            // 
            lstboxBLACKLISTWORDS.BackColor = Color.White;
            lstboxBLACKLISTWORDS.BorderColor = Color.LightGray;
            lstboxBLACKLISTWORDS.DisabledBackColor = Color.FromArgb(204, 204, 204);
            lstboxBLACKLISTWORDS.DisabledForeColor = Color.FromArgb(136, 136, 136);
            lstboxBLACKLISTWORDS.Font = new Font("Bahnschrift Condensed", 15F);
            lstboxBLACKLISTWORDS.HoveredItemBackColor = Color.LightGray;
            lstboxBLACKLISTWORDS.HoveredItemColor = Color.DimGray;
            lstboxBLACKLISTWORDS.IsDerivedStyle = true;
            lstboxBLACKLISTWORDS.ItemHeight = 30;
            lstboxBLACKLISTWORDS.Location = new Point(8, 19);
            lstboxBLACKLISTWORDS.MultiSelect = false;
            lstboxBLACKLISTWORDS.Name = "lstboxBLACKLISTWORDS";
            lstboxBLACKLISTWORDS.SelectedIndex = -1;
            lstboxBLACKLISTWORDS.SelectedItem = null;
            lstboxBLACKLISTWORDS.SelectedItemBackColor = Color.FromArgb(65, 177, 225);
            lstboxBLACKLISTWORDS.SelectedItemColor = Color.White;
            lstboxBLACKLISTWORDS.SelectedText = null;
            lstboxBLACKLISTWORDS.SelectedValue = null;
            lstboxBLACKLISTWORDS.ShowBorder = false;
            lstboxBLACKLISTWORDS.ShowScrollBar = false;
            lstboxBLACKLISTWORDS.Size = new Size(193, 266);
            lstboxBLACKLISTWORDS.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            lstboxBLACKLISTWORDS.StyleManager = null;
            lstboxBLACKLISTWORDS.TabIndex = 48;
            lstboxBLACKLISTWORDS.ThemeAuthor = "Taiizor";
            lstboxBLACKLISTWORDS.ThemeName = "MetroLight";
            // 
            // btnADDBLACKLISTWORD
            // 
            btnADDBLACKLISTWORD.BackColor = Color.FromArgb(25, 25, 25);
            btnADDBLACKLISTWORD.Font = new Font("Bahnschrift Condensed", 14F);
            btnADDBLACKLISTWORD.ForeColor = SystemColors.ActiveBorder;
            btnADDBLACKLISTWORD.HoverColor = Color.FromArgb(20, 20, 20);
            btnADDBLACKLISTWORD.Image = null;
            btnADDBLACKLISTWORD.Location = new Point(8, 328);
            btnADDBLACKLISTWORD.Name = "btnADDBLACKLISTWORD";
            btnADDBLACKLISTWORD.Size = new Size(94, 24);
            btnADDBLACKLISTWORD.TabIndex = 49;
            btnADDBLACKLISTWORD.Text = "Add";
            btnADDBLACKLISTWORD.Click += btnADDBLACKLISTWORD_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ActiveBorder;
            label1.Location = new Point(640, 3);
            label1.Name = "label1";
            label1.Size = new Size(93, 35);
            label1.TabIndex = 48;
            label1.Text = "PROXIES";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.Controls.Add(btnCHECKPROXIES);
            panel2.Controls.Add(btnAUTLOADPROXIES);
            panel2.Controls.Add(rtxtPROXIES);
            panel2.Controls.Add(lblTOTALPROXIES);
            panel2.Controls.Add(pnlLINE);
            panel2.Controls.Add(btnCLEARPROXIE);
            panel2.Controls.Add(lstboxPROXIES);
            panel2.Controls.Add(btnADDPROXIE);
            panel2.ForeColor = Color.Black;
            panel2.Location = new Point(585, 22);
            panel2.Name = "panel2";
            panel2.Size = new Size(210, 363);
            panel2.TabIndex = 49;
            // 
            // btnCHECKPROXIES
            // 
            btnCHECKPROXIES.BackColor = Color.FromArgb(25, 25, 25);
            btnCHECKPROXIES.Font = new Font("Bahnschrift Condensed", 14F);
            btnCHECKPROXIES.ForeColor = SystemColors.ActiveBorder;
            btnCHECKPROXIES.HoverColor = Color.FromArgb(20, 20, 20);
            btnCHECKPROXIES.Image = null;
            btnCHECKPROXIES.Location = new Point(107, 210);
            btnCHECKPROXIES.Name = "btnCHECKPROXIES";
            btnCHECKPROXIES.Size = new Size(94, 24);
            btnCHECKPROXIES.TabIndex = 56;
            btnCHECKPROXIES.Text = "Check";
            btnCHECKPROXIES.Click += btnCHECKPROXIES_Click;
            // 
            // btnAUTLOADPROXIES
            // 
            btnAUTLOADPROXIES.BackColor = Color.FromArgb(25, 25, 25);
            btnAUTLOADPROXIES.Font = new Font("Bahnschrift Condensed", 14F);
            btnAUTLOADPROXIES.ForeColor = SystemColors.ActiveBorder;
            btnAUTLOADPROXIES.HoverColor = Color.FromArgb(20, 20, 20);
            btnAUTLOADPROXIES.Image = null;
            btnAUTLOADPROXIES.Location = new Point(8, 211);
            btnAUTLOADPROXIES.Name = "btnAUTLOADPROXIES";
            btnAUTLOADPROXIES.Size = new Size(94, 24);
            btnAUTLOADPROXIES.TabIndex = 55;
            btnAUTLOADPROXIES.Text = "Auto Load";
            btnAUTLOADPROXIES.Click += btnAUTLOADPROXIES_Click;
            // 
            // rtxtPROXIES
            // 
            rtxtPROXIES.BackColor = Color.FromArgb(25, 25, 25);
            rtxtPROXIES.BorderStyle = BorderStyle.None;
            rtxtPROXIES.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            rtxtPROXIES.ForeColor = SystemColors.ActiveBorder;
            rtxtPROXIES.Location = new Point(8, 264);
            rtxtPROXIES.Name = "rtxtPROXIES";
            rtxtPROXIES.Size = new Size(193, 58);
            rtxtPROXIES.TabIndex = 54;
            rtxtPROXIES.Text = "";
            // 
            // lblTOTALPROXIES
            // 
            lblTOTALPROXIES.AutoSize = true;
            lblTOTALPROXIES.Font = new Font("Bahnschrift Condensed", 15F);
            lblTOTALPROXIES.ForeColor = SystemColors.ActiveBorder;
            lblTOTALPROXIES.Location = new Point(65, 238);
            lblTOTALPROXIES.Name = "lblTOTALPROXIES";
            lblTOTALPROXIES.Size = new Size(64, 24);
            lblTOTALPROXIES.TabIndex = 50;
            lblTOTALPROXIES.Text = "TOTAL: 0";
            // 
            // pnlLINE
            // 
            pnlLINE.BorderStyle = BorderStyle.FixedSingle;
            pnlLINE.Location = new Point(0, 250);
            pnlLINE.Name = "pnlLINE";
            pnlLINE.Size = new Size(210, 1);
            pnlLINE.TabIndex = 53;
            // 
            // btnCLEARPROXIE
            // 
            btnCLEARPROXIE.BackColor = Color.FromArgb(25, 25, 25);
            btnCLEARPROXIE.Font = new Font("Bahnschrift Condensed", 14F);
            btnCLEARPROXIE.ForeColor = SystemColors.ActiveBorder;
            btnCLEARPROXIE.HoverColor = Color.FromArgb(20, 20, 20);
            btnCLEARPROXIE.Image = null;
            btnCLEARPROXIE.Location = new Point(107, 328);
            btnCLEARPROXIE.Name = "btnCLEARPROXIE";
            btnCLEARPROXIE.Size = new Size(94, 24);
            btnCLEARPROXIE.TabIndex = 52;
            btnCLEARPROXIE.Text = "Clear";
            btnCLEARPROXIE.Click += btnCLEARPROXIE_Click;
            // 
            // lstboxPROXIES
            // 
            lstboxPROXIES.BackColor = Color.White;
            lstboxPROXIES.BorderColor = Color.LightGray;
            lstboxPROXIES.DisabledBackColor = Color.FromArgb(204, 204, 204);
            lstboxPROXIES.DisabledForeColor = Color.FromArgb(136, 136, 136);
            lstboxPROXIES.Font = new Font("Bahnschrift Condensed", 15F);
            lstboxPROXIES.HoveredItemBackColor = Color.LightGray;
            lstboxPROXIES.HoveredItemColor = Color.DimGray;
            lstboxPROXIES.IsDerivedStyle = true;
            lstboxPROXIES.ItemHeight = 30;
            lstboxPROXIES.Location = new Point(8, 19);
            lstboxPROXIES.MultiSelect = false;
            lstboxPROXIES.Name = "lstboxPROXIES";
            lstboxPROXIES.SelectedIndex = -1;
            lstboxPROXIES.SelectedItem = null;
            lstboxPROXIES.SelectedItemBackColor = Color.FromArgb(65, 177, 225);
            lstboxPROXIES.SelectedItemColor = Color.White;
            lstboxPROXIES.SelectedText = null;
            lstboxPROXIES.SelectedValue = null;
            lstboxPROXIES.ShowBorder = false;
            lstboxPROXIES.ShowScrollBar = false;
            lstboxPROXIES.Size = new Size(193, 185);
            lstboxPROXIES.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            lstboxPROXIES.StyleManager = null;
            lstboxPROXIES.TabIndex = 48;
            lstboxPROXIES.ThemeAuthor = "Taiizor";
            lstboxPROXIES.ThemeName = "MetroLight";
            // 
            // btnADDPROXIE
            // 
            btnADDPROXIE.BackColor = Color.FromArgb(25, 25, 25);
            btnADDPROXIE.Font = new Font("Bahnschrift Condensed", 14F);
            btnADDPROXIE.ForeColor = SystemColors.ActiveBorder;
            btnADDPROXIE.HoverColor = Color.FromArgb(20, 20, 20);
            btnADDPROXIE.Image = null;
            btnADDPROXIE.Location = new Point(8, 328);
            btnADDPROXIE.Name = "btnADDPROXIE";
            btnADDPROXIE.Size = new Size(94, 24);
            btnADDPROXIE.TabIndex = 49;
            btnADDPROXIE.Text = "Add";
            btnADDPROXIE.Click += btnADDPROXIE_Click;
            // 
            // WebScraper
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 36, 36);
            ClientSize = new Size(1039, 780);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(lblBLACKLISTWORDS);
            Controls.Add(lblRESULTCOUNT);
            Controls.Add(panel1);
            Controls.Add(lblRESULTS);
            Controls.Add(lblSCRAPER);
            Controls.Add(pnlRESULTS);
            Controls.Add(pnlSCRAPER);
            Controls.Add(lblLINKS);
            Controls.Add(lblSETTINGS);
            Controls.Add(pnlLINKS);
            Controls.Add(pnlSETTINGS);
            FormBorderStyle = FormBorderStyle.None;
            Name = "WebScraper";
            Text = "WebScraper";
            Load += WebScraper_Load;
            pnlSETTINGS.ResumeLayout(false);
            pnlLINKS.ResumeLayout(false);
            pnlSCRAPER.ResumeLayout(false);
            pnlSCRAPER.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ReaLTaiizor.Controls.LostButton btnSCRAPE;
        private ReaLTaiizor.Controls.CircleProgressBar prgrsbarSCRAPER;
        private Panel pnlSETTINGS;
        private ReaLTaiizor.Controls.MetroListBox lstboxSETTINGS;
        private ReaLTaiizor.Controls.LostButton btnDELETESETTING;
        private ReaLTaiizor.Controls.LostButton btnSAVESETTING;
        private Label lblSETTINGS;
        private Panel pnlLINKS;
        private ReaLTaiizor.Controls.LostButton btnADDLINK;
        private ReaLTaiizor.Controls.MetroListBox lstboxLINKS;
        private Label lblLINKS;
        private Panel pnlSCRAPER;
        private Label lblSCRAPER;
        private ReaLTaiizor.Controls.CyberSwitch switchREGEXSEARCH;
        private Label lblREGEXSEARCH;
        private Label lblTEXT;
        private ReaLTaiizor.Controls.ForeverTextBox txtTEXT;
        private Label lblREGEX;
        private ReaLTaiizor.Controls.ForeverTextBox txtREGEX;
        private ReaLTaiizor.Controls.ForeverComboBox cmbTIMEFILTER;
        private ReaLTaiizor.Controls.ForeverTextBox txtSETTING;
        private ReaLTaiizor.Controls.LostButton btnDELETELINK;
        private Panel pnlRESULTS;
        private Label lblRESULTS;
        private ReaLTaiizor.Controls.ForeverTextBox txtLINK;
        private Label lblRESULTCOUNT;
        private Label lblBLACKLISTWORDS;
        private Panel panel1;
        private ReaLTaiizor.Controls.ForeverTextBox txtBLACKLISTWORD;
        private ReaLTaiizor.Controls.MetroListBox lstboxBLACKLISTWORDS;
        private ReaLTaiizor.Controls.LostButton btnADDBLACKLISTWORD;
        private ReaLTaiizor.Controls.LostButton btnDELETEBLACKLISTWORD;
        private Label label1;
        private Panel panel2;
        private ReaLTaiizor.Controls.LostButton btnCLEARPROXIE;
        private ReaLTaiizor.Controls.MetroListBox lstboxPROXIES;
        private ReaLTaiizor.Controls.LostButton btnADDPROXIE;
        private Panel pnlLINE;
        private Label lblTOTALPROXIES;
        private RichTextBox rtxtPROXIES;
        private ReaLTaiizor.Controls.LostButton btnAUTLOADPROXIES;
        private ReaLTaiizor.Controls.LostButton btnCHECKPROXIES;
        private ReaLTaiizor.Controls.CyberSwitch switchIMAGESEARCH;
        private Label lblIMAGESEARCH;
    }
}