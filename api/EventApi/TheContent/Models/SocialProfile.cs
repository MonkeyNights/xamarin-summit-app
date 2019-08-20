namespace TheContent.Models
{
    public class SocialProfile : BaseModel
    {
        public string GitHubUrl { get; set; }
        public string TwitterUrl { get; set; }
        public string FacebookUrl { get; set; }
        public string LinkedinUrl { get; set; }
        public string YoutubeUrl { get; set; }
    }
}