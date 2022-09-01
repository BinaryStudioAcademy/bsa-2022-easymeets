using AutoMapper;
using EasyMeets.Core.BLL.Helpers;
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
            
            CreateMap<TeamDto, Team>()
                .ForMember(dest => dest.LogoPath, src => src.MapFrom(s => s.Image));

            CreateMap<Team, TeamDto>()
                .ForMember(dest => dest.Image, src => src.MapFrom(s => s.LogoPath));

            CreateMap<NewTeamDto, Team>()
                .ForMember(dest => dest.LogoPath, src => src.MapFrom(s => s.Image))
                .ForMember(dest => dest.TimeZoneValue, src => src.MapFrom(s => TimeZoneHelper.MapTimeZoneStringValue(s.TimeZoneValue)));

            CreateMap<UpdateTeamDto, Team>()
                .ForMember(dest => dest.LogoPath, src => src.MapFrom(s => s.Image))
                .ForMember(dest => dest.TimeZoneValue, src => src.MapFrom(s => TimeZoneHelper.MapTimeZoneStringValue(s.TimeZoneValue)));
        }
    }
}
