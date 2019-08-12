using GraphQL;
using TheContent.Schema.Queries;

namespace TheContent.Schema
{
    public class EventSchema : GraphQL.Types.Schema
    {
        public EventSchema(IDependencyResolver dependencyResolver)
            : base(dependencyResolver)
        {
            Query = dependencyResolver.Resolve<EventQuery>();
        }
    }
}
