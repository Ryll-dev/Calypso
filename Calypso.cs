using System.Net.Http.Headers;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using Calypso;
using Newtonsoft.Json.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static Calypso.Calypso;
namespace Calypso
{
    public partial class Calypso : Form
    {
        private string version = "1.1.2";
        private string CalypsoVersion = string.Empty;
        private string CalypsoURL = string.Empty;
        public Calypso()
        {
            InitializeComponent();
            this.Opacity = 0.9;
            CheckLatestRelease();
            if (CalypsoVersion != version)
            {
                Application.Run(new NeedUpdate(version, CalypsoVersion, CalypsoURL));
                this.Close();
                return;
            }
            FormUIHelper.ApplyUI(this, true, false, false, false, false, false, ContentAlignment.MiddleCenter);
        }

        private void CheckLatestRelease()
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.UserAgent.ParseAdd("Calypso/1.0");
            client.DefaultRequestHeaders.Accept.ParseAdd("application/vnd.github+json");
            client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", "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");

            var url = "https://api.github.com/repos/Ryll-dev/Calypso/releases/latest";
            var resp = client.GetAsync(url).GetAwaiter().GetResult();
            resp.EnsureSuccessStatusCode();

            var json = resp.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            var root = JObject.Parse(json);

            CalypsoVersion = (string)root["tag_name"];
            CalypsoURL = (string)root["assets"][0]["browser_download_url"];
        }


