using GraphQL.Types;
using TheContent.Models;
using TheContent.Services;

namespace TheContent.Schema.Types
{
    public class SpeakerType : ObjectGraphType<Speaker>
    {
        public SpeakerType(ISocialProfileService socialProfile 
            , ITalkService talks)
        {
            Field(e => e.Id);
            Field(e => e.FullBio);
            Field(e => e.Highlight);
            Field(e => e.MiniBio);
            Field(e => e.Name);
            Field(e => e.PictureUrl);

            Field<SocialProfileType>("socialProfile",
                resolve: ctx => socialProfile.GetById(ctx.Source.SocialProfileId));

            Field<ListGraphType<TalkType>>("talks",
               resolve: ctx => talks.GetByPersonId(ctx.Source.Id));

            Field(e => e.EventId);
        }
    }
}
