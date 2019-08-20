﻿namespace TheContent.Models
{
    public class Sponsor : BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string LogoUrl { get; set; }
        public SponsorshipTier SponsorshipTier { get; set; }

        public string EventId { get; set; }
    }
}