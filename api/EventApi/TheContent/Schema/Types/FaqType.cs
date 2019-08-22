using GraphQL.Types;
using TheContent.Models;

namespace TheContent.Schema.Types
{
    public class FaqType : ObjectGraphType<Faq>
    {
        public FaqType()
        {
            Field(e => e.Id);
            Field(e => e.Title);
            Field(e => e.Highlight);
            Field(e => e.Description);
            Field(e => e.Url);
            Field(e => e.EventId);
        }
    }
}
