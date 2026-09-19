using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns.Generation.factoryMethod
{
    internal class ComputerFactory
    {
        public static IComputer CreateNewComputer()
        {
            return new NewComputer();
        }
        public static IComputer CreateOldComputer()
        {
            return new OldComputer();
        }

    }
}
