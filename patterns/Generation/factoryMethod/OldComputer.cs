using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns.Generation.factoryMethod
{
    internal class OldComputer : IComputer
    {
        public void Run()
        {
            Console.WriteLine("Windows 98 initialized");
        }

        public void Stop()
        {
            Console.WriteLine("Windows 98 stopped");
        }
    }
}
