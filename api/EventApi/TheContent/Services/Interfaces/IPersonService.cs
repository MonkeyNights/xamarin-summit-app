using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TheContent.Models;

namespace TheContent.Services
{
    public interface IPersonService
    {
        Task<List<Person>> GetByEventId(string id);
        Task<Person> GetById(string personId);
    }
}
