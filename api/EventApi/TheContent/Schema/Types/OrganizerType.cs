using GraphQL.Types;
using TheContent.Models;
using TheContent.Services;

namespace TheContent.Schema.Types
{
    public class OrganizerType : ObjectGraphType<Organizer>
    {
        public OrganizerType(ISocialProfileService socialProfile)
        {
            Field(e => e.Id);
            Field(e => e.FullBio);
            Field(e => e.Highlight);
            Field(e => e.MiniBio);
            Field(e => e.Name);
            Field(e => e.PictureUrl);

            Field<SocialProfileType>("socialProfile",
                resolve: ctx => socialProfile.GetById(ctx.Source.SocialProfileId));

            Field(e => e.EventId);
        }
    }
}
