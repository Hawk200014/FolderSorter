using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderSorter
{
    internal class SourceListArgumentElement
    {
        public string sourcePath;
        public string guid;
        public string name;

        public SourceListArgumentElement(string[] data) 
        {
            this.sourcePath= data[0];
            this.guid= data[1];
            this.name= data[2];
        }

        public SourceListArgumentElement(string sourcePath, string guid, string name) 
        {
            this.sourcePath = sourcePath;
            this.guid = guid;
            this.name= name;
        }

        public SourceListArgumentElement(string sourcepath, string name)
        {
            this.sourcePath = sourcepath;
            this.guid = Guid.NewGuid().ToString();
            this.name= name;
        }

        public string toListString()
        {
            return name + " | " + sourcePath;
        }

        override
        public string ToString() 
        { 
            return this.sourcePath +";" + this.guid;
        }
    }
}
