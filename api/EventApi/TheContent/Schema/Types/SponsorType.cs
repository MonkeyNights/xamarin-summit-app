using GraphQL.Types;
using TheContent.Models;
using TheContent.Services;

namespace TheContent.Schema.Types
{
    public class SponsorType : ObjectGraphType<Sponsor>
    {
        public SponsorType(ISponsorshipTier sponsorshipTier)
        {
            Field(e => e.Id);
            Field(e => e.Name);
            Field(e => e.Description);
            Field(e => e.LogoUrl);
            Field<SponsorshipTierType>("sponsorshipTier"
                , resolve: ctx => sponsorshipTier.GetBySponsorId(ctx.Source.Id));
            Field(e => e.EventId);
        }
    }
}
