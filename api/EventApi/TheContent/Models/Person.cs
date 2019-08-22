namespace TheContent.Models
{
    public class Person : BaseModel
    {
        public string Name { get; set; }
        public string MiniBio { get; set; }
        public string FullBio { get; set; }
        public string PictureUrl { get; set; }
        public string Highlight { get; set; }

        public string SocialProfileId { get; set; }
    }
}