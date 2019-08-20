using System;
using GraphQL;
using GraphQL.Http;
using GraphQL.Server;
using GraphQL.Server.Internal;
using GraphQL.Types;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using TheContent.Schema;
using TheContent.Schema.Queries;
using TheContent.Schema.Types;
using TheContent.Services;
using TheContent.Services.Mocks;

[assembly: FunctionsStartup(typeof(TheContent.Startup))]
namespace TheContent
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            ConfigureGraphQL(builder);
            ConfigureDependencies(builder);
        }

        private void ConfigureDependencies(IFunctionsHostBuilder builder)
        {
            builder.Services.AddScoped<IDependencyResolver>(serviceProvider => new FuncDependencyResolver(serviceProvider.GetRequiredService));
            builder.Services.AddSingleton<IDocumentExecuter>(new DocumentExecuter());

            builder.Services.AddScoped<EventsSchema>();

            builder.Services.AddScoped<ICodeOfConductService, XamarinSummitAllServicesMock.CodeOfConductService>();
            builder.Services.AddScoped<IContentService, XamarinSummitAllServicesMock.ContentService>();
            builder.Services.AddScoped<IEventDayService, XamarinSummitAllServicesMock.EventDayService>();
            builder.Services.AddScoped<IEventService, XamarinSummitAllServicesMock.EventService>();
            builder.Services.AddScoped<IFaqService, XamarinSummitAllServicesMock.FaqService>();
            builder.Services.AddScoped<ILocationService, XamarinSummitAllServicesMock.LocationService>();
            builder.Services.AddScoped<IOrganizerService, XamarinSummitAllServicesMock.OrganizerService>();
            builder.Services.AddScoped<IPersonService, XamarinSummitAllServicesMock.PersonService>();
            builder.Services.AddScoped<ISocialProfileService, XamarinSummitAllServicesMock.SocialProfileService>();
            builder.Services.AddScoped<ISpeakerService, XamarinSummitAllServicesMock.SpeakerService>();
            builder.Services.AddScoped<ISponsorService, XamarinSummitAllServicesMock.SponsorService>();
            builder.Services.AddScoped<ITestimonialService, XamarinSummitAllServicesMock.TestimonialService>();
            builder.Services.AddScoped<ITicketService, XamarinSummitAllServicesMock.TicketService>();

        }

        private void ConfigureGraphQL(IFunctionsHostBuilder builder)
        {
            builder.Services.AddGraphQL(options => { options.ExposeExceptions = true; })
            .AddGraphTypes(ServiceLifetime.Scoped)
            .AddDataLoader();
        }
    }
}
