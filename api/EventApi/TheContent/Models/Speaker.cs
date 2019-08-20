using System.Collections.Generic;

namespace TheContent.Models
{
    public class Speaker : Person
    {
        public List<Talk> Talks { get; set; }

        public string EventId { get; set; }
    }
}