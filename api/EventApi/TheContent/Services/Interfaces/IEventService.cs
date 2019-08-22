using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TheContent.Models;

namespace TheContent.Services
{
    public interface IEventService
    {
        Task<List<Event>> GetAll();
        Task<Event> GetById(string id);
    }
}
