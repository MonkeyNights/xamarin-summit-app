using System.Collections.Generic;
using System.Threading.Tasks;
using TheContent.Models;

namespace TheContent.Services
{
    public interface ISpeakerService
    {
        Task<List<Speaker>> GetByEventId(string id);
    }
}