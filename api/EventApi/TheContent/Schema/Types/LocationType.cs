using GraphQL.Types;
using TheContent.Models;

namespace TheContent.Schema.Types
{
    public class LocationType : ObjectGraphType<Location>
    {
        public LocationType()
        {
            Field(e => e.Id);
            Field(e => e.Name);
            Field(e => e.Description);
            Field(e => e.Address);
            Field(e => e.ZipCode);
            Field(e => e.City);
            Field(e => e.State);
        }
    }
}
