using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns.Structure.facade
{
    public class Facade
    {
        public static void Run()
        {
            StreamReaderFacade facade = new StreamReaderFacade();
            Console.WriteLine(facade.ReadFromFile("TextFile1") );
        }
    }
}
