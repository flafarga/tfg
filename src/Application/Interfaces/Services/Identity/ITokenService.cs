using dashboard.Application.Interfaces.Common;
using dashboard.Application.Requests.Identity;
using dashboard.Application.Responses.Identity;
using dashboard.Shared.Wrapper;
using System.Threading.Tasks;

namespace dashboard.Application.Interfaces.Services.Identity
{
    public interface ITokenService : IService
    {
        Task<Result<TokenResponse>> LoginAsync(TokenRequest model);

        Task<Result<TokenResponse>> GetRefreshTokenAsync(RefreshTokenRequest model);
    }
}