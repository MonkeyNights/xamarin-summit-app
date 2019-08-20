using System;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace TheContent.Helpers
{
    /// <summary>
    /// Sample from https://github.com/tpeczek/Demo.Azure.Functions.GraphQL/blob/master/Demo.Azure.Functions.GraphQL/Infrastructure/GraphQLExecutionResult.cs
    /// </summary>
    internal class GraphQLExecutionResult : ActionResult
    {
        private const string CONTENT_TYPE = "application/json";

        private readonly ExecutionResult executionResult;

        public GraphQLExecutionResult(ExecutionResult executionResult)
        {
            executionResult = executionResult ?? throw new ArgumentNullException(nameof(executionResult));
        }

        public override Task ExecuteResultAsync(ActionContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            var documentWriter = context.HttpContext.RequestServices.GetRequiredService<IDocumentWriter>();

            var response = context.HttpContext.Response;
            response.ContentType = CONTENT_TYPE;
            response.StatusCode = StatusCodes.Status200OK;

            return documentWriter.WriteAsync(response.Body, executionResult);
        }
    }
}
