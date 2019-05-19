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
        public static Task<long?> GetPageLength()
        {
            HttpClient client = new HttpClient();
            var httpTask = client.GetAsync("http://apress.com"); // get back is a Task<HttpResponseMessage> .

            // we could do other things here while the HTTP request is performed
            // continue with specifies we are returning a Task<HttpResponseMessage > object
            return httpTask.ContinueWith((Task<HttpResponseMessage> antecedent) =>
            {
                return antecedent.Result.Content.Headers.ContentLength;//  return the length of the ContentLength header. 
            });
        }
    }
}
