using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns.Generation
{
    internal class Logger 
    {
        public static readonly Logger Instance = new Logger();
        private Logger() { }
        public static Logger GetInstance()
        {
            return Instance;
        }
        public void Log(string message)
        {
            Console.WriteLine(message);
        }

    }
}
