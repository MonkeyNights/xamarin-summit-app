using System;
using System.Threading.Tasks;
using TheContent.Models;

namespace TheContent.Services
{
    public interface ICodeOfConductService
    {
        Task<CodeOfConduct> GetByEventId(string id);
    }
}
