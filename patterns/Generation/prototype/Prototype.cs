using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns.Generation.prototype
{
    internal class Prototype
    {
        public static void Run()
        {
            Task task1 = new Task();
            task1.description = "First Task";

            var task2 = task1.Clone();
            int hash1 = task1.GetHashCode();
            int hash2 = task2.GetHashCode();
            Console.WriteLine(hash1);
            Console.WriteLine(hash2);

            Console.WriteLine(task1.Equals(task2));
        } 

    }
}
