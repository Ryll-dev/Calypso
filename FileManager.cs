using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calypso
{
    internal class FileManager
    {
        public static void RenameFilesTag(string directoryPath, string tag)
        {
            foreach (var dir in Directory.GetDirectories(directoryPath))
            {
                string newDirName = Path.Combine(directoryPath, tag + Path.GetFileName(dir));
                if (!Directory.Exists(newDirName))
                {
                    try
                    {
                        Directory.Move(dir, newDirName);
                    }
                    catch { }
                }
            }
            foreach (var file in Directory.GetFiles(directoryPath))
            {
                string fileName = Path.GetFileName(file);
                if (!fileName.StartsWith(tag))
                {
                    string newFileName = Path.Combine(directoryPath, tag + fileName);
                    if (!File.Exists(newFileName))
                    {
                        try
                        {
                            File.Move(file, newFileName);
                        }
                        catch { }
                    }
                }
            }
        }

        public static void DeleteFilesTag(string directoryPath, string tag)
        {
            foreach (var dir in Directory.GetDirectories(directoryPath))
            {
                if (Path.GetFileName(dir).StartsWith(tag))
                {
                    try
                    {
                        Directory.Delete(dir, true);
                    }
                    catch {}
                    
                }
            }

            foreach (var file in Directory.GetFiles(directoryPath))
            {
                if (Path.GetFileName(file).StartsWith(tag))
                {
                    try
                    {
                        File.Delete(file);
                    }
                    catch { }
                }
            }
        }
    }
}
