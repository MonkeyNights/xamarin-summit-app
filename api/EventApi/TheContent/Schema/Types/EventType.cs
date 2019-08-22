using GraphQL.Types;
using TheContent.Models;
using TheContent.Services;

namespace TheContent.Schema.Types
{
    public class EventType : ObjectGraphType<Event>
    {
        public EventType(ILocationService locations
            , ICodeOfConductService codeOfConduct
            , ISocialProfileService socialProfile
            , ITicketService tickets
            , ISponsorService sponsors
            , ISpeakerService speakers
            , IOrganizerService organizers
            , ITestimonialService testimonials
            , IFaqService faq
            , IEventDayService eventDays)
        {
            Field(e => e.Id);
            Field(e => e.Name);
            Field(e => e.Highlight);
            Field(e => e.Description);
            Field(e => e.TicketsUrl);
            Field(e => e.Call4PapersUrl);

            Field<ListGraphType<EventDayType>>("days"
                , resolve: ctx => eventDays.GetByEventId(ctx.Source.Id));

            Field<LocationType>("location"
                , resolve: ctx => locations.GetByEventId(ctx.Source.Id));

            Field<CodeOfConductType>("coc"
                , resolve: ctx => codeOfConduct.GetByEventId(ctx.Source.Id));

            Field<SocialProfileType>("social"
                , resolve: ctx => socialProfile.GetById(ctx.Source.SocialProfileId));

            Field<ListGraphType<TicketType>>("tickets"
                 , resolve: ctx => tickets.GetByEventId(ctx.Source.Id));

            Field<ListGraphType<SponsorType>>("sponsors"
                 , resolve: ctx => sponsors.GetByEventId(ctx.Source.Id));

            Field<ListGraphType<SpeakerType>>("speakers"
               , resolve: ctx => speakers.GetByEventId(ctx.Source.Id));

            Field<ListGraphType<OrganizerType>>("organizers"
                , resolve: ctx => organizers.GetByEventId(ctx.Source.Id));

            Field<ListGraphType<TestimonialType>>("testimonials"
                , resolve: ctx => testimonials.GetByEventId(ctx.Source.Id));

            Field<ListGraphType<FaqType>>("faq"
                , resolve: ctx => faq.GetByEventId(ctx.Source.Id));
        }
    }
}
