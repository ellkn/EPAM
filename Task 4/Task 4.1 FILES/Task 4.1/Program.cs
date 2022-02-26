using Serilog;
using System;
using System.IO;

namespace Task_4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourseFolder = @"..\..\..\TaskFolder\";
            string logFolder = @"..\..\..\TaskFolder\LogFolder\";

            Log.Logger = (ILogger)new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.File(@"..\..\..\ChandingLogger.txt", rollingInterval: RollingInterval.Infinite)
                .CreateLogger();

            int mode;
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Choose your mode");
                Console.WriteLine("1. Observation");
                Console.WriteLine("2. Backuping");
                Console.WriteLine("0. EXIT");
                Console.ForegroundColor = ConsoleColor.White;
                mode = GetConsoleIntValue();
                switch (mode)
                {
                    case 0:
                        return;
                    case 1:
                        Console.WriteLine("[Observation mode]");
                        Log.Debug($"Change tracking has started  at {DateTime.Now}");
                        try 
                        {
                            var observer = new LoggingChanges(sourseFolder, logFolder);
                            observer.Watcher();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        Log.Debug($"Change tracking has finished at {DateTime.Now}\n");
                        break;
                    case 2:
                        var backup = new BackupSystem(sourseFolder, logFolder);
                        Console.WriteLine("[Backuping mode]");
                        Console.WriteLine("You have the ability to backup to this data: ");
                        backup.ExistsDirectory(logFolder);
                        Console.WriteLine("Enter the selected value: ");
                        backup.Backup();
                        break;
                    default:
                        Console.WriteLine("Incorrect input. Try Again!");
                        break;
                }
            } while (mode != 0);
        }
        public static int GetConsoleIntValue()
        {
            Boolean isNegative = true;
            while (isNegative)
            {
                string value = Console.ReadLine();
                int result = 0;
                if (!int.TryParse(value, out result) || result < 0 || result > 2)
                {
                    Console.WriteLine("Ошибка ввода! Введите корректное значение");
                }
                else
                {
                    isNegative = false;
                    return result;
                }
            }
            return 0;
        }
    }
}
