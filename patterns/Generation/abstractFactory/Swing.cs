using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns.Generation.abstractFactory
{
    internal class Swing : IHit
    {
        public void Hit()
        {
            Console.WriteLine("I swing!");
        }
    }
}
