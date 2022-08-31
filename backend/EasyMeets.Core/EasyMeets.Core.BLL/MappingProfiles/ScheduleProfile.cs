using AutoMapper;
using EasyMeets.Core.BLL.Helpers;
using EasyMeets.Core.Common.DTO.Availability.Schedule;
using EasyMeets.Core.DAL.Entities;

namespace EasyMeets.Core.BLL.MappingProfiles;

public class ScheduleProfile : Profile
{
    public ScheduleProfile()
    {
        CreateMap<ScheduleDto, Schedule>()
            .ForMember(dest => dest.TimeZoneValue, src => src.MapFrom(s => TimeZoneHelper.MapTimeZoneStringValue(s.TimeZoneValue)));
        CreateMap<ScheduleItemDto, ScheduleItem>();
        
        CreateMap<Schedule, ScheduleDto>();
        CreateMap<ScheduleItem, ScheduleItemDto>();
    }
}