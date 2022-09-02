using AutoMapper;
using EasyMeets.Core.Common.DTO.Availability.Schedule;
using EasyMeets.Core.DAL.Entities;

namespace EasyMeets.Core.BLL.MappingProfiles;

public class ScheduleProfile : Profile
{
    public ScheduleProfile()
    {
        CreateMap<ScheduleDto, Schedule>()
            .ForMember(dest => dest.TimeZoneValue, src => src.MapFrom(s => s.TimeZone.TimeValue))
            .ForMember(dest => dest.TimeZoneName, src => src.MapFrom(s => s.TimeZone.NameValue));
        CreateMap<ScheduleItemDto, ScheduleItem>();
        
        CreateMap<Schedule, ScheduleDto>()
            .ForMember(dest => dest.TimeZone.TimeValue, src => src.MapFrom(s => s.TimeZoneValue))
            .ForMember(dest => dest.TimeZone.NameValue, src => src.MapFrom(s => s.TimeZoneName));
        CreateMap<ScheduleItem, ScheduleItemDto>();
    }
}