using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns.Generation.Structure.lightweight
{
    public class Citizenship
    {
        //гражданство
        public string Name;
        public override bool Equals(object obj)
        {
            return this.Name.Equals((Citizenship)obj);
        }
    }
}
