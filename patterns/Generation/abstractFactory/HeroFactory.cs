using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns.Generation.abstractFactory
{
    internal class HeroFactory
    {
        public static Hero CreateRanger()
        {
            return new Hero(new Shoot(), new Run(), "Ranger");
        }

        public static Hero CreatePudge()
        {
            return new Hero(new Swing(), new Run(), "Pudge");
        }

        public static Hero CreateViper()
        {
            return new Hero(new Shoot(), new Fly(), "Viper");
        }

        public static Hero CreateGendalf()
        {
            return new Hero(new Cast(), new Fly(), "Gendalf");
        }

    }
}
