using System.Threading.Tasks;
using TheContent.Models;

namespace TheContent.Services
{
    public interface IFaqService
    {
        Task<Faq> GetByEventId(string id);
    }
}