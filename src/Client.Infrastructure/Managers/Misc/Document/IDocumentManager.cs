using dashboard.Application.Features.Documents.Commands.AddEdit;
using dashboard.Application.Features.Documents.Queries.GetAll;
using dashboard.Application.Requests.Documents;
using dashboard.Shared.Wrapper;
using System.Threading.Tasks;
using dashboard.Application.Features.Documents.Queries.GetById;

namespace dashboard.Client.Infrastructure.Managers.Misc.Document
{
    public interface IDocumentManager : IManager
    {
        Task<PaginatedResult<GetAllDocumentsResponse>> GetAllAsync(GetAllPagedDocumentsRequest request);

        Task<IResult<GetDocumentByIdResponse>> GetByIdAsync(GetDocumentByIdQuery request);

        Task<IResult<int>> SaveAsync(AddEditDocumentCommand request);

        Task<IResult<int>> DeleteAsync(int id);
    }
}