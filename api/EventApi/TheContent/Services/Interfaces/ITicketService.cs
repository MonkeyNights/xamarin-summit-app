using System.Collections.Generic;
using System.Threading.Tasks;
using TheContent.Models;

namespace TheContent.Services
{
    public interface ITicketService
    {
        Task<List<Ticket>> GetByEventId(string id);
    }
}