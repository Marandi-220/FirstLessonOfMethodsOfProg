using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns.Generation.factoryMethod
{
    internal class NewComputer : IComputer
    {
        public void Run()
        {
            Console.WriteLine("Windows 11 initialized");
        }

        public void Stop()
        {
            Console.WriteLine("Windows 11 stopped");
        }
    }
}
