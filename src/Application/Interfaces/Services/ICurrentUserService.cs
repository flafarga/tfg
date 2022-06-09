using dashboard.Application.Interfaces.Common;

namespace dashboard.Application.Interfaces.Services
{
    public interface ICurrentUserService : IService
    {
        string UserId { get; }
    }
}