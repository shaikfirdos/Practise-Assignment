using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace MVC
{
    public static class GlobalVariables//it is cretaing for access the webapi methodss into mvc project
    {
        public static HttpClient WebApiClient= new HttpClient();

       static GlobalVariables()
        {
            WebApiClient.BaseAddress = new Uri("http://localhost:52392/api/");//Now we can use httpclientobject inside the mvc controller
            WebApiClient.DefaultRequestHeaders.Clear();
            WebApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}