using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheContent.Models;

namespace TheContent.Services.Mocks
{
    public class XamarinSummitAllServicesMock
    {
        public class EventService : IEventService
        {
            public Task<List<Event>> GetAll()
             => Task.FromResult(new List<Event> {
                 new Event
                    {
                        Id = "C46C36EA-883B-48C7-9DD7-96502FCE7942",
                        Name = "Xamarin Summit 2019",
                        Highlight = "O maior encontro de desenvolvedores #Xamarin da América Latina",
                        Description = "O Xamarin Summit é um grande encontro da comunidade brasileira de desenvolvedores Xamarin, permitindo um ambiente totalmente favorável a troca de experiências e networking.",
                        TicketsUrl = "http://bit.ly/xamarin-summit-2019-inscricao",
                        Call4PapersUrl = "http://bit.ly/xamarin-summit-2019-c4p",

                        LocationId = "989C36EA-883B-48C7-9DD7-96502FCE7942",
                        CodeOfConductId = "013C36EA-883B-48C7-9DD7-96502FCE7942",
                        SocialProfileId =  "230436EA-883B-48C7-9DD7-96502FCE7942"
                    }
             });

            public async Task<Event> GetById(string id)
            {
                var events = await GetAll();
                return events.FirstOrDefault(e => e.Id == id);
            }
        }

        public class CodeOfConductService : ICodeOfConductService
        {
            public Task<CodeOfConduct> GetByEventId(string id)
             => Task.FromResult(new CodeOfConduct
             {
                 Id = "013C36EA-883B-48C7-9DD7-96502FCE7942",
                 Title = "Código de conduta",
                 Description = "Ao participar da Xamarin Summit Brasil em qualquer qualificação, incluindo a de encarregado, palestrante, patrocinador, voluntário ou convidado, você concorda em respeitar este código de conduta e cooperar com os organizadores do evento para fazer cumpri-lo.",
                 Highlight = "Este código de conduta é um cópia autorizada do código de conduta da Bocoup e baseado no Código de Conduta da JSConf™ e no Código de Conduta do Cidadão.",
             });
        }

        public class LocationService : ILocationService
        {
            public Task<Location> GetByEventId(string id)
             => Task.FromResult(new Location
             {
                 Id = "989C36EA-883B-48C7-9DD7-96502FCE7942",
                 Address = "Rodovia José Carlos Daux (SC-401), 9301 - Km 10, Santo Antônio de Lisboa",
                 City = "Florianópolis",
                 State = "Santa Catarina",
                 ZipCode = "88050-001",
                 Name = "Auditório principal da Faculdade CESUSC",
                 Description = "O evento vai acontecer no auditório principal da Faculdade CESUSC, localizado na Rodovia José Carlos Daux(SC - 401), 9301 - Km 10, Santo Antônio de Lisboa - Florianópolis - Santa Catarina"
             });

        }

        public class FaqService : IFaqService
        {
            public Task<Faq> GetByEventId(string id)
            {
                throw new NotImplementedException();
            }
        }

        public class PersonService : IPersonService
        {
            public Task<List<Person>> GetByEventId(string id)
            {
                throw new NotImplementedException();
            }

            public Task<Person> GetById(string personId)
            {
                throw new NotImplementedException();
            }
        }

        public class SocialProfileService : ISocialProfileService
        {
            public Task<SocialProfile> GetById(string socialProfileId)
            => Task.FromResult(new SocialProfile
            {
                Id = "230436EA-883B-48C7-9DD7-96502FCE7942",
                FacebookUrl = "https://www.facebook.com/XamarinSummit/",
                TwitterUrl = "https://twitter.com/XamarinSummit/",
                InstagramUrl = "https://www.instagram.com/XamarinSummitBR/",
            });
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

        public class SponsorshipTierService : ISponsorshipTierService
        {
            public Task<SponsorshipTier> GetById(string id)
            {
                throw new NotImplementedException();
            }
        }

        public class ContentService : IContentService
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

        public class TicketService : ITicketService
        {
            public Task<List<Ticket>> GetByEventId(string id)
            {
                throw new NotImplementedException();
            }
        }

        public class TalkService : ITalkService
        {
            public Task<List<Talk>> GetByPersonId(string id)
            {
                throw new NotImplementedException();
            }
        }
    }
}
