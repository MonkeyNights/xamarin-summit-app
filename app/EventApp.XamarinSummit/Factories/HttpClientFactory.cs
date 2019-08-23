using System;
using System.Net.Http;

namespace EventApp.XamarinSummit.Factories
{
    public static class HttpClientFactory
    {
        public static HttpClient CreateClient()
         => new HttpClient
         {
             BaseAddress = new Uri(AppConstants.API_ENDPOINT)
         };
    }
}
