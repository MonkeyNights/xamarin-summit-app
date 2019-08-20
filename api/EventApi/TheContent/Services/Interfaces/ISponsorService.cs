using System.Collections.Generic;
using System.Threading.Tasks;
using TheContent.Models;

namespace TheContent.Services
{
    public interface ISponsorService
    {
        Task<List<Sponsor>> GetByEventId(string id);
    }
}