
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Text.Json.Serialization;

namespace WebApplication1.Models
{
    public class Event
    {
        public string Id { get; set; }

        public string Start { get; set; }

        public string End { get; set; }

        public string Status { get; set; }

        public string Subject { get; set; }

    }
}
