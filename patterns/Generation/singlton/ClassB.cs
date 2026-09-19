using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns.Generation
{
    internal class ClassB
    {
        public ClassB()
        {
            Logger log = Logger.GetInstance();
            log.Log("Class B was init");

            Console.WriteLine(log.GetHashCode());
        }

    }
}
