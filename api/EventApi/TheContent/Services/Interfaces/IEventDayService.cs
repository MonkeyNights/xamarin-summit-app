using System.Collections.Generic;
using System.Threading.Tasks;
using TheContent.Models;

namespace TheContent.Services
{
    public interface IEventDayService
    {
        Task<List<EventDay>> GetByEventId(string eventId);
    }
}