using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderSorter
{
    internal class FileManager
    {

        private FolderManager fm;

        public FileManager()
        {
            fm = new FolderManager();

        }

        public bool SourceFileConfigExists()
        {
            string sourceFolderPath = fm.GetSortDataPath();
            string[] fileNames = Directory.GetFiles(sourceFolderPath);
            if(fileNames.Length > 0)
            {
                for(int i = 0; i < fileNames.Length; i++)
                {
                    if (fileNames[i].Contains(KnowVariables.HEADFILE))
                    {
                        return true;
                    }
                }
                return false;
            }
            else
            { 
                return false;
            }
        }

        public string GetSourceFolderPath()
        {
            string path = "";
            if (SourceFileConfigExists())
            {
                path = fm.GetSortDataPath() + "\\" + KnowVariables.HEADFILE;
                string[] fileContent = File.ReadAllLines(path);
                //todo support for more sourceDirectories
                for(int i = 0; i < fileContent.Length; i++)
                {
                    return fileContent[i];
                }
            }
            else
            {
                path = fm.GetSortDataPath() + "\\" + KnowVariables.HEADFILE;
                File.Create(path).Close();
            }
            return path;
        }

        public void AddSourceFolderPathToConfig(string contentPath)
        {
            //todo support for more sourceDirectories
            File.WriteAllText(fm.GetSortDataPath() + "\\" + KnowVariables.HEADFILE, contentPath);
        }

    }
}
