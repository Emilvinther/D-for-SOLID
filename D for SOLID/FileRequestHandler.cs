using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace D_for_SOLID
{
    public class FileRequestHandler : IRequest
    {
        // Method reading and returning a file
        public async Task<string> GetRequest(string url)
        {
            string test = await File.ReadAllTextAsync(url);

            return test;
        }
    }
}
