using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns.Generation.abstractFactory
{
    internal class AbstractFactory
    {
        public static void Run()
        {
            Hero pudg = HeroFactory.CreatePudge();
            Hero viper = HeroFactory.CreateViper();
            Hero ranger = HeroFactory.CreateRanger();

            
            pudg.Hit();
            viper.Hit();
            ranger.Hit();

            pudg.Move();
            viper.Move();
            ranger.Move();

            Console.WriteLine();
            Console.WriteLine("Ba! New character:");
            Hero gendalf = HeroFactory.CreateGendalf();
            gendalf.Move();
            gendalf.Hit();

        }

    }
}
