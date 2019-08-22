using System.Collections.Generic;
using System.Threading.Tasks;
using TheContent.Models;

namespace TheContent.Services
{
    public interface ITalkService
    {
        Task<List<Talk>> GetByPersonId(string id);
    }
}