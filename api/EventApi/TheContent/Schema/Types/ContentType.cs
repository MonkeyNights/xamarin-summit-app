using GraphQL.Types;
using TheContent.Models;

namespace TheContent.Schema.Types
{
    public class ContentType : ObjectGraphType<Content>
    {
        public ContentType()
        {
            Field(e => e.Id);
            Field(e => e.Title);
            Field(e => e.Description);
            Field(e => e.Url);
            Field(e => e.Highlight);
        }
    }
}
