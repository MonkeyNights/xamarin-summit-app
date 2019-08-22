using System.Threading.Tasks;
using TheContent.Models;

namespace TheContent.Services
{
    public interface ISocialProfileService
    {
        Task<SocialProfile> GetById(string socialProfileId);
    }
}