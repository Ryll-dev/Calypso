using Microsoft.Win32;
using static Calypso.CustomTaskbarShow;

public static class InstalledAppReader
{
    public class InstalledApp
    {
        public string Name { get; set; }
        public string ExecutablePath { get; set; }
        public Icon Icon { get; set; }
    }
    public static List<InstalledApp> GetInstalledApplications()
    {
        List<InstalledApp> apps = new List<InstalledApp>();

        string[] registryKeys = new string[]
        {
            @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall",
            @"SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall"
        };

        foreach (string keyPath in registryKeys)
        {
            using (RegistryKey baseKey = Registry.LocalMachine.OpenSubKey(keyPath))
            {
                if (baseKey == null) continue;

                foreach (string subKeyName in baseKey.GetSubKeyNames())
                {
                    using (RegistryKey subKey = baseKey.OpenSubKey(subKeyName))
                    {
                        if (subKey == null) continue;

                        string name = subKey.GetValue("DisplayName") as string;
                        string iconPath = subKey.GetValue("DisplayIcon") as string;
                        string installLocation = subKey.GetValue("InstallLocation") as string;

                        if (!string.IsNullOrEmpty(name))
                        {
                            Icon appIcon = null;
                            if (!string.IsNullOrEmpty(iconPath) && File.Exists(iconPath.Split(',')[0]))
                            {
                                try
                                {
                                    appIcon = Icon.ExtractAssociatedIcon(iconPath.Split(',')[0]);
                                }
                                catch { }
                            }

                            apps.Add(new InstalledApp
                            {
                                Name = name,
                                ExecutablePath = iconPath?.Split(',')[0] ?? installLocation,
                                Icon = appIcon
                            });
                        }
                    }
                }
            }
        }

        return apps;
    }
}
