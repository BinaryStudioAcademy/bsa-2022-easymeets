using AutoMapper;
using EasyMeets.Core.Common.DTO;
using EasyMeets.Core.DAL.Entities;

namespace EasyMeets.Core.BLL.MappingProfiles
{
    public class TeamProfile : Profile
    {
        public TeamProfile()
        {
            CreateMap<Team, TeamDto>();
            CreateMap<TeamDto, Team>();
        }
    }
}
