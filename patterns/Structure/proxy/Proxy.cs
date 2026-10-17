using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patterns.Structure.proxy
{
    public class Proxy
    {
        public static void Run()
        {
            BDService service = new BDService();
            BDServiceProxy proxyservice = new BDServiceProxy();
            for (int i = 0; i < 10; i++)
            {
                //Console.WriteLine(service.GetNews("city"));
                Console.WriteLine(proxyservice.GetNews("city"));
            }
        }
    }
}
