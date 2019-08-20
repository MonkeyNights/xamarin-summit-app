using GraphQL.Types;
using TheContent.Models;

namespace TheContent.Schema.Types
{
    public class TicketType : ObjectGraphType<Ticket>
    {
        public TicketType()
        {
            Field(e => e.Id);
            Field(e => e.AvailableUntil);
            Field(e => e.Benefits);
            Field(e => e.Title);
            Field(e => e.Description);
            Field(e => e.Highlight);
            Field(e => e.Price);
            Field(e => e.Url);
            Field(e => e.EventId);
        }
    }
}
