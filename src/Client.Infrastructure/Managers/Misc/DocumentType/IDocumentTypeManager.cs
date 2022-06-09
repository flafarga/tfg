﻿using System.Collections.Generic;
using System.Threading.Tasks;
using dashboard.Application.Features.DocumentTypes.Commands.AddEdit;
using dashboard.Application.Features.DocumentTypes.Queries.GetAll;
using dashboard.Shared.Wrapper;

namespace dashboard.Client.Infrastructure.Managers.Misc.DocumentType
{
    public interface IDocumentTypeManager : IManager
    {
        Task<IResult<List<GetAllDocumentTypesResponse>>> GetAllAsync();

        Task<IResult<int>> SaveAsync(AddEditDocumentTypeCommand request);

        Task<IResult<int>> DeleteAsync(int id);

        Task<IResult<string>> ExportToExcelAsync(string searchString = "");
    }
}