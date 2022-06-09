using AutoMapper;
using dashboard.Application.Features.Documents.Commands.AddEdit;
using dashboard.Application.Features.Documents.Queries.GetById;
using dashboard.Domain.Entities.Misc;

namespace dashboard.Application.Mappings
{
    public class DocumentProfile : Profile
    {
        public DocumentProfile()
        {
            CreateMap<AddEditDocumentCommand, Document>().ReverseMap();
            CreateMap<GetDocumentByIdResponse, Document>().ReverseMap();
        }
    }
}