using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mime;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using ReaLTaiizor.Controls;
using static Calypso.HttpRequest;

namespace Calypso
{
    public partial class WebScraper : Form
    {
        public class WebClientWithTimeout : WebClient
        {
            public int Timeout { get; set; }
            public WebClientWithTimeout()
            {
                Timeout = 5000;
            }
            protected override WebRequest GetWebRequest(Uri address)
            {
                var request = base.GetWebRequest(address);
                if (request is HttpWebRequest httpRequest)
                {
                    httpRequest.Timeout = Timeout;
                    httpRequest.ReadWriteTimeout = Timeout;
                }
                return request;
            }
        }

        public WebScraper()
        {
            InitializeComponent();
            FormUIHelper.ApplyUI(this, true, true, true, true, true, true, ContentAlignment.MiddleCenter);
        }

        MetroListBox lstboxRESULTS = new MetroListBox();
        System.Windows.Forms.Panel lstboxIMAGERESULTS = new System.Windows.Forms.Panel();
        private void WebScraper_Load(object sender, EventArgs e)
        {
            

            

            cmbTIMEFILTER.SelectedIndex = 4;

            string[] dosyalar = Directory.GetFiles(Path.Combine(Application.StartupPath, "scrapersettings"));
            foreach (string dosya in dosyalar)
            {
                string dosyaAdi = Path.GetFileNameWithoutExtension(dosya);
                if (!lstboxSETTINGS.Items.Contains(dosyaAdi))
                {
                    lstboxSETTINGS.Items.Add(dosyaAdi);
                }
            }
        }

