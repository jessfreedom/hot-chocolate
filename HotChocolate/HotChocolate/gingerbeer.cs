using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotChocolate
{
        public class gingerbeer
        {
            [JsonProperty(PropertyName = "id")]
            public string id { get; set; }

            [JsonProperty(PropertyName = "Quote")]
            public string Quote { get; set; }

            [JsonProperty(PropertyName = "Mood")]
            public string Mood { get; set; }

        }
    }

