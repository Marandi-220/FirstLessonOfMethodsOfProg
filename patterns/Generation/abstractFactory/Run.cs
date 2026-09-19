using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns.Generation.abstractFactory
{
    internal class Run : IMove
    {
        public void Move()
        {
            Console.WriteLine("I run!");
        }
    }
}
