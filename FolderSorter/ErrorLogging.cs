using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderSorter
{
    internal class ErrorLogging
    {

        public void Log(string error)
        {
            Thread print = new Thread(() => LogErrorAsync(error));
            print.Start(error);
        }

        public void LogErrorAsync(string error)
        {
            error = GetTime() + ": " + error;
            bool isNewFile = InitFilesAndFolders();
            string prevFileContent = "";
            if (!isNewFile)
            {
                prevFileContent = File.ReadAllText(GetFilePath());
            }
            File.WriteAllText(GetFilePath(), prevFileContent + error + "\n");
        }

        private bool InitFilesAndFolders()
        {
            string errorFolderPath = GetLogFolderPath();
            Directory.CreateDirectory(errorFolderPath);
            string errorFilePath = GetFilePath();
            if (!File.Exists(errorFilePath))
            {
                File.Create(errorFolderPath);
                return true;
            }
            return false;
        }

        private  string GetFilePath()
        {
            string errorFolderPath = GetLogFolderPath();
            return Path.Combine(errorFolderPath, GetLogFileName());
        }

        private string GetLogFolderPath()
        {
            string programmFolder = Environment.CurrentDirectory;
            string errorFolderPath = System.IO.Path.Combine(programmFolder, "logs");
            return errorFolderPath;
        }

        private string GetLogFileName()
        {
            string date = DateTime.Now.ToString("dd_MM_yyyy");
            return "log_" + date;
        }

        private string GetTime()
        {
            return DateTime.Now.ToString("ss-mm-HH");
        }
    }
}
