using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mime;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReaLTaiizor.Controls;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static Calypso.HttpRequest;

namespace Calypso
{
    public partial class HttpRequest : Form
    {
        public class Header
        {
            public string Name { get; set; }
            public string Value { get; set; }
        }

        public class CookieItem
        {
            public string Name { get; set; }
            public string Value { get; set; }
        }
        public class ContentBody
        {
            public string ContentType { get; set; }
            public string Content { get; set; }
        }

        public class Response
        {
            public List<Header> Headers { get; set; }
            public List<CookieItem> Cookies { get; set; }
            public ContentBody Body { get; set; }
            public int StatusCode { get; set; }
            public long MS { get; set; }
        }

        public HttpRequest()
        {
            InitializeComponent();
            FormUIHelper.ApplyUI(this, true, true, true, true, true, true, ContentAlignment.MiddleCenter);
        }

        private void HttpRequest_Load(object sender, EventArgs e)
        {
            cmbCONTENTTYPE.SelectedIndex = 0;
            cmbREQUESTTYPE.SelectedIndex = 0;
        }
        public static class Http
        {
            public static async Task<Response> Get(string url, List<Header> headers, List<CookieItem> cookies)
            {
                long ms = 0;
                try
                {
                    var handler = new HttpClientHandler();
                    handler.UseCookies = true;
                    handler.CookieContainer = new CookieContainer();
                    foreach (var cookie in cookies)
                    {
                        handler.CookieContainer.Add(new Uri(url), new Cookie(cookie.Name, cookie.Value));
                    }

                    using (var client = new HttpClient(handler))
                    {
                        foreach (var header in headers)
                        {
                            client.DefaultRequestHeaders.Add(header.Name, header.Value);
                        }
                        var stopwatch = Stopwatch.StartNew();
                        HttpResponseMessage httpResponse;
                        try
                        {
                            httpResponse = await client.GetAsync(url);
                        }
                        finally
                        {
                            stopwatch.Stop();
                            ms = stopwatch.ElapsedMilliseconds;
                        }
                        string responseContent = await httpResponse.Content.ReadAsStringAsync();
                        List<Header> responseHeaders = new List<Header>();
                        foreach (var item in httpResponse.Headers)
                        {
                            foreach (var value in item.Value)
                            {
                                responseHeaders.Add(new Header { Name = item.Key, Value = value });
                            }
                        }
                        List<CookieItem> responseCookies = new List<CookieItem>();
                        Uri uri = new Uri(url);
                        var cookieCollection = handler.CookieContainer.GetCookies(uri);
                        foreach (Cookie cookie in cookieCollection)
                        {
                            responseCookies.Add(new CookieItem { Name = cookie.Name, Value = cookie.Value });
                        }
                        Response response = new Response
                        {
                            Headers = responseHeaders,
                            Cookies = responseCookies,
                            Body = new ContentBody { Content = responseContent, ContentType = httpResponse.Content.Headers.ContentType?.MediaType },
                            StatusCode = (int)httpResponse.StatusCode,
                            MS = ms
                        };
                        return response;
                    }
                }
                catch (Exception ex)
                {
                    return new Response
                    {
                        Headers = null,
                        Cookies = null,
                        Body = new ContentBody
                        {
                            Content = ex.Message,
                            ContentType = null
                        },
                        StatusCode = 999,
                        MS = ms
                    };
                }
            }

            public static async Task<Response> Post(string url, List<Header> headers, List<CookieItem> cookies, ContentBody body)
            {
                long ms = 0;
                try
                {
                    var handler = new HttpClientHandler();
                    handler.UseCookies = true;
                    handler.CookieContainer = new CookieContainer();
                    foreach (var cookie in cookies)
                    {
                        handler.CookieContainer.Add(new Uri(url), new Cookie(cookie.Name, cookie.Value));
                    }

                    using (var client = new HttpClient(handler))
                    {
                        HttpContent content = null;
                        if (body != null)
                        {
                            switch (body.ContentType)
                            {
                                case "application/x-www-form-urlencoded":
                                    var formData = body.Content.Split('&')
                                    .Select(p => p.Split('='))
                                    .ToDictionary(k => Uri.UnescapeDataString(k[0]), v => Uri.UnescapeDataString(v[1]));
                                    content = new FormUrlEncodedContent(formData);
                                    break;
                                default:
                                    content = new StringContent(body.Content ?? string.Empty, Encoding.UTF8, body.ContentType);
                                    break;
                            }
                        }

                        foreach (var header in headers.Where(h => !h.Name.Equals("Content-Type", StringComparison.OrdinalIgnoreCase)))
                        {
                            client.DefaultRequestHeaders.Add(header.Name, header.Value);
                        }

                        var stopwatch = Stopwatch.StartNew();
                        HttpResponseMessage httpResponse;
                        try
                        {
                            httpResponse = await client.PostAsync(url, content ?? new StringContent(""));
                        }
                        finally
                        {
                            stopwatch.Stop();
                            ms = stopwatch.ElapsedMilliseconds;
                        }

                        string responseContent = await httpResponse.Content.ReadAsStringAsync();

                        List<Header> responseHeaders = httpResponse.Headers
                            .SelectMany(h => h.Value.Select(v => new Header { Name = h.Key, Value = v }))
                            .ToList();

                        List<CookieItem> responseCookies = handler.CookieContainer
                            .GetCookies(new Uri(url))
                            .Cast<Cookie>()
                            .Select(c => new CookieItem { Name = c.Name, Value = c.Value })
                            .ToList();

                        return new Response
                        {
                            Headers = responseHeaders,
                            Cookies = responseCookies,
                            Body = new ContentBody
                            {
                                Content = responseContent,
                                ContentType = httpResponse.Content.Headers.ContentType?.MediaType
                            },
                            StatusCode = (int)httpResponse.StatusCode,
                            MS = ms
                        };
                    }
                }
                catch (Exception ex)
                {
                    return new Response
                    {
                        Headers = null,
                        Cookies = null,
                        Body = new ContentBody
                        {
                            Content = ex.Message,
                            ContentType = null
                        },
                        StatusCode = 999,
                        MS = ms
                    };
                }
            }
        }

