namespace Calypso
{
    internal static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            bool shouldDelay = args.Contains("--delay");
            if (shouldDelay)
            {
                Thread.Sleep(5000);
            }
            FileManager.DeleteFilesTag(Application.StartupPath, "OLD_");
            ApplicationConfiguration.Initialize();
            Application.Run(new Calypso());
        }
    }
}