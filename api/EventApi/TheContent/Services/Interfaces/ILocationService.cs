using System.Threading.Tasks;
using TheContent.Models;

namespace TheContent.Services
{
    public interface ILocationService
    {
        Task<Location> GetByEventId(string id);
    }
}