using GraphQL.Types;
using TheContent.Models;

namespace TheContent.Schema.Types
{
    public class TalkType : ObjectGraphType<Talk>
    {
        public TalkType()
        {
            Field(e => e.Id);
            Field(e => e.Title);
            Field(e => e.Highlight);
            Field(e => e.Description);
            Field(e => e.Url);
            Field(e => e.PersonId);
            Field(e => e.EventId);
        }
    }
}