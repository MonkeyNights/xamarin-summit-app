using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TheContent.Models;

namespace TheContent.Services.Mocks
{
    public class XamarinSummitAllServicesMock
    {
        public static Event Event =
            new Event
            {
                Id = "",
                Name = "",
                Highlight = "",
                Description = "",
                TicketsUrl = "",
                Call4PapersUrl = "",

                LocationId = Location.Id,
                CodeOfConductId = CodeOfConduct.Id,
                SocialProfileId = SocialProfile.Id,
            };

        public static SocialProfile SocialProfile =
            new SocialProfile
            {
                Id = "",
            };

        public static CodeOfConduct CodeOfConduct =
            new CodeOfConduct
            {
                Id = "",
            };

        public static Location Location =
            new Location
            {
                Id = "",
            };

        public class CodeOfConductService
        {
            public Task<CodeOfConduct> GetByEventId(string id)
            {
                throw new NotImplementedException();
            }
        }

        public class EventService : IEventService
        {
            public Task<List<Event>> GetAll()
            {
                throw new NotImplementedException();
            }
        }

        public class FaqService : IFaqService
        {
            public Task<Faq> GetByEventId(string id)
            {
                throw new NotImplementedException();
            }
        }

        public class LocationService : ILocationService
        {
            public Task<Location> GetByEventId(string id)
            {
                throw new NotImplementedException();
            }
        }

        public class PersonService : IOrganizerService
        {
            public Task<List<Organizer>> GetByEventId(string id)
            {
                throw new NotImplementedException();
            }
        }

        public class SocialProfileService : ISocialProfileService
        {
            public Task<SocialProfile> GetById(string socialProfileId)
            {
                throw new NotImplementedException();
            }
        }

        public class SpeakerService : ISpeakerService
        {
            public Task<List<Speaker>> GetByEventId(string id)
            {
                throw new NotImplementedException();
            }
        }

        public class SponsorService : ISponsorService
        {
            public Task<List<Sponsor>> GetByEventId(string id)
            {
                throw new NotImplementedException();
            }
        }

        public class TestimonialService : ITestimonialService
        {
            public Task<List<Testimonial>> GetByEventId(string id)
            {
                throw new NotImplementedException();
            }
        }

        public class TicketService : ITicketService
        {
            public Task<List<Ticket>> GetByEventId(string id)
            {
                throw new NotImplementedException();
            }
        }

        public class ContentService
        {
            public Task<Content> GetById(string contentId)
            {
                throw new NotImplementedException();
            }
        }

        public class EventDayService : IEventDayService
        {
            public Task<List<EventDay>> GetByEventId(string eventId)
            {
                throw new NotImplementedException();
            }
        }

        public class OrganizerService : IOrganizerService
        {
            public Task<List<Organizer>> GetByEventId(string id)
            {
                throw new NotImplementedException();
            }
        }
    }
}
