using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_for_SOLID
{
    public class RequestResult
    {
        // Result class for output
        public string Results(string url, IRequest wr)
        {
            return wr.GetRequest(url).Result;
        }
    }
}
