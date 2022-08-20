using AutoMapper;
using EasyMeets.Core.Common.DTO.Availability;
using EasyMeets.Core.Common.DTO.Team;
using EasyMeets.Core.DAL.Entities;

namespace EasyMeets.Core.BLL.MappingProfiles
{
    public class TeamProfile : Profile
    {
        public TeamProfile()
        {
            CreateMap<Team, AvailabilitySlotsGroupByTeamsDto>();
            CreateMap<AvailabilitySlotsGroupByTeamsDto, Team>();
            
            CreateMap<Team, TeamDto>();
        }
    }
}
