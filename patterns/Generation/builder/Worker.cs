using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns.Generation.builder
{
    internal class Worker
    {
        public Worker()
        {
            building = new Building();
        }

        private Building building;
        public Building build()
        {
            return building;
        }

        public Worker foundation(string foundation)
        {
            building.foundation = foundation;
            return this;
        }

        public Worker walls(string walls)
        {
            building.walls = walls;
            return this;
        }

        public Worker roof(string roof)
        {
            building.roof = roof;
            return this;
        }

        public Worker interior(string interior)
        {
            building.interior = interior;
            return this;
        }
    }

}
