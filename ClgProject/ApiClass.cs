using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ClgProject
{
    class ApiClass
    {
        private static readonly string apiUri = "http://172.16.3.55:3000/";


        public static async Task<string> Post<T>(string url, T contentModel)
        {

            using (HttpClient httpClient = new HttpClient())
            {

                httpClient.BaseAddress = new Uri(apiUri);
                var content = new StringContent(JsonConvert.SerializeObject(contentModel), Encoding.UTF8, "application/json");
                string mainurl = apiUri + url;
                var response = await httpClient.PostAsync(mainurl, content);
                response.EnsureSuccessStatusCode();
                string resultContentString = await response.Content.ReadAsStringAsync();
                return resultContentString;
            }

        }
    }
}
