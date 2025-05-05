using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calypso
{
    public partial class ProxyChecker : Form
    {
        public ProxyChecker()
        {
            InitializeComponent();
            FormUIHelper.ApplyUI(this, true, true, true, true, true, true, ContentAlignment.MiddleCenter);
        }

        int totalProxies = 0;
        int liveproxies = 0;
        int badproxies = 0;

        private async void btnCHECKER_Click(object sender, EventArgs e)
        {
            prgrsbarPROXYCHECK.Value = 0;
            lstboxCHECKEDPROXIES.Items.Clear();
            lstboxUNCHECKEDPROXIES.Items.Clear();
            totalProxies = liveproxies = badproxies = 0;

            if (string.IsNullOrWhiteSpace(txtURL.Text))
            {
                new WarnUser("Please enter an URL!").Show();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtLIVEKEY.Text))
            {
                new WarnUser("Please enter a live key!").Show();
                return;
            }

            var ofd = new OpenFileDialog
            {
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                Title = "Select a file",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                CheckFileExists = true,
                CheckPathExists = true,
                Multiselect = false
            };
            if (ofd.ShowDialog() != DialogResult.OK) return;

            var all = System.IO.File
                        .ReadAllLines(ofd.FileName)
                        .Select(l => l.Trim())
                        .Where(l => !string.IsNullOrEmpty(l))
                        .ToList();

            totalProxies = all.Count;
            prgrsbarPROXYCHECK.Maximum = totalProxies;
            lblUNCHECKEDCOUNT.Text = totalProxies.ToString();
            lstboxUNCHECKEDPROXIES.Items.Clear();
            foreach (var p in all)
                lstboxUNCHECKEDPROXIES.Items.Add(p);

            await TestInBatches(all, batchSize: 50);
        }

        private async Task TestInBatches(List<string> proxies, int batchSize)
        {
            for (int i = 0; i < proxies.Count; i += batchSize)
            {
                var batch = proxies.Skip(i).Take(batchSize);
                var tasks = batch.Select(p => TestAllProxies(p));
                await Task.WhenAll(tasks);
            }
        }

        private async Task TestAllProxies(string proxy)
        {
            var list = new List<string> { proxy };
            string html = await HttpService.GetHtmlWithProxyAsync(txtURL.Text, list, 5000);

            if (html.Contains(txtLIVEKEY.Text))
            {
                lstboxCHECKEDPROXIES.Items.Add(proxy);
                liveproxies++;
                lblLIVECOUNT.Text = liveproxies.ToString();
            }
            else
            {
                badproxies++;
                lblBADCOUNT.Text = badproxies.ToString();
            }
            lstboxUNCHECKEDPROXIES.Items.Remove(proxy);
            prgrsbarPROXYCHECK.Value++;
            lblCHECKEDCOUNT.Text = (liveproxies + badproxies).ToString();
            lblUNCHECKEDCOUNT.Text = (totalProxies - liveproxies - badproxies).ToString();
        }

        private async void btnGETHTML_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtURL.Text))
            {
                new WarnUser("Please enter an URL!").Show();
                return;
            }
            string html = await HttpService.GetHtmlWithProxylessAsync(txtURL.Text, 5000);
            if (string.IsNullOrEmpty(html))
            {
                new WarnUser("Failed to get HTML!").Show();
            }
            else
            {
                Clipboard.SetText(html);
                new WarnUser(html).Show();
            }
        }
    }
}
