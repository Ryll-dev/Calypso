using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;
using System.Diagnostics;

namespace Calypso
{
    public partial class NeedUpdate : Form
    {
        WebClient _webClient; string _oldVersion, _newVersion, _url, fileName;
        public NeedUpdate(string oldver, string newver, string url)
        {
            InitializeComponent();
            FormUIHelper.ApplyUI(this, true, true, true, true, true, true, ContentAlignment.MiddleCenter);
            _oldVersion = oldver;
            _newVersion = newver;
            _url = url;
        }

        private void NeedUpdate_Load(object s, EventArgs e)
        {
            lblNEEDUPDATE.Location = new Point(Width / 2 - lblNEEDUPDATE.Width / 2, lblNEEDUPDATE.Location.Y);
            lblVERSION.Text = _oldVersion + " --> " + _newVersion;
            lblVERSION.Location = new Point(Width / 2 - lblVERSION.Width / 2, lblVERSION.Location.Y);
        }

        private async Task StartDownloadAsync()
        {
            try
            {
                _webClient = new WebClient(); _webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.3");
                _webClient.DownloadProgressChanged += (s, e) => prgrsbarUPDATE.Value = e.ProgressPercentage;
                _webClient.DownloadFileCompleted += (s, e) => { };
                fileName = Path.GetFileName(new Uri(_url).LocalPath);
                await _webClient.DownloadFileTaskAsync(new Uri(_url), Path.Combine(Path.GetTempPath(), fileName));
            }
            catch { new WarnUser("Download failed.").Show(); }
        }




        private async Task ExtractFiles(string extractPath)
        {
            var path = Path.Combine(Path.GetTempPath(), fileName);

            if (File.Exists(path))
            {
                try
                {
                    ZipFile.ExtractToDirectory(path, extractPath, true);
                }
                catch { }
            }
            else new WarnUser("File not found").Show();
        }

        private async void btnUPDATE_Click(object sender, EventArgs e)
        {
            btnUPDATE.Visible = false; prgrsbarUPDATE.Visible = true;
            await StartDownloadAsync();
            FileManager.RenameFilesTag(Application.StartupPath, "OLD_");
            await ExtractFiles(Application.StartupPath);
            Process.Start(new ProcessStartInfo(Path.Combine(Application.StartupPath, "Calypso.exe"), "--delay") { WorkingDirectory = Application.StartupPath });
            Close();
        }
    }
}