        private void btnADDLINK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtLINK.Text))
            {
                lstboxLINKS.AddItem(txtLINK.Text);
                txtLINK.Text = "";
            }
            else
            {
                WarnUser warn = new WarnUser("Please enter the domain to search for");
                warn.Show();
            }
        }

        private void btnDELETELINK_Click(object sender, EventArgs e)
        {
            try
            {
                lstboxLINKS.RemoveItemAt(lstboxLINKS.SelectedIndex);
            }
            catch { }
        }

        public class ResultItem
        {
            public string title { get; set; }
            public string clickUrl { get; set; }
        }

        ListBox links = new ListBox();
        int resultcount = 0;

        private async void btnSCRAPE_Click(object sender, EventArgs e)
        {
            lstboxIMAGERESULTS.Visible = false;
            lstboxRESULTS.Visible = false;
            if (switchREGEXSEARCH.Checked)
            {
                lstboxRESULTS.Visible = true;
            }
            else if (switchIMAGESEARCH.Checked)
            {
                lstboxIMAGERESULTS.Visible = true;
            }
            else
            {
                lstboxRESULTS.Visible = true;
            }
            prgrsbarSCRAPER.Value = 0;
            lblRESULTCOUNT.Visible = true;
            resultcount = 0;
            lblRESULTCOUNT.Text = resultcount.ToString();
            lstboxRESULTS.Items.Clear();
            lstboxIMAGERESULTS.Controls.Clear();
            links.Items.Clear();

            string baseUrl = "https://www.startpage.com/do/search?sc=r2AYt1c6sbUj20&cat=web&abp=1&qloc=eyJ0eXBlIjogIm5vbmUiLCAibG9jUHJlZiI6IHsidHlwZSI6ICJub25lIiwgImRldmljZV9sb2NhdGlvbiI6IG51bGwsICJnZW9fbG9jYXRpb24iOiBudWxsfX0%3D";
            string searchText = txtTEXT.Text;
            string searchRegex = txtREGEX.Text;
            string dateFilter = "";
            bool canRun = true;

            switch (cmbTIMEFILTER.SelectedIndex)
            {
                case 3:
                    dateFilter = "&with_date=y";
                    break;
                case 2:
                    dateFilter = "&with_date=m";
                    break;
                case 1:
                    dateFilter = "&with_date=w";
                    break;
                case 0:
                    dateFilter = "&with_date=d";
                    break;
                default:
                    dateFilter = "";
                    break;
            }
            baseUrl += dateFilter;

            if (switchREGEXSEARCH.Checked && string.IsNullOrEmpty(searchRegex))
            {
                WarnUser warn = new WarnUser("Please enter a regex to search for");
                warn.Show();
                canRun = false;
            }
            if (!canRun)
                return;

            btnSCRAPE.Enabled = false;

            List<string> proxyList = new List<string>();
            foreach (var proxyItem in lstboxPROXIES.Items)
            {
                proxyList.Add(proxyItem.ToString());
            }
            if (proxyList.Count == 0)
            {
                MessageBox.Show("Proxy list is empty!");
                btnSCRAPE.Enabled = true;
                return;
            }

            int totalLinks = lstboxLINKS.Items.Count;
            int processedLinks = 0;

            foreach (var item in lstboxLINKS.Items)
            {
                string dynamicUrl = baseUrl + "&query=site%3A%22" + item.ToString() + "%22+intext%3A%22" + searchText + "%22";
                int page = 0;
                while (true)
                {
                    page++;
                    string dynamicUrlWithPage = dynamicUrl + "&page=" + page;
                    string html = await HttpService.GetHtmlWithProxyAsync(dynamicUrlWithPage, proxyList, 5000);
                    if (string.IsNullOrEmpty(html))
                        break;
                    if (html.Contains("there are no results for this search"))
                        break;
                    else if (html.Contains("To continue using Startpage, please enter in the characters you see below"))
                        break;
                    else if (html.Contains("Please enable javascript and reload the page"))
                        break;

                    string pattern = "\"title\"\\s*:\\s*\"(?<title>[^\"]+)\".*?\"clickUrl\"\\s*:\\s*\"(?<clickUrl>[^\"]+)\"";
                    MatchCollection matches = Regex.Matches(html, pattern, RegexOptions.Singleline);

                    if (matches.Count == 0)
                    {
                        break;
                    }
                    int foundlinksayac = 0;
                    foreach (Match match in matches)
                    {
                        string title = match.Groups["title"].Value;
                        string clickUrl = match.Groups["clickUrl"].Value;
                        foreach (var word in lstboxBLACKLISTWORDS.Items)
                        {
                            string patternWord = Regex.Escape(word.ToString());
                            title = Regex.Replace(title, patternWord, "", RegexOptions.IgnoreCase);
                        }
                        if (switchREGEXSEARCH.Checked)
                        {
                            string regexhtml = await HttpService.GetHtmlWithProxylessAsync(clickUrl, 5000);
                            Regex rgxRegex = new Regex(searchRegex, RegexOptions.IgnoreCase);
                            MatchCollection foundmatches = rgxRegex.Matches(regexhtml);
                            foreach (Match matchrgxfound in foundmatches)
                            {
                                lblRESULTCOUNT.Text = (resultcount++).ToString();
                                lstboxRESULTS.Items.Add(matchrgxfound.Value);
                                links.Items.Add(clickUrl);
                            }
                        }
                        else if (switchIMAGESEARCH.Checked)
                        {
                            string imagehtml = await HttpService.GetHtmlWithProxylessAsync(clickUrl, 5000);
                            Regex imgRegex = new Regex("<img[^>]*?src=[\"']([^\"']+)[\"'][^>]*>", RegexOptions.IgnoreCase);
                            MatchCollection matchesimg = imgRegex.Matches(imagehtml);
                            int imgCount = 0;
                            foreach (Match matchimg in matchesimg)
                            {
                                string src = matchimg.Groups[1].Value;
                                if (src.StartsWith("data:") || src.StartsWith("http://") || src.StartsWith("https://"))
                                {
                                    lblRESULTCOUNT.Text = (resultcount++).ToString();
                                    PictureBox img = new PictureBox();
                                    img.ImageLocation = src;
                                    img.SizeMode = PictureBoxSizeMode.StretchImage;
                                    lstboxIMAGERESULTS.Controls.Add(img);
                                    img.Size = new Size(100, 100);
                                    img.Location = new Point(imgCount * 100, foundlinksayac * 100);
                                    ContextMenuStrip contextMenu = new ContextMenuStrip();
                                    ToolStripMenuItem openUrlItem = new ToolStripMenuItem("Open Base URL");
                                    contextMenu.Items.Add(openUrlItem);
                                    openUrlItem.Click += (s, e) =>
                                    {
                                        string differentUrl = clickUrl;
                                        Process.Start(new ProcessStartInfo
                                        {
                                            FileName = differentUrl,
                                            UseShellExecute = true
                                        });
                                    };
                                    img.ContextMenuStrip = contextMenu;
                                    img.Click += (s, e) =>
                                    {
                                        Process.Start(new ProcessStartInfo
                                        {
                                            FileName = src,
                                            UseShellExecute = true
                                        });
                                    };
                                    imgCount++;
                                }
                            }
                        }
                        else
                        {
                            lblRESULTCOUNT.Text = (resultcount++).ToString();
                            lstboxRESULTS.Items.Add(title);
                            links.Items.Add(clickUrl);
                        }
                        foundlinksayac++;
                    }
                }
                processedLinks++;
                int percent = (int)((processedLinks / (double)totalLinks) * 100);
                prgrsbarSCRAPER.Value = percent;
            }

            btnSCRAPE.Enabled = true;
        }

        static string GetExtensionFromContentType(string contentType)
        {
            var map = new Dictionary<string, string>
            {
                ["image/jpeg"] = ".jpg",
                ["image/png"] = ".png",
                ["image/gif"] = ".gif",
                ["image/bmp"] = ".bmp",
                ["image/webp"] = ".webp",
                ["image/svg+xml"] = ".svg"
            };

            return map.TryGetValue(contentType.ToLower(), out string ext) ? ext : null;
        }

        private void lstboxRESULTS_SelectedIndexChanged(object sender)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = links.Items[lstboxRESULTS.SelectedIndex].ToString(),
                UseShellExecute = true
            });
        }

        private void btnAUTLOADPROXIES_Click(object sender, EventArgs e)
        {
            lstboxPROXIES.Items.Clear();
            WebClient client = new WebClient();
            client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/83.0.4103.116 Safari/537.36");
            client.Headers.Add("Accept", "*/*");
            client.Headers.Add("Pragma", "no-cache");
            client.Headers.Add("Accept-Language", "en-US,en;q=0.8");
            string html = client.DownloadString("https://api.proxyscrape.com/v2/?request=displayproxies&protocol=http&timeout=5000&country=all&ssl=all&anonymity=all");
            string[] lines = html.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            foreach (var line in lines)
            {
                if (!string.IsNullOrEmpty(line))
                {
                    lstboxPROXIES.Items.Add(line);
                }
            }
            lblTOTALPROXIES.Text = "TOTAL: " + lstboxPROXIES.Items.Count.ToString();
        }

        private void RemoveProxy(string proxy)
        {
            if (lstboxPROXIES.InvokeRequired)
            {
                lstboxPROXIES.Invoke(new Action(() => RemoveProxy(proxy)));
                return;
            }
            lstboxPROXIES.Items.Remove(proxy);
            lblTOTALPROXIES.Text = "TOTAL: " + lstboxPROXIES.Items.Count.ToString();
        }

        private async void btnCHECKPROXIES_Click(object sender, EventArgs e)
        {
            prgrsbarSCRAPER.Value = 0;
            btnCHECKPROXIES.Enabled = false;
            btnSCRAPE.Enabled = false;
            List<string> proxiesToCheck = new List<string>();
            foreach (var item in lstboxPROXIES.Items)
            {
                proxiesToCheck.Add(item.ToString());
            }
            var sayac = 0;
            using (SemaphoreSlim semaphore = new SemaphoreSlim(50))
            {
                List<Task> tasks = new List<Task>();
                foreach (var proxy in proxiesToCheck)
                {
                    await semaphore.WaitAsync();
                    Task task = Task.Run(async () =>
                    {
                        try
                        {
                            var handler = new HttpClientHandler()
                            {
                                Proxy = BuildProxy(proxy),
                                UseProxy = true,
                            };

                            using (HttpClient client = new HttpClient(handler))
                            {
                                client.Timeout = TimeSpan.FromMilliseconds(5000);
                                HttpResponseMessage response = await client.GetAsync("https://example.com/");
                                if (!response.IsSuccessStatusCode)
                                {
                                    RemoveProxy(proxy);
                                }
                            }
                        }
                        catch (Exception)
                        {
                            RemoveProxy(proxy);
                        }
                        finally
                        {
                            semaphore.Release();
                        }
                        sayac++;
                        prgrsbarSCRAPER.Value = (int)((float)sayac / proxiesToCheck.Count * 100);
                    });
                    tasks.Add(task);
                }
                await Task.WhenAll(tasks);
            }
            btnSCRAPE.Enabled = true;
            btnCHECKPROXIES.Enabled = true;
        }

        private static IWebProxy BuildProxy(string raw)
        {
            var parts = raw.Split(':');
            string ip, user = null, pass = null;
            int port;

            if (parts.Length == 2)
            {
                ip = parts[0];
                if (!int.TryParse(parts[1], out port))
                    throw new ArgumentException("Invalid port in proxy string");
            }
            else if (parts.Length == 4)
            {
                if (IsIpPort(parts[0], parts[1], out ip, out port))
                {
                    user = parts[2];
                    pass = parts[3];
                }
                else if (IsIpPort(parts[2], parts[3], out ip, out port))
                {
                    user = parts[0];
                    pass = parts[1];
                }
                else
                {
                    throw new ArgumentException("Invalid IP:port in proxy string");
                }
            }
            else
            {
                throw new ArgumentException("Proxy string must have 2 or 4 parts");
            }

            var wp = new WebProxy(ip, port);
            if (user != null)
                wp.Credentials = new NetworkCredential(user, pass);
            return wp;
        }

        private static bool IsIpPort(string ipPart, string portPart, out string ip, out int port)
        {
            ip = null; port = 0;
            if (!IPAddress.TryParse(ipPart, out _)) return false;
            if (!int.TryParse(portPart, out var p) || p < 1 || p > 65535) return false;
            ip = ipPart; port = p;
            return true;
        }

        private void btnADDPROXIE_Click(object sender, EventArgs e)
        {
            string[] proxies = rtxtPROXIES.Text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            foreach (var proxy in proxies)
            {
                if (!string.IsNullOrEmpty(proxy))
                {
                    lstboxPROXIES.Items.Add(proxy);
                }
            }
            lblTOTALPROXIES.Text = "TOTAL: " + lstboxPROXIES.Items.Count.ToString();
            rtxtPROXIES.Text = "";
        }

        private void btnADDBLACKLISTWORD_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBLACKLISTWORD.Text))
            {
                lstboxBLACKLISTWORDS.AddItem(txtBLACKLISTWORD.Text);
                txtBLACKLISTWORD.Text = "";
            }
            else
            {
                WarnUser warn = new WarnUser("Please enter the blacklist word");
                warn.Show();
            }
        }

        private void btnDELETEBLACKLISTWORD_Click(object sender, EventArgs e)
        {
            try
            {
                lstboxBLACKLISTWORDS.RemoveItemAt(lstboxBLACKLISTWORDS.SelectedIndex);
            }
            catch { }
        }
        public class ScraperSettings
        {
            public List<string> LINKS { get; set; }
            public List<string> BLACKLISTWORDS { get; set; }
            public List<string> PROXIES { get; set; }
            public string TEXT { get; set; }
            public bool ISIMGSEARCH { get; set; }
            public bool ISREGEXSEARCH { get; set; }
            public string REGEX { get; set; }
            public int TIMEFILTER { get; set; }
        }

        private void btnSAVESETTING_Click(object sender, EventArgs e)
        {
            string settingsDirectory = Path.Combine(Application.StartupPath, "scrapersettings");
            Directory.CreateDirectory(settingsDirectory);
            string settingsName = txtSETTING.Text.Trim();
            if (string.IsNullOrEmpty(settingsName))
            {
                WarnUser warn = new WarnUser("Please enter settings name");
                warn.Show();
            }
            else
            {
                string filePath = Path.Combine(settingsDirectory, settingsName + ".json");
                var settings = new ScraperSettings
                {
                    LINKS = lstboxLINKS.Items.Cast<string>().ToList(),
                    BLACKLISTWORDS = lstboxBLACKLISTWORDS.Items.Cast<string>().ToList(),
                    PROXIES = lstboxPROXIES.Items.Cast<string>().ToList(),
                    TEXT = txtTEXT.Text,
                    ISIMGSEARCH = switchIMAGESEARCH.Checked,
                    ISREGEXSEARCH = switchREGEXSEARCH.Checked,
                    REGEX = txtREGEX.Text,
                    TIMEFILTER = cmbTIMEFILTER.SelectedIndex
                };
                string json = JsonConvert.SerializeObject(settings, Formatting.Indented);
                File.WriteAllText(filePath, json);
                if (!lstboxSETTINGS.Items.Contains(settingsName))
                {
                    lstboxSETTINGS.Items.Add(settingsName);
                }
            }
        }

        private void lstboxSETTINGS_SelectedIndexChanged(object sender)
        {
            if (lstboxSETTINGS.SelectedItem != null)
            {
                txtSETTING.Text = lstboxSETTINGS.SelectedItem.ToString();
                string selectedSetting = lstboxSETTINGS.SelectedItem.ToString();
                string settingsDirectory = Path.Combine(Application.StartupPath, "scrapersettings");
                string filePath = Path.Combine(settingsDirectory, selectedSetting + ".json");

                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    var settings = JsonConvert.DeserializeObject<ScraperSettings>(json);
                    lstboxLINKS.Items.Clear();
                    foreach (var link in settings.LINKS)
                    {
                        lstboxLINKS.Items.Add(link);
                    }
                    lstboxBLACKLISTWORDS.Items.Clear();
                    foreach (var word in settings.BLACKLISTWORDS)
                    {
                        lstboxBLACKLISTWORDS.Items.Add(word);
                    }
                    lstboxPROXIES.Items.Clear();
                    foreach (var proxy in settings.PROXIES)
                    {
                        lstboxPROXIES.Items.Add(proxy);
                    }
                    lblTOTALPROXIES.Text = "TOTAL: " + lstboxPROXIES.Items.Count.ToString();
                    txtTEXT.Text = settings.TEXT;
                    switchIMAGESEARCH.Checked = settings.ISIMGSEARCH;
                    switchREGEXSEARCH.Checked = settings.ISREGEXSEARCH;
                    txtREGEX.Text = settings.REGEX;
                    cmbTIMEFILTER.SelectedIndex = settings.TIMEFILTER;
                    txtSETTING.Text = selectedSetting;
                }
                else
                {
                    WarnUser warn = new WarnUser("Cannot find the settings file");
                    warn.Show();
                }
            }
        }

        private void btnDELETESETTING_Click(object sender, EventArgs e)
        {
            if (lstboxSETTINGS.SelectedItem != null)
            {
                string selectedSetting = lstboxSETTINGS.SelectedItem.ToString();

                string settingsDirectory = Path.Combine(Application.StartupPath, "scrapersettings");
                string filePath = Path.Combine(settingsDirectory, selectedSetting + ".json");
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                    lstboxSETTINGS.Items.RemoveAt(lstboxSETTINGS.SelectedIndex);
                }
                else
                {
                    WarnUser warn = new WarnUser("Cannot find the settings file");
                    warn.Show();
                }
            }
        }

        private void btnCLEARPROXIE_Click(object sender, EventArgs e)
        {
            lstboxPROXIES.Clear();
        }

        private void switchIMAGESEARCH_CheckedChanged()
        {
            if (switchIMAGESEARCH.Checked && switchREGEXSEARCH.Checked)
            {
                switchREGEXSEARCH.Checked = false;
            }
        }

        private void switchREGEXSEARCH_CheckedChanged()
        {
            if (switchREGEXSEARCH.Checked)
            {
                txtREGEX.Enabled = true;
            }
            else
            {
                txtREGEX.Enabled = false;
            }
            if (switchIMAGESEARCH.Checked && switchREGEXSEARCH.Checked)
            {
                switchIMAGESEARCH.Checked = false;
            }
        }
    }
}
