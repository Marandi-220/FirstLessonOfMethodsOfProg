using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns.Generation.factoryMethod
{
    internal class FactoryMethod
    {
        public static void Run()
        {
            IComputer computer1 = ComputerFactory.CreateNewComputer();
            IComputer computer2 = ComputerFactory.CreateOldComputer();

            computer1.Run();
            computer2.Run();

            //computer1.Stop();
            //computer2.Stop();

        }

    }
}
