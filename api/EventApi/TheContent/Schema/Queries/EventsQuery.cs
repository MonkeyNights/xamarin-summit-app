using GraphQL.Types;
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

            Field<EventType>(
                "event"
                , arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "id" })
                , resolve: ctx => {
                    var id = ctx.GetArgument<string>("id");
                    return events.GetById(id);
                });
        }
    }
}
