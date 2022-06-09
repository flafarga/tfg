using AutoMapper;
using dashboard.Application.Requests.Identity;
using dashboard.Application.Responses.Identity;
using dashboard.Infrastructure.Models.Identity;

namespace dashboard.Infrastructure.Mappings
{
    public class RoleClaimProfile : Profile
    {
        public RoleClaimProfile()
        {
            CreateMap<RoleClaimResponse, RoleClaim>()
                .ForMember(nameof(RoleClaim.ClaimType), opt => opt.MapFrom(c => c.Type))
                .ForMember(nameof(RoleClaim.ClaimValue), opt => opt.MapFrom(c => c.Value))
                .ReverseMap();

            CreateMap<RoleClaimRequest, RoleClaim>()
                .ForMember(nameof(RoleClaim.ClaimType), opt => opt.MapFrom(c => c.Type))
                .ForMember(nameof(RoleClaim.ClaimValue), opt => opt.MapFrom(c => c.Value))
                .ReverseMap();
        }
    }
}