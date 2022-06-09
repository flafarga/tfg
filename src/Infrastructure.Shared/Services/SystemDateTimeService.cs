using dashboard.Application.Interfaces.Services;
using System;

namespace dashboard.Infrastructure.Shared.Services
{
    public class SystemDateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}