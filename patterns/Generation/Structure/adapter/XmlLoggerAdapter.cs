using System;
using System.Text.Json.Serialization;
using System.Text.Json.Nodes;
using System.Xml.Linq;

namespace patterns.Generation.Structure.adapter
{
    public static class XmlLoggerAdapter
    {
        //xml to json
        public static void Conv (string xml)
        {
            var xdoc = XDocument.Parse(xml).Root;
            var jsonLogger = new JsonLogger();
            var jsonOb = new JsonObject();

            foreach (var property in xdoc.Elements())
            {
                jsonOb.Add(property.Name.LocalName, property.Value);
            }

            JsonLogger.Log(jsonOb.ToJsonString());
        }

    }
}
