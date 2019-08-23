using GraphQL;
using GraphQL.Server;
using GraphQL.Server.Ui.Playground;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using TheContent.Schema;
using TheContent.Schema.Queries;
using TheContent.Services;
using TheContent.Services.Mocks;

namespace TheContent
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IDependencyResolver>(serviceProvider => new FuncDependencyResolver(serviceProvider.GetRequiredService));

            services.AddScoped<EventsSchema>();
            services.AddScoped<EventsQuery>();

            services.AddGraphQL(options =>
            {
                options.ExposeExceptions = true;
            }).AddGraphTypes(ServiceLifetime.Scoped);

            services.AddTransient<ICodeOfConductService, XamarinSummitAllServicesMock.CodeOfConductService>();
            services.AddTransient<IContentService, XamarinSummitAllServicesMock.ContentService>();
            services.AddTransient<IEventDayService, XamarinSummitAllServicesMock.EventDayService>();
            services.AddTransient<IEventService, XamarinSummitAllServicesMock.EventService>();
            services.AddTransient<IFaqService, XamarinSummitAllServicesMock.FaqService>();
            services.AddTransient<ILocationService, XamarinSummitAllServicesMock.LocationService>();
            services.AddTransient<IOrganizerService, XamarinSummitAllServicesMock.OrganizerService>();
            services.AddTransient<IPersonService, XamarinSummitAllServicesMock.PersonService>();
            services.AddTransient<ISocialProfileService, XamarinSummitAllServicesMock.SocialProfileService>();
            services.AddTransient<ISpeakerService, XamarinSummitAllServicesMock.SpeakerService>();
            services.AddTransient<ISponsorService, XamarinSummitAllServicesMock.SponsorService>();
            services.AddTransient<ITestimonialService, XamarinSummitAllServicesMock.TestimonialService>();
            services.AddTransient<ITicketService, XamarinSummitAllServicesMock.TicketService>();
            services.AddTransient<ISponsorshipTierService, XamarinSummitAllServicesMock.SponsorshipTierService>();
            services.AddTransient<ITalkService, XamarinSummitAllServicesMock.TalkService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

            }

            app.UseGraphQLPlayground(new GraphQLPlaygroundOptions());
            app.UseGraphQL<EventsSchema>();
        }
    }
}
