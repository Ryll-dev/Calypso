using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace Calypso
{
    public static class HttpService
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

        public static async Task<string> GetHtmlWithProxyAsync(
    string url,
    List<string> proxies,
    int timeout)
        {
            foreach (var raw in proxies.ToArray())
            {
                var parts = raw.Split(':');
                string ip, user = null, pass = null;
                int port;

                if (parts.Length == 2)
                {
                    ip = parts[0];
                    if (!int.TryParse(parts[1], out port))
                    {
                        proxies.Remove(raw);
                        continue;
                    }
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
                        proxies.Remove(raw);
                        continue;
                    }
                }
                else
                {
                    proxies.Remove(raw);
                    continue;
                }

                var webProxy = new WebProxy(ip, port);
                if (user != null && pass != null)
                    webProxy.Credentials = new NetworkCredential(user, pass);

                using (var client = new WebClientWithTimeout() { Timeout = timeout })
                {
                    client.Proxy = webProxy;
                    client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/83.0.4103.116 Safari/537.36");
                    client.Headers.Add("Accept", "*/*");
                    client.Headers.Add("Pragma", "no-cache");
                    client.Headers.Add("Accept-Language", "en-US,en;q=0.8");

                    try
                    {
                        string html = await client.DownloadStringTaskAsync(url);
                        if (html.Contains("To continue using Startpage") ||
                            html.Contains("Please enable javascript and reload the page"))
                        {
                            continue;
                        }
                        return html;
                    }
                    catch (WebException)
                    {
                        proxies.Remove(raw);
                    }
                }
            }

            return string.Empty;
        }

        private static bool IsIpPort(string ipPart, string portPart, out string ip, out int port)
        {
            ip = null;
            port = 0;
            if (!IPAddress.TryParse(ipPart, out _))
                return false;
            if (!int.TryParse(portPart, out var p) || p < 1 || p > 65535)
                return false;

            ip = ipPart;
            port = p;
            return true;
        }



        public static async Task<string> GetHtmlWithProxylessAsync(string url, int timeout)
        {
            using (var client = new WebClientWithTimeout() { Timeout = timeout })
            {
                client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/83.0.4103.116 Safari/537.36");
                client.Headers.Add("Accept", "*/*");
                client.Headers.Add("Pragma", "no-cache");
                client.Headers.Add("Accept-Language", "en-US,en;q=0.8");

                try
                {
                    string html = await client.DownloadStringTaskAsync(url);
                    return html;
                }
                catch
                {
                    return string.Empty;
                }
            }
        }
    }
}