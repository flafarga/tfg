using dashboard.Application.Features.Products.Commands.AddEdit;
using dashboard.Application.Features.Products.Queries.GetAllPaged;
using dashboard.Application.Requests.Catalog;
using dashboard.Shared.Wrapper;
using System.Threading.Tasks;

namespace dashboard.Client.Infrastructure.Managers.Catalog.Product
{
    public interface IProductManager : IManager
    {
        Task<PaginatedResult<GetAllPagedProductsResponse>> GetProductsAsync(GetAllPagedProductsRequest request);

        Task<IResult<string>> GetProductImageAsync(int id);

        Task<IResult<int>> SaveAsync(AddEditProductCommand request);

        Task<IResult<int>> DeleteAsync(int id);

        Task<IResult<string>> ExportToExcelAsync(string searchString = "");
    }
}