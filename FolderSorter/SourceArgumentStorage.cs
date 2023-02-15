using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderSorter
{
    internal class SourceArgumentStorage
    {
        public List<SourceListArgumentElement> sourceListArgumentElements;
        private FolderManager fm = new FolderManager();
        public SourceArgumentStorage() 
        {
            sourceListArgumentElements= new List<SourceListArgumentElement>();
            LoadElements();
        }

        public void SaveElements()
        {
            string destpath = fm.GetSortDataPath();
            foreach(SourceListArgumentElement element in sourceListArgumentElements) 
            {
                File.WriteAllText(destpath + "\\" + element.guid, element.ToString());
            }
        }

        public void LoadElements()
        {
            sourceListArgumentElements.Clear();
            string destpath = fm.GetSortDataPath();
            string[] files = Directory.GetFiles(destpath);
            foreach (string file in files)
            {
                string content = File.ReadAllText(file);
                string[] data = content.Split(";");
                AddSourceElement(data[0], data[1], data[3]);
            }
        }

        public void AddSourceElement(string path, string name, string guid = "")
        {
            if(string.IsNullOrEmpty(guid.Trim()))
            {
                sourceListArgumentElements.Add(new SourceListArgumentElement(path, name));
                return;
            }
            sourceListArgumentElements.Add(new SourceListArgumentElement(path, name ,guid));
        }

    }
}
