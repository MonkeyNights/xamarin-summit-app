using System;
using System.Collections.Generic;

namespace TheContent.Models
{
    public class Ticket : Content
    {
        public string Price { get; set; }
        public List<string> Benefits { get; set; }
        public DateTimeOffset AvailableUntil { get; set; }

        public string EventId { get; set; }
    }
}