using GraphQL.Types;
using TheContent.Models;
using TheContent.Schema.Types;
using TheContent.Services;

namespace TheContent.Schema.Queries
{
    public class EventsQuery : ObjectGraphType<object>
    {
        public EventsQuery(IEventService events)
        {
            Name = "Query";
            Field<ListGraphType<EventType>>(
                "events"
                , resolve: ctx => events.GetAll());
        }
    }
}
