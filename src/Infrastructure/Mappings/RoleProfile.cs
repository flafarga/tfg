using AutoMapper;
using dashboard.Infrastructure.Models.Identity;
using dashboard.Application.Responses.Identity;

namespace dashboard.Infrastructure.Mappings
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<RoleResponse, Role>().ReverseMap();
        }
    }
}