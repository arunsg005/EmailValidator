using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Event
    {
      //  "id": "57d742c2-39aa-4fd0-b166-243d019b8228",
      //"start": "2023-08-07T16:00:00",
      //"end": "2023-08-07 16:30:00 +0000",
      //"status": "Busy",
      //"subject": "Meeting A"
        public string Id { get; set; }
        public DateTime Start_time { get; set; }
        public DateTime End_time { get; set; }
        public string Status { get; set; }
        public string Subject { get; set; }
    }
}
