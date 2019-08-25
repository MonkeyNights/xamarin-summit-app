using GraphQL.Common.Request;

namespace EventApp.XamarinSummit.Queries
{
    public class EventQueryRequest : GraphQLRequest
    {
        private readonly string query = "query { event(id: \"C46C36EA-883B-48C7-9DD7-96502FCE7942\") { name, highlight, description } }";

        public EventQueryRequest()
        {
            Query = query;
        }
    }
}