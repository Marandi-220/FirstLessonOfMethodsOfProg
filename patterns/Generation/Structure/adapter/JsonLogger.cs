using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Runtime.InteropServices;


namespace patterns.Generation.Structure.adapter
{
    public class JsonLogger
    {
        public static void Log(string jsonline)
        {
            var json = JsonDocument.Parse(jsonline);
            foreach (var property in json.RootElement.EnumerateObject())
            {
                Console.WriteLine($"{property.Name}: {property.Value}");
            }
        }

    }
}
