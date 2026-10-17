using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns.Structure.composite
{
    public class Folder
    {
        public string Name { get; set; }
        public List<File> Files = new List<File>();
        public List<Folder> Folders = new List<Folder>();
        public int GetSize()
        {
            int sum = 0;
            foreach (Folder folder in Folders)
            {
                sum += folder.GetSize();
            }
            foreach (File file in Files)
            {
                sum += file.Size;
            }

            return sum;
        }
    }
}
