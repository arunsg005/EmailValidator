using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;

namespace WebApplication1.Models
{
    public class StatusDetail
    {

        [JsonProperty("Email")]
        public string email { get; set; }

        [JsonProperty("Number_Of_events")]
        public int Number_Of_events { get; set; }

        [JsonProperty("Events")]
        public List<Event> events { get; set; }

        [JsonIgnore]
        public HttpStatusCode StatusCode { get; set; }
    }
}
