using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCromos.Apps.Models
{
    class JsonResponse
    {
        public string respuesta { get; set; }
        [JsonProperty("data")]
        public Data data { get; set; }
        public class Data
        {
            public string codigo { get; set; }
        }
    }
}
