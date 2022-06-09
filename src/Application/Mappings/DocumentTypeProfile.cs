using AutoMapper;
using dashboard.Application.Features.DocumentTypes.Commands.AddEdit;
using dashboard.Application.Features.DocumentTypes.Queries.GetAll;
using dashboard.Application.Features.DocumentTypes.Queries.GetById;
using dashboard.Domain.Entities.Misc;

namespace dashboard.Application.Mappings
{
    public class DocumentTypeProfile : Profile
    {
        public DocumentTypeProfile()
        {
            CreateMap<AddEditDocumentTypeCommand, DocumentType>().ReverseMap();
            CreateMap<GetDocumentTypeByIdResponse, DocumentType>().ReverseMap();
            CreateMap<GetAllDocumentTypesResponse, DocumentType>().ReverseMap();
        }
    }
}