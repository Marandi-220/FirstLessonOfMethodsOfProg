using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns.Generation.Structure.lightweight
{
    public class Lightweight
    {
        public static void Run()
        {
            Citizenship a = new Citizenship();
            a.Name = "Rus";
            Citizenship b = new Citizenship();
            b.Name = "Rus";
            Citizenship c = new Citizenship();
            c.Name = "Belarus";

            MVD mvd = new MVD();
            mvd.citizenships.Add(a);
            mvd.citizenships.Add(b);
            mvd.citizenships.Add(c);

            mvd.GetCitizenship("Rus");


        }
    }
}
