using System.Collections.Generic;
using System.Threading.Tasks;
using dashboard.Application.Interfaces.Common;
using dashboard.Application.Requests.Identity;
using dashboard.Application.Responses.Identity;
using dashboard.Shared.Wrapper;

namespace dashboard.Application.Interfaces.Services.Identity
{
    public interface IRoleClaimService : IService
    {
        Task<Result<List<RoleClaimResponse>>> GetAllAsync();

        Task<int> GetCountAsync();

        Task<Result<RoleClaimResponse>> GetByIdAsync(int id);

        Task<Result<List<RoleClaimResponse>>> GetAllByRoleIdAsync(string roleId);

        Task<Result<string>> SaveAsync(RoleClaimRequest request);

        Task<Result<string>> DeleteAsync(int id);
    }
}