namespace TheContent.Models
{
    public class Testimonial : BaseModel
    {
        public string PersonId { get; set; }
        public string ContentId { get; set; }
        public string EventId { get; set; }
    }
}