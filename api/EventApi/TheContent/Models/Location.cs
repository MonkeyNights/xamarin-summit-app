namespace TheContent.Models
{
    public class Location : BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }

        public string EventId { get; set; }
    }
}