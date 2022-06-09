using AutoMapper;
using dashboard.Infrastructure.Models.Identity;
using dashboard.Application.Responses.Identity;

namespace dashboard.Infrastructure.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserResponse, User>().ReverseMap();
        }
    }
}