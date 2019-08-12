using GraphQL;
using GraphQL.Server;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using TheContent.Schema;

namespace TheContent
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            ConfigureGraphQL(builder);
        }

        private void ConfigureGraphQL(IFunctionsHostBuilder builder)
        {
            builder.Services.AddScoped<IDependencyResolver>(serviceProvider
                => new FuncDependencyResolver(serviceProvider.GetRequiredService));

            builder.Services.AddScoped<EventSchema>();
            builder.Services.AddSingleton<IDocumentExecuter>(new DocumentExecuter());
            builder.Services.AddGraphQL(options => { options.ExposeExceptions = true; })
            .AddGraphTypes(ServiceLifetime.Scoped)
            .AddDataLoader();
        }
    }
}
