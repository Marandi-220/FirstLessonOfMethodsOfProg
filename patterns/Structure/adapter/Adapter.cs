using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns.Generation.Structure.adapter
{
    public class Adapter
    {
        public static void Run()
        {
            //string jsonS = "{\r\n  \"name\": \"Alice\",\r\n  \"age\": 28,\r\n  \"isHuman\": true\r\n}";
            //JsonLogger.Log(jsonS);
            //Console.WriteLine();

            string xmlS = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>\r\n<book>\r\n    " +
                "<title>Эффективный Java</title>\r\n    <author>Бертран Мейер</author>\r\n    <year>2014</year>\r\n    " +
                "<price currency=\"RUB\">4500</price>\r\n</book>\r\n";
            XmlLoggerAdapter.Conv(xmlS);
        }

    }
}
