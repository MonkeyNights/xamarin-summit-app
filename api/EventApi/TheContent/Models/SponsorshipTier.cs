namespace TheContent.Models
{
    public class SponsorshipTier
    {
        public string Name { get; set; }
        public int OrderOfImportance { get; set; }

        public string SponsorId { get; set; }
        public string EventId { get; set; }
    }
}