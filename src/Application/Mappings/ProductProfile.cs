using AutoMapper;
using dashboard.Application.Features.Products.Commands.AddEdit;
using dashboard.Domain.Entities.Catalog;

namespace dashboard.Application.Mappings
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<AddEditProductCommand, Product>().ReverseMap();
        }
    }
}