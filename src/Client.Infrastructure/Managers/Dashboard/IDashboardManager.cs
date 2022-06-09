using dashboard.Shared.Wrapper;
using System.Threading.Tasks;
using dashboard.Application.Features.Dashboards.Queries.GetData;

namespace dashboard.Client.Infrastructure.Managers.Dashboard
{
    public interface IDashboardManager : IManager
    {
        Task<IResult<DashboardDataResponse>> GetDataAsync();
    }
}