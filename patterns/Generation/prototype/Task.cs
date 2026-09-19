using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns.Generation.prototype
{
    internal class Task : ITask
    {

        public string description { get; set; }
        public ITask Clone()
        {
            Task clone = new Task();
            clone.description = description;
            return clone;
        }

        public string GetDescription()
        {
            return "Description: " + description;
        }

        public override bool Equals(object obj)
        {
            return this.description.Equals( ((Task)obj).description );
        }
    }
}
