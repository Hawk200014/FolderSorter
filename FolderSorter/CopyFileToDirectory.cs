using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderSorter
{
    internal class CopyFileToDirectory
    {

        public string[] GetFilesWithName(string path,string name)
        {
            List<String> filepathToMove = new List<String>();
            string[] files = Directory.GetFiles(path);
            foreach (string filepath in files)
            {
                string filename = Path.GetFileName(filepath);
                
                if (filename.ToLower().Contains(name.ToLower()))
                {
                    filepathToMove.Add(filepath);
                }
            }
            return filepathToMove.ToArray();
        }

        public int CountFilesWithName(string path, string name)
        {
            return GetFilesWithName(path, name).Length;
        }



        public static bool CpFtoDir(string filepath, string directory)
        {
            string fileName = Path.GetFileName(filepath);
            string newFilePath = Path.Combine(directory, fileName);
            if (!File.Exists(newFilePath))
            {
                File.Move(filepath, newFilePath);
                return true;
            }
            return false;
        }
    }
}
