using GraphQL.Types;
using TheContent.Models;

namespace TheContent.Schema.Types
{
    public class EventDayType : ObjectGraphType<EventDay>
    {
        public EventDayType()
        {
            Field(e => e.Id);
            Field(e => e.Day);
            Field(e => e.Month);
            Field(e => e.Year);
            Field(e => e.StartHour);
            Field(e => e.StartMinutes);
            Field(e => e.EndHour);
            Field(e => e.EndMinutes);
            Field(e => e.EventId);
        }
    }
}