        private async void btnSENDREQ_Click(object sender, EventArgs e)
        {
            List<Header> headers = new List<Header>();
            if (cmbREQUESTTYPE.SelectedIndex == 0 || cmbREQUESTTYPE.SelectedIndex == 3 || cmbREQUESTTYPE.SelectedIndex == 4 || cmbREQUESTTYPE.SelectedIndex == 6)
                headers.Add(new Header { Name = "Content-Type", Value = cmbCONTENTTYPE.Text });
            string[] headerlist = rtxtHEADERS.Text.Split("\n");
            foreach (var hdr in headerlist)
            {
                if (hdr.Contains(":"))
                {
                    headers.Add(new Header { Name = hdr.Substring(0, hdr.IndexOf(":")), Value = hdr.Substring(hdr.IndexOf(":") + 1, hdr.Length - hdr.IndexOf(":") - 1) });
                }
            }
            List<CookieItem> cookies = new List<CookieItem>();
            string[] cookielist = rtxtCOOKIES.Text.Split("\n");
            foreach (var cookie in cookielist)
            {
                if (cookie.Contains(":"))
                {
                    cookies.Add(new CookieItem { Name = cookie.Substring(0, cookie.IndexOf(":")), Value = cookie.Substring(cookie.IndexOf(":") + 1, cookie.Length - cookie.IndexOf(":") - 1) });
                }
            }
            Response response = new Response();
            string url = txtURL.Text;
            if (url.Contains("https://") == false && url.Contains("http://") == false)
            {
                url = "http://" + url;
            }
            switch (cmbREQUESTTYPE.SelectedIndex)
            {
                case 0:
                    response = await Http.Post(url, headers, cookies, new ContentBody { ContentType = cmbCONTENTTYPE.Text, Content = rtxtCONTENT.Text });
                    break;
                case 1:
                    response = await Http.Get(url, headers, cookies);
                    break;
            }
            if (response.StatusCode == 999)
            {
                WarnUser warn = new WarnUser("Write the required format in Content-Body");
                warn.Show();
                if (lblSTATUS.Visible == false)
                {
                    lblSTATUS.Visible = true;
                    lblSTATUSCODE.Visible = true;
                    lblMS.Visible = true;
                    lblMSS.Visible = true;
                }
                lblSTATUSCODE.Text = response.StatusCode.ToString();
                lblMSS.Text = response.MS.ToString();
            }
            if (response != null)
            {
                try
                {
                    if (lblSTATUS.Visible == false)
                    {
                        lblSTATUS.Visible = true;
                        lblSTATUSCODE.Visible = true;
                        lblMS.Visible = true;
                        lblMSS.Visible = true;
                    }
                    lblSTATUSCODE.Text = response.StatusCode.ToString();
                    lblMSS.Text = response.MS.ToString();
                }
                catch { }
                try
                {
                    rtxtrHEADERS.Clear();
                    foreach (var header in response.Headers)
                    {
                        rtxtrHEADERS.AppendText($"{header.Name}: {header.Value}{Environment.NewLine}");
                    }
                }
                catch { }
                try
                {
                    rtxtrCOOKIES.Clear();
                    foreach (var cookie in response.Cookies)
                    {
                        rtxtrCOOKIES.AppendText($"{cookie.Name}: {cookie.Value}{Environment.NewLine}");
                    }
                }
                catch { }
                try
                {
                    rtxtrCONTENT.Text = response.Body.Content;
                }
                catch { }
            }
        }
    }
}
