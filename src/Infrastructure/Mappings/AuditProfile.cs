using AutoMapper;
using dashboard.Infrastructure.Models.Audit;
using dashboard.Application.Responses.Audit;

namespace dashboard.Infrastructure.Mappings
{
    public class AuditProfile : Profile
    {
        public AuditProfile()
        {
            CreateMap<AuditResponse, Audit>().ReverseMap();
        }
    }
}