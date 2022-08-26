using AutoMapper;
using EasyMeets.Core.Common.DTO.Calendar;
using EasyMeets.Core.DAL.Entities;

namespace EasyMeets.Core.BLL.MappingProfiles;

public class CalendarProfile : Profile
{
    public CalendarProfile()
    {
        CreateMap<CalendarVisibleForTeam, CalendarVisibleForTeamDto>();
        CreateMap<Calendar, UserCalendarDto>()
            .ForMember(c => c.VisibleForTeams, src => src.MapFrom(opt => opt.VisibleForTeams.Select(x => x.Team)));
    }
}