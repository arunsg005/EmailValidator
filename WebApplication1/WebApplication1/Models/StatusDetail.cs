using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class StatusDetail
    {
        public string Email { get; set; }

        public int Number_Of_events { get; set; }

        public List<Event> Events { get; set; }

        [JsonIgnore]
        public HttpStatusCode StatusCode { get; set; }
    }
}
