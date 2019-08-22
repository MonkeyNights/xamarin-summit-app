namespace TheContent.Models
{
    public class Content : BaseModel
    {
        public string Title { get; set; }
        public string Highlight { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
    }
}