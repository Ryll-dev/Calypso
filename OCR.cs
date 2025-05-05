using System.Runtime.InteropServices;
using Tesseract;

namespace Calypso
{
    public partial class OCR : Form
    {
        public OCR()
        {
            InitializeComponent();
            FormUIHelper.ApplyUI(this, true, true, true, true, true, true, ContentAlignment.MiddleCenter);
            rtxtRESULTS.MouseDown += (s, e) => HideCaret(rtxtRESULTS.Handle);
            rtxtRESULTS.GotFocus += (s, e) => HideCaret(rtxtRESULTS.Handle);
            rtxtRESULTS.SelectionChanged += (s, e) => HideCaret(rtxtRESULTS.Handle);
        }

        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);

        string imagePath = string.Empty;

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.V))
            {
                PasteImageFromClipboard();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void PasteImageFromClipboard()
        {
            if (Clipboard.ContainsImage())
            {
                Image clipboardImage = Clipboard.GetImage();
                string tempFileName = Path.Combine(Path.GetTempPath(), "clipboardImage_" + Guid.NewGuid().ToString() + ".png");
                clipboardImage.Save(tempFileName, System.Drawing.Imaging.ImageFormat.Png);
                imagePath = tempFileName;
                pctrboxIMAGE.Image = clipboardImage;
            }
            else
            {
                MessageBox.Show("Clipboard'da geçerli bir resim bulunamadı!");
            }
        }

        private void btnIMGTOTEXT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(imagePath))
            {
                WarnUser warn = new WarnUser("Image field cannot be empty");
                warn.Show();
                return;
            }
            try
            {
                using (var ocrEngine = new TesseractEngine(@"./tessdata", "eng", EngineMode.Default))
                {
                    using (var img = Pix.LoadFromFile(imagePath))
                    {
                        var result = ocrEngine.Process(img);
                        rtxtRESULTS.Text = result.GetText();
                    }
                }
            }
            catch (Exception ex)
            {
                WarnUser warn = new WarnUser("An error occurred during the OCR process: " + ex.Message);
                warn.Show();
            }
        }

        private async void OCR_Load(object sender, EventArgs e)
        {
            await Task.Delay(10);
            HideCaret(rtxtRESULTS.Handle);
        }

        private void OCR_Shown(object sender, EventArgs e)
        {
            HideCaret(rtxtRESULTS.Handle);
        }

        private void btnSELECTIMAGE_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openDlg = new OpenFileDialog())
            {
                openDlg.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp";
                if (openDlg.ShowDialog() == DialogResult.OK)
                {
                    imagePath = openDlg.FileName;
                    pctrboxIMAGE.Image = Image.FromFile(imagePath);
                }
            }
        }

        private void btnPASTEIMAGE_Click(object sender, EventArgs e)
        {
            PasteImageFromClipboard();
        }
    }
}
