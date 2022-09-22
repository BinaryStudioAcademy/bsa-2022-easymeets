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
        CreateMap<ScheduleItemDto, ScheduleItem>()
            .ForMember(dest => dest.Start, src
                => src.MapFrom(s => new TimeSpan(s.Start.Hour, s.Start.Minute, 0)))
            .ForMember(dest => dest.End, src
                => src.MapFrom(s => new TimeSpan(s.End.Hour, s.End.Minute, 0)));

        CreateMap<Schedule, ScheduleDto>()
            .ForPath(dest => dest.TimeZone.TimeValue, src => src.MapFrom(s => s.TimeZoneValue))
            .ForPath(dest => dest.TimeZone.NameValue, src => src.MapFrom(s => s.TimeZoneName));
        CreateMap<ScheduleItem, ScheduleItemDto>()
            .ForMember(dest => dest.Start, src
                => src.MapFrom(s => new TimeSpanDto{Hour = s.Start.Hours, Minute = s.Start.Minutes}))
            .ForMember(dest => dest.End, src
                => src.MapFrom(s => new TimeSpanDto{Hour = s.End.Hours, Minute = s.End.Minutes}));

    }
}