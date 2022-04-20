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
using System.Text;

namespace ClgProject.Models
{
    class UserLoginModel
    {
        
            [JsonProperty("userName")]
            public string UserName { get; set; }

            [JsonProperty("password")]
            public string Password { get; set; }


    }

    
}