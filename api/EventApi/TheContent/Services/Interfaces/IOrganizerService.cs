using System.Collections.Generic;
using System.Threading.Tasks;
using TheContent.Models;

namespace TheContent.Services
{
    public interface IOrganizerService
    {
        Task<List<Organizer>> GetByEventId(string id);
    }
}