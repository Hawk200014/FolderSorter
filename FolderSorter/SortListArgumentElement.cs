using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderSorter
{
    internal class SortListArgumentElement
    {
        //--Storage Parts--
        //SortName
        //SortDirectory
        //SortKey
        //SortIndex
        //GUID 

        public string sortName;
        public string sortDirectory;
        public List<string> sortKey;
        public int sortIndex;
        public string guid;

        public SortListArgumentElement(string sortName, string sortDirectory, List<string> sortKey, int sortIndex, string guid)
        {
            this.sortName = sortName;
            this.sortDirectory = sortDirectory;
            this.sortKey = sortKey;
            this.sortIndex = sortIndex;
            this.guid = guid;
        }

        public SortListArgumentElement(string sortName, string sortDirectory, string[] sortKey, int sortIndex, string guid) 
        {
            this.sortName = sortName;
            this.sortDirectory = sortDirectory;
            this.sortKey = sortKey.ToList();
            this.sortIndex = sortIndex;
            this.guid = guid;
        }

        override
        public string ToString()
        {
            string result = "";
            result += sortIndex + "#";
            result += guid + "#";
            result += sortName + "#";
            result += sortDirectory + "#";
            foreach (string key in sortKey)
            {
                result+= key + ";";
            }
            result = result.Remove(result.Length- 1);
            return result;
        }

        public SortListArgumentElement(String element)
        {
            string[] arguments = element.Split('#');
            sortIndex = int.Parse(arguments[0]);
            guid = arguments[1];
            sortName = arguments[2];
            sortDirectory = arguments[3];
            sortKey = arguments[4].Split(";").ToList();
        }

        public string ToStringListView()
        {
            string result = "";
            result += GetSpaces(sortName, 30) + "|";
            result += GetSpaces(sortDirectory, 30) + "|";
            foreach (string arg in sortKey)
            {
                result += arg + ",";
            }
            if(sortKey.Count > 0)
            {
                result = result.Remove(result.Length - 1);
            }
            return result;
        }

        private string GetSpaces(string strobject, int spaces)
        {
            int restSpaces = strobject.Length - spaces;
            string result = strobject;
            for(int i = 0; i < restSpaces; i++)
            {
                result += " ";
            }
            return result;
        }

    }
}
