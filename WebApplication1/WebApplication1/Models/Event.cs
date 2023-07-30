
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Text.Json.Serialization;

namespace WebApplication1.Models
{
    public class Event
    {
        [JsonProperty("Id")]
        public string Id { get; set; }

        [JsonProperty("Start")]
        public string Start { get; set; }

        [JsonProperty("End")]
        public string End { get; set; }

        [JsonProperty("Status")]
        public string Status { get; set; }

        [JsonProperty("Subject")]
        public string Subject { get; set; }

    }
}
