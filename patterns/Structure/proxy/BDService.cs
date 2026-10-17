using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace patterns.Structure.proxy
{
    public class BDService
    {
        public string GetNews(string city)
        {
            Thread.Sleep(1000);
            return $"Новости для {city}";
        }
    }
}
