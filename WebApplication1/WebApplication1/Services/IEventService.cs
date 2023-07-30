﻿using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public interface IEventService
    {
        Task<StatusDetail> GetStatusDetails(string email);
    }
}
