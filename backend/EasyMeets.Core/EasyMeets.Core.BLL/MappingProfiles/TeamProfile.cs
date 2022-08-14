using AutoMapper;
using EasyMeets.Core.Common.DTO.Team;
using EasyMeets.Core.DAL.Entities;

namespace EasyMeets.Core.BLL.MappingProfiles;

public class TeamProfile : Profile
{
    public TeamProfile()
    {
        CreateMap<TeamDto, Team>();
        CreateMap<Team, TeamDto>();
    }
}