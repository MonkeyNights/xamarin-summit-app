using GraphQL.Types;
using TheContent.Models;

namespace TheContent.Schema.Types
{

    public class SponsorshipTierType : ObjectGraphType<SponsorshipTier>
    {
        public SponsorshipTierType()
        {
            Field(e => e.Id);
            Field(e => e.Name);
            Field(e => e.OrderOfImportance);
        }
    }
}