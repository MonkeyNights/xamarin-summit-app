using GraphQL.Types;
using TheContent.Models;

namespace TheContent.Schema.Types
{
    public class SocialProfileType : ObjectGraphType<SocialProfile>
    {
        public SocialProfileType()
        {
            Field(e => e.Id);
            Field(e => e.FacebookUrl);
            Field(e => e.GitHubUrl);
            Field(e => e.LinkedinUrl);
            Field(e => e.TwitterUrl);
            Field(e => e.YoutubeUrl);
        }
    }
}
