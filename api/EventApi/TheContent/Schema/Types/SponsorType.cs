using GraphQL.Types;
using TheContent.Models;
using TheContent.Services;

namespace TheContent.Schema.Types
{
    public class SponsorType : ObjectGraphType<Sponsor>
    {
        public SponsorType(ISponsorshipTierService sponsorshipTier)
        {
            Field(e => e.Id);
            Field(e => e.Name);
            Field(e => e.Description);
            Field(e => e.LogoUrl);

            Field<SponsorshipTierType>("sponsorshipTier"
                , resolve: ctx => sponsorshipTier.GetById(ctx.Source.SponsorshipTierId));

            Field(e => e.EventId);
        }
    }
}
