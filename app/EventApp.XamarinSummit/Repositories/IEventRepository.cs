using System.Threading.Tasks;
using Refit;
using GraphQL.Common.Response;
using EventApp.XamarinSummit.Queries;

namespace EventApp.XamarinSummit.Repositories
{
    [Headers("User-Agent: " + nameof(XamarinSummit))]
    public interface IEventRepository
    {
        [Post("/graphql")]
        Task<GraphQLResponse> GetDetails([Body]EventQueryRequest request);
    }
}