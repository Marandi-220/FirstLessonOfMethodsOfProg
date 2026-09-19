using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns.Generation.builder
{
    internal class Building
    {
        public string foundation { get; set; }
        public string walls { get; set; }
        public string roof { get; set; }
        public string interior { get; set; }

        public override string ToString()
        {
            return "Building: " + foundation + ", " + walls + ", " + roof + ", " + interior;
        }

    }
}
