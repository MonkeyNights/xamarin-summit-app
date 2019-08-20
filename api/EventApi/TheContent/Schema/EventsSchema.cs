using GraphQL;
using TheContent.Schema.Queries;

namespace TheContent.Schema
{
    public class EventsSchema : GraphQL.Types.Schema
    {
        public EventsSchema(IDependencyResolver dependencyResolver,
             EventsQuery query)
            : base(dependencyResolver)
        {
            Query = query;
            DependencyResolver = dependencyResolver;
        }
    }
}
