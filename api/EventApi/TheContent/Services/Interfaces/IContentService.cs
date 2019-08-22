using System;
using System.Threading.Tasks;
using TheContent.Models;

namespace TheContent.Services
{
    public interface IContentService
    {
        Task<Content> GetById(string contentId);
    }
}
