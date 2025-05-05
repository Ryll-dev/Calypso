using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Calypso
{
    public partial class WebWorm : Form
    {
        // ——— Yeni alanlar ———
        private HashSet<string> visited = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        private Queue<string> toVisit = new Queue<string>();

        private bool https = false;
        private string baselink = string.Empty;
        private string nakedbaselink = string.Empty;

        public WebWorm()
        {
            InitializeComponent();
            

        }

        private void Worm_Load(object sender, EventArgs e)
        {
            Color backColor = Color.FromArgb(25, 25, 25);
            Color foreColor = Color.FromArgb(180, 180, 180);
            Color hoveredBack = Color.FromArgb(30, 30, 30);
            Color hoveredFore = Color.FromArgb(180, 180, 180);
            lstboxFOUNDLINKS.BackColor = backColor;
            lstboxFOUNDLINKS.ForeColor = foreColor;
            lstboxFOUNDLINKS.HoveredItemBackColor = hoveredBack;
            lstboxFOUNDLINKS.HoveredItemColor = hoveredFore;
            lstboxFOUNDLINKS.SelectedItemBackColor = hoveredBack;
            lstboxFOUNDLINKS.SelectedItemColor = hoveredFore;
        }

        // ——— İzin verilen uzantılar / dizin kontrolü ———
        private bool IsValidExtension(string url)
        {
            try
            {
                var uri = new Uri(url);
                string ext = Path.GetExtension(uri.AbsolutePath).ToLower();
                string[] allowed = { ".html", ".htm", ".php", ".asp", ".aspx", ".jsp", ".cfm", ".py", ".rb", ".cgi" };
                // uzantı yoksa (dizin) de geçerli
                if (string.IsNullOrEmpty(ext)) return true;
                return allowed.Contains(ext);
            }
            catch
            {
                return false;
            }
        }

        // ——— Link çıkarma + normalize etme ———
        private List<string> ExtractLinks(string html)
        {
            var hrefregex = new Regex(
                @"href\s*=\s*(?:(['""])(?<url>.*?)\1|(?<url>[^\s>]+))",
                RegexOptions.IgnoreCase
            );
            var srcregex = new Regex(
                @"src\s*=\s*(?:(['""])(?<url>.*?)\1|(?<url>[^\s>]+))",
                RegexOptions.IgnoreCase
            );
            var actionregex = new Regex(
                @"action\s*=\s*(?:(['""])(?<url>.*?)\1|(?<url>[^\s>]+))",
                RegexOptions.IgnoreCase
            );

            var totallinks = new List<string>();
            foreach (Match m in actionregex.Matches(html))
                totallinks.Add(m.Groups["url"].Value);
            foreach (Match m in hrefregex.Matches(html))
                totallinks.Add(m.Groups["url"].Value);
            foreach (Match m in srcregex.Matches(html))
                totallinks.Add(m.Groups["url"].Value);

            string linkstart = https ? "https://" : "http://";

            for (int i = totallinks.Count - 1; i >= 0; i--)
            {
                string link = totallinks[i];
                if (string.IsNullOrEmpty(link) || link.StartsWith("#") || link.StartsWith("javascript:"))
                {
                    totallinks.RemoveAt(i);
                    continue;
                }

                // Farklı domainleri at
                if (ContainsDomain(link))
                {
                    if (!ExtractBareDomain(link).Contains(nakedbaselink, StringComparison.OrdinalIgnoreCase))
                    {
                        totallinks.RemoveAt(i);
                        continue;
                    }
                }

                // Göreli linkler
                if (link.StartsWith("./")) link = link.Substring(2);
                if (link.StartsWith("/")) link = linkstart + nakedbaselink + link;
                else if (!ContainsDomain(link)) link = baselink + "/" + link;

                if (!switchIMAGESEARCH.Checked && link.Contains("?"))
                {
                    link = link.Substring(0, link.IndexOf('?'));
                }
                link = link.TrimEnd('/');


                totallinks[i] = link;
            }

            return totallinks.Distinct().ToList();
        }

        // ——— Butona basıldığında siteyi tamamen tarayan döngü ———
        private async void btnWORM_Click(object sender, EventArgs e)
        {
            string startUrl = txtURL.Text.Trim();
            if (!ContainsDomain(startUrl)) return;

            baselink = startUrl.TrimEnd('/');
            https = baselink.StartsWith("https://", StringComparison.OrdinalIgnoreCase);
            nakedbaselink = ExtractBareDomain(baselink);

            visited.Clear();
            toVisit.Clear();
            lstboxFOUNDLINKS.Items.Clear();

            visited.Add(baselink);
            toVisit.Enqueue(baselink);

            while (toVisit.Count > 0)
            {
                string current = toVisit.Dequeue();
                string html;
                try { html = await HttpService.GetHtmlWithProxylessAsync(current, 5000); }
                catch { continue; }

                var links = ExtractLinks(html);
                foreach (var link in links)
                {
                    if (!visited.Contains(link) && IsValidExtension(link))
                    {
                        visited.Add(link);

                        bool alreadyInQueue = toVisit
                            .Any(x => x.Equals(link, StringComparison.OrdinalIgnoreCase));
                        if (!alreadyInQueue)
                            toVisit.Enqueue(link);
                        bool alreadyInList = lstboxFOUNDLINKS.Items
                            .OfType<string>()
                            .Any(x => x.Equals(link, StringComparison.OrdinalIgnoreCase));

                        if (!alreadyInList)
                            lstboxFOUNDLINKS.Items.Add(link);
                    }
                }
            }
        }

        public static bool ContainsDomain(string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return false;
            var pattern = @"^(?:(?:https?://)|//)?(?:[A-Za-z0-9-]+\.)+[A-Za-z]{2,}(?:/.*)?$";
            return Regex.IsMatch(text, pattern, RegexOptions.IgnoreCase);
        }

        public static string ExtractBareDomain(string url)
        {
            if (string.IsNullOrWhiteSpace(url)) return string.Empty;
            string domain = url.Trim();
            foreach (var prefix in new[] { "https://", "http://", "ftp://", "ftps://", "ws://", "wss://", "mailto:", "tel:", "sms:", "file:///", "file://", "data:" })
                domain = domain.Replace(prefix, "");
            if (domain.StartsWith("//")) domain = domain.Substring(2);
            if (domain.StartsWith("["))
            {
                int idx = domain.IndexOf(']');
                if (idx >= 0) return domain.Substring(0, idx + 1);
            }
            int cutAt = domain.IndexOfAny(new char[] { ':', '/', '?', '#' });
            if (cutAt >= 0) domain = domain.Substring(0, cutAt);
            return domain;
        }

        private void lostButton1_Click(object sender, EventArgs e)
        {
            var text = new StringBuilder();
            foreach (var item in lstboxFOUNDLINKS.Items)
                text.AppendLine(item.ToString());
            Clipboard.SetText(text.ToString());
        }
    }
}
