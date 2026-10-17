using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace patterns.Structure.facade
{
    public class StreamReaderFacade
    {
        public string ReadFromFile(string filename)
        {
            string result = "";
            using (StreamReader sr = new StreamReader(filename + ".txt"))
            {
                result = sr.ReadToEnd();
            }
            return result;
        }
    }
}
