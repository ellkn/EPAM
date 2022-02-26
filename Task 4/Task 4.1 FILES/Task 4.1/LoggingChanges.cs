using Microsoft.VisualBasic.FileIO;
using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4._1
{
    public class LoggingChanges
    {
        private string _sourseFolder; // Оригинальная папка, в которой работаем
        private string _logFolder; // папка для логирования

        public LoggingChanges(string sourseFolder, string logFolder)
        {
            this._sourseFolder = sourseFolder;
            this._logFolder = logFolder;
        }

        //ловим разные события: создание, удаление, изменение
        //фильтруем: только текстовые файлы
        public void Watcher() 
        {
            Console.WriteLine("Change tracking has started, to finish, press any key");
            using var watcher = new FileSystemWatcher(_sourseFolder);

            watcher.NotifyFilter = NotifyFilters.FileName
                                | NotifyFilters.DirectoryName
                                | NotifyFilters.LastAccess
                                | NotifyFilters.LastWrite;

            watcher.Changed += OnChanged;
            watcher.Created += OnCreated;
            watcher.Deleted += OnDeleted;
            watcher.Renamed += OnRenamed;

            watcher.Filter = "*.txt";
            watcher.IncludeSubdirectories = true;
            watcher.EnableRaisingEvents = true;
            Console.ReadLine();
        }
        //обработка подписок
        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            if (e.ChangeType != WatcherChangeTypes.Changed)
            {
                return;
            }
            // почему-то логируется по +-16 раз на одно событие. возможно, что-то упускаю
            Log.Debug($"The element: {e.Name} was changed on the path {e.FullPath}");
            CreateACopyOfFiles();
        }

        private void OnCreated(object sender, FileSystemEventArgs e)
        {
            Log.Debug($"The element: {e.Name} was created on the path {e.FullPath}");
            CreateACopyOfFiles();
        }
        private void OnDeleted(object sender, FileSystemEventArgs e)
        {
            Log.Debug($"The element: {e.Name} was deleted on the path {e.FullPath}");
            CreateACopyOfFiles();
        }
        private void OnRenamed(object sender, RenamedEventArgs e)
        {
            Log.Debug($"Renamed:");
            Log.Debug($"    Old: {e.OldFullPath}");
            Log.Debug($"    New: {e.FullPath}");
            CreateACopyOfFiles();
        }

        //копируем наши изменения в новую папку, для того, чтобы откатываться к разным версиям
        public void CreateACopyOfFiles()
        {
            var date = DateTime.Now.ToString("dd.MM.yyyy_hh.mm.ss");
            var copyFolder = _logFolder + date;
            try
            {
                CopyDirectory(_sourseFolder, copyFolder, true);
            }
            catch (Exception e)
            {
                Log.Error(e.Message);
            }
        }
        public static void CopyDirectory(string sourseFolder, string logFolder, bool copySubDir)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(sourseFolder);

            if (!directoryInfo.Exists)
            {
                Log.Error($"Directory - {sourseFolder} -  doesn't exist / couldn't be found");
            }

            DirectoryInfo[] directorys = directoryInfo.GetDirectories();

            if (!Directory.Exists(logFolder))
            {
                Directory.CreateDirectory(logFolder);
            }

            FileInfo[] files = directoryInfo.GetFiles(); 
            foreach (FileInfo file in files)
            {
                var tempPath = Path.Combine(logFolder, file.Name);
                try
                {
                    file.CopyTo(tempPath, true);
                }
                catch (IOException e)
                {
                    Log.Error(e.Message);
                }
            }
        }
    }
}
