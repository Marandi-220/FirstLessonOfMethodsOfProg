using patterns.Generation;
using patterns.Generation.abstractFactory;
using patterns.Generation.factoryMethod;
using patterns.Generation.prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Singlton.Run();
            //Prototype.Run();
            //FactoryMethod.Run();
            AbstractFactory.Run();
        }
    }
}
