using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace D_for_SOLID
{
    public class WebRequestHandler : IRequest
    {

        // Method that uses HttpClient to get a request from a website
        public async Task<string> GetRequest(string url)
        {
            string test;
            try
            {
                using HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(url);
                HttpResponseMessage response = await client.GetAsync(url);
                test = await response.Content.ReadAsStringAsync();

            }
            catch (UriFormatException)
            {

                test = "Url is incorrect";

            } 
            

            return test;

        }
    }


}
