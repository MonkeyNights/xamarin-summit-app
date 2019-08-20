using System;
using System.Collections.Generic;

namespace TheContent.Models
{
    public class Event : BaseModel
    {
        public string Name { get; set; }
        public string Highlight { get; set; }
        public string Description { get; set; }
        public string TicketsUrl { get; set; }
        public string Call4PapersUrl { get; set; }

        public string LocationId { get; set; }
        public string CodeOfConductId { get; set; }
        public string SocialProfileId { get; set; }
    }
}