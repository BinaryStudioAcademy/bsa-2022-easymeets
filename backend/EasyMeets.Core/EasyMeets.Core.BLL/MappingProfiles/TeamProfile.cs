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
            
            CreateMap<TeamDto, Team>()
                .ForMember(dest => dest.LogoPath, src => src.MapFrom(s => s.Image))
                .ForMember(dest => dest.TimeZoneName, src => src.MapFrom(s => s.TimeZone.NameValue))
                .ForMember(dest => dest.TimeZoneValue, src => src.MapFrom(s => s.TimeZone.TimeValue));

            CreateMap<Team, TeamDto>()
                .ForMember(dest => dest.Image, src => src.MapFrom(s => s.LogoPath))
                .ForPath(dest => dest.TimeZone.NameValue, src => src.MapFrom(s => s.TimeZoneName))
                .ForPath(dest => dest.TimeZone.TimeValue, src => src.MapFrom(s => s.TimeZoneValue));

            CreateMap<NewTeamDto, Team>()
                .ForMember(dest => dest.LogoPath, src => src.MapFrom(s => s.Image))
                .ForMember(dest => dest.TimeZoneName, src => src.MapFrom(s => s.TimeZone.NameValue))
                .ForMember(dest => dest.TimeZoneValue, src => src.MapFrom(s => s.TimeZone.TimeValue));

            CreateMap<UpdateTeamDto, Team>()
                .ForMember(dest => dest.LogoPath, src => src.MapFrom(s => s.Image))
                .ForMember(dest => dest.TimeZoneName, src => src.MapFrom(s => s.TimeZone.NameValue))
                .ForMember(dest => dest.TimeZoneValue, src => src.MapFrom(s => s.TimeZone.TimeValue));

            CreateMap<TeamMember, TeamMemberDto>();
        }
    }
}
