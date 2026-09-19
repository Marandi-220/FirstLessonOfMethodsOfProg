using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns.Generation.builder
{
    internal class Builder
    {
        public void Run()
        {
            Building building = new Worker().foundation("Foundation1")
                .walls("Walls1")
                .roof("Roof1")
                .interior("Interior1")
                .build();
        }


    }
}
