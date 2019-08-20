using System.Threading.Tasks;
using TheContent.Models;

namespace TheContent.Services
{
    public interface ISponsorshipTier
    {
        Task<SponsorshipTier> GetBySponsorId(string id);
    }
}