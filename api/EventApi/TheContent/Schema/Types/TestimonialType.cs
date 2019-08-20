using GraphQL.Types;
using TheContent.Models;
using TheContent.Services;

namespace TheContent.Schema.Types
{
    public class TestimonialType : ObjectGraphType<Testimonial>
    {
        public TestimonialType(IContentService content
            , IPersonService person)
        {
            Field<PersonType>("person"
                , resolve: ctx => person.GetById(ctx.Source.PersonId));

            Field<ContentType>("content"
               , resolve: ctx => content.GetById(ctx.Source.ContentId));
        }
    }
}
