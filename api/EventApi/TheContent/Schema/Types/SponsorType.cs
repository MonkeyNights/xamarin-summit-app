using GraphQL.Types;
using TheContent.Models;

namespace TheContent.Schema.Types
{
    public class SponsorType : ObjectGraphType<Sponsor>
    {
        public SponsorType()
        {
            Field(e => e.Id);
            Field(e => e.Name);
            Field(e => e.Description);
            Field(e => e.LogoUrl);
            Field(e => e.SponsorshipTier);
            Field(e => e.EventId);
        }
    }
}
