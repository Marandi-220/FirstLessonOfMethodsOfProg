using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns.Structure.proxy
{
    public class BDServiceProxy
    {
        Dictionary<string, string> news = new Dictionary<string, string>();
        BDService BDService = new BDService();
        public string GetNews(string city)
        {
            if (news.ContainsKey(city))
            {
                return news[city];
            }
            else
            {
                string result = BDService.GetNews(city);
                news[city] = result;
                return result;
            }

        }

    }
}
