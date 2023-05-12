using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_for_SOLID
{
    public interface IRequest
    {
        // Interface for requests
        Task<string> GetRequest(string url);
    }
}
