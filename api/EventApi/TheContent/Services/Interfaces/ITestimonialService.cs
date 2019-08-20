using System.Collections.Generic;
using System.Threading.Tasks;
using TheContent.Models;

namespace TheContent.Services
{
    public interface ITestimonialService
    {
        Task<List<Testimonial>> GetByEventId(string id);
    }
}