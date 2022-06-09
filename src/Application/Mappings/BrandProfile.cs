using AutoMapper;
using dashboard.Application.Features.Brands.Commands.AddEdit;
using dashboard.Application.Features.Brands.Queries.GetAll;
using dashboard.Application.Features.Brands.Queries.GetById;
using dashboard.Domain.Entities.Catalog;

namespace dashboard.Application.Mappings
{
    public class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<AddEditBrandCommand, Brand>().ReverseMap();
            CreateMap<GetBrandByIdResponse, Brand>().ReverseMap();
            CreateMap<GetAllBrandsResponse, Brand>().ReverseMap();
        }
    }
}