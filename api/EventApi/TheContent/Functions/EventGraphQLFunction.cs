using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using GraphQL;
using GraphQL.Server.Internal;
using TheContent.Schema;
using TheContent.Helpers;
using System;
using TheContent.Extensions;

namespace TheContent
{
    public class EventGraphQLFunction
    {
        private readonly IGraphQLExecuter<EventsSchema> graphQLExecuter;

        public EventGraphQLFunction(IGraphQLExecuter<EventsSchema> graphQLExecuter)
        {
            this.graphQLExecuter = graphQLExecuter;
        }

        [FunctionName("graphql")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            try
            {
                var executionResult = await graphQLExecuter.ExecuteAsync(req);

                if (executionResult.Errors != null)
                {
                    log.LogError("GraphQL execution error(s): {Errors}", executionResult.Errors);
                }

                return new GraphQLExecutionResult(executionResult);
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(new { message = ex.Message });
            }
        }
    }
}
