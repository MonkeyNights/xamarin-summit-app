using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TheContent.Models;

namespace TheContent.Services
{
    public interface ISponsorshipTierService
    {
        Task<SponsorshipTier> GetById(string id);
    }
}
