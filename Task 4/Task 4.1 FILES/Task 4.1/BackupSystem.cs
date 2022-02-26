using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace Task_4._1
{
    public  class BackupSystem
    {
        string sourseFolder;
        string logFolder;
        public BackupSystem(string sourseFolder, string logFolder)
        {
            this.sourseFolder = sourseFolder;
            this.logFolder = logFolder;
        }
        public void Backup()
        { 
            var logDirectory = new DirectoryInfo(logFolder + Console.ReadLine());
            if (logDirectory.Exists)
            {
                LoggingChanges.CopyDirectory(logDirectory.ToString(), sourseFolder, true);
            }
            else
                Console.WriteLine("There is no backup for this time!");
        }
        public void ExistsDirectory(string logFolder)
        {
            var logDirectory = new DirectoryInfo(logFolder);
            if (logDirectory.Exists)
                foreach (var dir in logDirectory.GetDirectories())
                {
                    Console.WriteLine(dir.Name);
                }
            else
                Console.WriteLine("The list of backups is empty");
        }
    }

}
