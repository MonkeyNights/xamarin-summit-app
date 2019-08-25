using System;
using System.Threading.Tasks;
using EventApp.XamarinSummit.Models;
using EventApp.XamarinSummit.Repositories;

namespace EventApp.XamarinSummit.Services
{
    public interface IEventService
    {
        Task<Event> Details();
    }

    public class EventService : IEventService
    {
        private readonly IEventRepository eventRepository;

        public EventService(IEventRepository eventRepository)
        {
            this.eventRepository = eventRepository;
        }

        public async Task<Event> Details()
        {
            try
            {
                var eventDetails = await eventRepository.GetDetails(new Queries.EventQueryRequest());

                return eventDetails.GetDataFieldAs<Event>("event");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
