using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Language_Features.Models
{
    // Asynchronous methods perform tasks in background while we can do other stuff
    // asynchronous methods can be used to improve the overall performance of an application
    // Two C# keywords— async and await are used
    public class MyAsyncMethods
    {
        // This method uses a System.Net.Http.HttpClient object to request the 
        // contents of the Apress homepage and returns its length
        // Approach in last method is long and confusing.. 
        // So we use async and await keyword
        public async static Task<long?> GetPageLength()
        {
            HttpClient client = new HttpClient();

            var httpMessage = await client.GetAsync("http://apress.com");

            return httpMessage.Content.Headers.ContentLength;
        }
    }
}
