using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace desktop_application.Controllers
{
    class ApiController
    {
        public static HttpClient ApiClient { get; set; }

        public static void InitializeClient()
        {
            ApiClient = new HttpClient(new HttpClientHandler { UseProxy = false });
            ApiClient.BaseAddress = new Uri("http://localhost:5000/api/v1/");
            ApiClient.DefaultRequestHeaders.Accept.Clear();
        }
    }
}
