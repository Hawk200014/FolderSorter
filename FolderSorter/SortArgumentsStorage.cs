using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderSorter
{
    internal class SortArgumentsStorage
    {
        public List<SortListArgumentElement> sortListArguments;

        public SortArgumentsStorage()
        {
            sortListArguments = new List<SortListArgumentElement>();
            LoadArguments();
        }

        private void LoadArguments()
        {
            string destPath = Program.folderManager.GetDestinationDataPath();
            string[] fileNames = Directory.GetFiles(destPath);
            foreach (string fileName in fileNames)
            {
                sortListArguments.Add(new SortListArgumentElement(File.ReadAllText(fileName)));
            }
        }

        public void SaveArgumentElements()
        {
            string destinationPath = Program.folderManager.GetDestinationDataPath();
            foreach (SortListArgumentElement argument in sortListArguments)
            {
                File.WriteAllText(destinationPath + "\\" + argument.guid, argument.ToString());
            }
        }

        public void RemoveArgumentElement(string GUID)
        {
            string path = Program.folderManager.GetDestinationDataPath() + "\\" + GUID;
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            LoadArguments();
        }




    }
}