        (TaskbarInfo.TaskbarPosition position, int size) taskbarpos;
        private async void Calypso_Load(object sender, EventArgs e)
        {
            Tool[] tools = new Tool[]
            {
                new Tool{ Logo = Image.FromStream(new MemoryStream(CalypsoResources.PixelColorIcon)), Name="PixelColor", FormType = typeof(PixelColor) },
                new Tool{ Logo = Image.FromStream(new MemoryStream(CalypsoResources.HttpRequestIcon)), Name="HttpRequest", FormType = typeof(HttpRequest) },
                new Tool { Logo = Image.FromStream(new MemoryStream(CalypsoResources.WebScraperIcon)), Name = "WebScraper", FormType = typeof(WebScraper) },
                new Tool { Logo = Image.FromStream(new MemoryStream(CalypsoResources.OcrIcon)), Name = "OCR", FormType = typeof(OCR) },
                new Tool { Logo = Image.FromStream(new MemoryStream(CalypsoResources.CustomTaskbarIcon)), Name = "Custom Taskbar", FormType = typeof(CustomTaskbar) },
                new Tool { Logo = Image.FromStream(new MemoryStream(CalypsoResources.WormIcon)), Name = "Web Worm", FormType = typeof(WebWorm) },
                new Tool { Logo = Image.FromStream(new MemoryStream(CalypsoResources.ProxyCheckerIcon)), Name = "Proxy Checker", FormType = typeof(ProxyChecker) },
                new Tool { Logo = Image.FromStream(new MemoryStream(CalypsoResources.SettingsIcon)), Name="Settings", FormType = typeof(Settings) }
            };
            taskbarpos = TaskbarInfo.GetTaskbarInfo();
            int formWidth = (200 * Screen.PrimaryScreen.Bounds.Width) / 1920;
            int panelWidth = (95 * formWidth) / 100;
            int startIndex = 0;
            int panelPos = formWidth - panelWidth;
            bool isRight = false;
            if (taskbarpos.position == TaskbarInfo.TaskbarPosition.Bottom)
            {
                this.Size = new Size(formWidth, Screen.PrimaryScreen.Bounds.Height - taskbarpos.size);
                this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - formWidth, 0);
            }
            else if (taskbarpos.position == TaskbarInfo.TaskbarPosition.Top)
            {
                this.Size = new Size(formWidth, Screen.PrimaryScreen.Bounds.Height - taskbarpos.size);
                this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - formWidth, taskbarpos.size);
            }
            else if (taskbarpos.position == TaskbarInfo.TaskbarPosition.Left)
            {
                this.Size = new Size(formWidth, Screen.PrimaryScreen.Bounds.Height);
                this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - formWidth, 0);
            }
            else if (taskbarpos.position == TaskbarInfo.TaskbarPosition.Right)
            {
                this.Size = new Size(formWidth, Screen.PrimaryScreen.Bounds.Height);
                this.Location = new Point(0, 0);
                panelPos = 0;
                isRight = true;
            }
            foreach (Tool tool in tools)
            {
                startIndex += 10;

                ToolItemControl toolControl = new ToolItemControl(tool, panelWidth);
                toolControl.Location = new Point(panelPos, startIndex);
                toolControl.ToolClicked += (s, ev) => Tool_Click(s, ev, tool);

                this.Controls.Add(toolControl);
                startIndex += 40;
            }
            if (isRight)
            {
                ControlExtensions.ApplyCustomRoundedCorners(this, 0, 15, 15, 0);
            }
            else
            {
                ControlExtensions.ApplyCustomRoundedCorners(this, 15, 0, 0, 15);
            }
        }

        private void Tool_Click(object sender, EventArgs e, Tool tool)
        {
            var form = (Form)Activator.CreateInstance(tool.FormType);
            form.Show();
        }

        public class Tool()
        {
            public Image Logo { get; set; }
            public String Name { get; set; }
            public Type FormType { get; set; }
        }

        public class ToolItemControl : UserControl
        {
            public Tool Tool { get; private set; }
            public event EventHandler ToolClicked;

            private System.Windows.Forms.Button btn;
            private Label lbl;

            public ToolItemControl(Tool tool, int panelWidth)
            {
                int space = 3 * this.Width / 100;
                Tool = tool;
                this.BackColor = Color.FromArgb(25, 25, 25);
                this.Size = new Size(panelWidth, 40);
                this.Cursor = Cursors.Cross;
                (TaskbarInfo.TaskbarPosition position, int size) taskbarpos = TaskbarInfo.GetTaskbarInfo();
                if (taskbarpos.position == TaskbarInfo.TaskbarPosition.Right)
                {
                    ControlExtensions.ApplyCustomRoundedCorners(this, 0, 15, 15, 0);
                }
                else
                {
                    ControlExtensions.ApplyCustomRoundedCorners(this, 15, 0, 0, 15);
                }

                btn = new System.Windows.Forms.Button
                {
                    BackgroundImage = tool.Logo,
                    BackgroundImageLayout = ImageLayout.Stretch,
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.FromArgb(25, 25, 25),
                    TabStop = false,
                    FlatAppearance =
            {
                BorderSize = 0,
                MouseOverBackColor = Color.FromArgb(30, 30, 30),
                MouseDownBackColor = Color.FromArgb(30, 30, 30)
            },
                    Size = new Size((90 * this.Height) / 100, (90 * this.Height) / 100),
                    Location = new Point(space + this.Width * 2 / 100, this.Height / 2 - ((90 * this.Height) / 100) / 2),
                    Cursor = Cursors.Cross
                };

                btn.Click += Control_Click;
                btn.MouseEnter += Control_MouseEnter;
                btn.MouseLeave += Control_MouseLeave;

                lbl = new Label
                {
                    Text = tool.Name,
                    ForeColor = Color.FromArgb(180, 180, 180),
                    TextAlign = ContentAlignment.MiddleLeft,
                    Font = new Font("Bahnschrift Condensed", 13),
                    AutoSize = false,
                    Size = new Size(panelWidth - btn.Width - ((this.Width * 2 / 100) * 2), (90 * this.Height) / 100),
                    Location = new Point(space + btn.Width + ((this.Width * 2 / 100) * 2), this.Height / 2 - ((90 * this.Height) / 100) / 2),
                    Cursor = Cursors.Cross,
                    BackColor = Color.FromArgb(25, 25, 25),
                };

                lbl.Click += Control_Click;
                lbl.MouseEnter += Control_MouseEnter;
                lbl.MouseLeave += Control_MouseLeave;

                this.Controls.Add(btn);
                this.Controls.Add(lbl);
                this.Click += Control_Click;
                this.MouseEnter += Control_MouseEnter;
                this.MouseLeave += Control_MouseLeave;
            }

            private void Control_Click(object sender, EventArgs e)
            {
                ToolClicked?.Invoke(this, e);
            }

            private void Control_MouseEnter(object sender, EventArgs e)
            {
                this.BackColor = Color.FromArgb(30, 30, 30);
                btn.BackColor = Color.FromArgb(30, 30, 30);
                lbl.BackColor = Color.FromArgb(30, 30, 30);
            }

            private void Control_MouseLeave(object sender, EventArgs e)
            {
                this.BackColor = Color.FromArgb(25, 25, 25);
                btn.BackColor = Color.FromArgb(25, 25, 25);
                lbl.BackColor = Color.FromArgb(25, 25, 25);
            }
        }

    }
}
