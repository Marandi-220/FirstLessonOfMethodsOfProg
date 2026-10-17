using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns.Generation.Structure.lightweight
{
    public class MVD
    {
        public HashSet<Citizenship> citizenships = new HashSet<Citizenship>();
        public void GetCitizenship (string title)
        {
            var a = from x in citizenships
                    where x.Equals(title)
                    select x;

            foreach (var x in a)
            {
                Console.WriteLine(x);
            }
        }
    }
}
