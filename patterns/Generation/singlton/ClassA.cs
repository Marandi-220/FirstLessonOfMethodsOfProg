using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns.Generation
{
    internal class ClassA
    {
        public ClassA()
        {
            Logger log = Logger.GetInstance();
            log.Log("Class A was init");

            Console.WriteLine(log.GetHashCode());
        }

    }
}
